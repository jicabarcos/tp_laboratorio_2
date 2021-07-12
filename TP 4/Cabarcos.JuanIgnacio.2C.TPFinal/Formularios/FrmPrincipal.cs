using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Entidades;
using Entidades.Excepciones;

namespace Formularios
{
    //public delegate void GuardarDelegate();

    public partial class FrmPrincipal : Form
    {
        private int aux = 0;
        private Thread hiloHora;

        /// <summary>
        /// Constructor publico de la clase FrmPrincipal
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load del Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Formularios.Properties.Resources.fondoFrmPrincipal;
            this.SetHora();
            this.chBoxEncender.BackColor = Color.Red;
            Factory.GuardarCompanionTxt += this.RealizarGuardadoTxt;
        }

        /// <summary>
        /// Click del botón btnListar. Muestra la lista de Companions, verificando que no se haya mostrado antes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                this.richTxtLista.Text += "LISTA DE COMPANIONS:\n";
                this.richTxtLista.Text += Factory.MostrarListado<Companion>();
                aux = 1;
            }
        }

        /// <summary>
        /// Click del botón btnAgregar. Abre un nuevo formulario para agregar un Companion a la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCompanion unFrmAgregar = new FrmAgregarCompanion();
            unFrmAgregar.Show();
            this.aux = 0;
            this.richTxtLista.Text = "";
        }

        private void SetHora()
        {
            this.hiloHora = new Thread(this.RefrescarHora);
            hiloHora.Start();
        }

        private void RefrescarHora()
        {
            while (true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.Now.ToString();
                    });
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString();
                }
                Thread.Sleep(1000);
            }
        }

        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hiloHora != null && this.hiloHora.IsAlive)
            {
                this.hiloHora.Abort();
            }
        }

        public bool RealizarGuardadoTxt()
        {
            if (this.btnGuardarTxt.InvokeRequired)
            {
                CrearDelegate d = new CrearDelegate(RealizarGuardadoTxt);
                this.Invoke(d);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("..\\..\\..\\listado_companions.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine(this.lblHora.Text + "\n");
                    sw.WriteLine(Factory.MostrarListado<Companion>());
                    sw.Write("==============================\n\n");
                }
                MessageBox.Show($"Companion agregado al archvio de texto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;

        }

        private void btnDBImport_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictCompanions = DBManagement.ImportFromDB();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Lista de companions en la base de datos:\n");
            foreach (var item in dictCompanions)
            {
                sb.AppendLine($"{item.Key.ToString()} --- {item.Value.ToString()}");
            }

            MessageBox.Show($"{sb.ToString()}", $"{dictCompanions.Count} companion/s en la BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDBExport_Click(object sender, EventArgs e)
        {
            int filasAgregadas = DBManagement.ExportToDB(Factory.ListaCompanions);

            MessageBox.Show($"{filasAgregadas} companion/s agregado/s a la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBinarySer_Click(object sender, EventArgs e)
        {
            List<Companion> listaComp = Factory.ListaCompanions;
            int cantidadSerializados = 0;

            foreach (Companion item in listaComp)
            {
                if (item is Cook)
                {
                    Cook aux = (Cook)item;
                    Serializer<Cook>.SerializeToBinary(aux, "..\\..\\..\\listado_companions.bin");
                }
                else if (item is Housekeeper)
                {
                    Housekeeper aux = (Housekeeper)item;
                    Serializer<Housekeeper>.SerializeToBinary(aux, "..\\..\\..\\listado_companions.bin");
                }
                else
                {
                    Manager aux = (Manager)item;
                    Serializer<Manager>.SerializeToBinary(aux, "..\\..\\..\\listado_companions.bin");
                }
                cantidadSerializados++;
            }
            MessageBox.Show($"{cantidadSerializados} Companion/s agregado/s al archvio binario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXmlSer_Click(object sender, EventArgs e)
        {
            Serializer<List<Companion>>.SerializeToXml(Factory.ListaCompanions, "..\\..\\..\\listado_companions.xml");
            MessageBox.Show($"{Factory.ListaCompanions.Count} Companion/s agregado/s al archvio XML.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chBoxEncender_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxEncender.Checked)
            {
                chBoxEncender.BackColor = Color.Green;
            }
            else
            {
                chBoxEncender.BackColor = Color.Red;
            }
            Factory.EncenderFabrica(chBoxEncender.Checked);
        }
    }
}
