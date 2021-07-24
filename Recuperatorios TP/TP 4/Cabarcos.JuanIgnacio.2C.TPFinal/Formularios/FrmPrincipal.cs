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
    public partial class FrmPrincipal : Form
    {
        private int listarContador = 0;
        private Thread hiloHora;
        private Thread hiloTxt;

        /// <summary>
        /// Constructor publico de la clase FrmPrincipal.
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load del formulario. Setea la propiedad BackgroundImage del formulario. Llama al método SetHora.
        /// Suscribe un manejador al evento GuardarCompanionTxt de la clase Factory.
        /// </summary>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Formularios.Properties.Resources.fondoFrmPrincipal;
            this.SetHora();
            this.chBoxEncender.BackColor = Color.Red;
            Factory.GuardarCompanionTxt += this.RealizarGuardadoTxt;
        }

        /// <summary>
        /// Click del botón btnListar. Muestra la lista de Companions fabricados, verificando que no se haya mostrado antes.
        /// </summary>
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (this.listarContador == 0)
            {
                this.richTxtLista.Text += "LISTA DE COMPANIONS FABRICADOS:\n\n";
                this.richTxtLista.Text += Factory.MostrarListado<Companion>();
                listarContador = 1;
            }
        }

        /// <summary>
        /// Click del botón btnAgregar. Abre un nuevo formulario para agregar un Companion a la lista.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCompanion unFrmAgregar = new FrmAgregarCompanion();
            unFrmAgregar.Show();
            this.listarContador = 0;
            this.richTxtLista.Text = "";
        }

        /// <summary>
        /// Inicializa el atributo hiloHora con el método RefrescarHora.
        /// Da inicio a dicho hilo.
        /// </summary>
        private void SetHora()
        {
            this.hiloHora = new Thread(this.RefrescarHora);
            hiloHora.Start();
        }

        /// <summary>
        /// Muestra día y hora actuales en el label lblHora.
        /// </summary>
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

        /// <summary>
        /// Acción del click del botón btnGuardarTxt.
        /// Si hay al menos un Companion en la lista, inicializa el atributo hiloTxt con el método RealizarGuardadoTxt y le da inicio.
        /// Si no hay Companions muestra un mensaje.
        /// </summary>
        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            if (Factory.ListaCompanions.Count > 0)
            {
                hiloTxt = new Thread(this.RealizarGuardadoTxt);
                hiloTxt.Start();
            }
            else
            {
                MessageBox.Show("No hay Companions para agregar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Al intentar cerrar el formulario mostrará un mensaje que permitirá cancelar el cierre.
        /// Aborta los hilos que estén aún vivos.
        /// </summary>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            if (this.hiloHora != null && this.hiloHora.IsAlive)
            {
                this.hiloHora.Abort();
            }

            if(this.hiloTxt != null && this.hiloTxt.IsAlive)
            {
                this.hiloTxt.Abort();
            }
        }

        /// <summary>
        /// Escribe el listado de Companions en un archivo de texto.
        /// </summary>
        public void RealizarGuardadoTxt()
        {
            if (this.btnGuardarTxt.InvokeRequired)
            {
                CrearDelegate d = new CrearDelegate(RealizarGuardadoTxt);
                this.Invoke(d);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("Archivos\\listado_companions.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine(this.lblHora.Text + "\n");
                    sw.WriteLine(Factory.MostrarListado<Companion>());
                    sw.Write("==============================\n\n");
                }
                MessageBox.Show($"Companion agregado al archivo de texto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Importa los Companions de la base de datos a un archivo de texto.
        /// También los muestra en el log del RichTextBox richTxtDB.
        /// </summary>
        private void btnDBImport_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictCompanions = DBManagement.ImportFromDB();
            StringBuilder sb = new StringBuilder();
            string textoArchivo;
                        
            if(dictCompanions.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter("Archivos\\listado_companions_desde_db.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine($"{dictCompanions.Count} Companion/s importados desde la BD -- {this.lblHora.Text}\n");
                    foreach (var item in dictCompanions)
                    {
                        sw.WriteLine($"{item.Key.ToString()} --- Fecha creación: {item.Value.ToString()}");
                    }
                    sw.Write("==============================\n\n");
                }
                using (StreamReader sr = new StreamReader("Archivos\\listado_companions_desde_db.txt"))
                {
                    textoArchivo = sr.ReadToEnd();
                }
                this.richTxtDB.Text += textoArchivo;
                MessageBox.Show($"Companions de la DB importados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay ningún Companion en la BD para importar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Exporta los Companions a la base de datos.
        /// Muestra un mensaje en el log del RichTextBox richTxtDB.
        /// </summary>
        private void btnDBExport_Click(object sender, EventArgs e)
        {
            int filasAgregadas = DBManagement.ExportToDB(Factory.ListaCompanions);
            StringBuilder sb = new StringBuilder();

            if(filasAgregadas > 0)
            {
                sb.AppendLine($"{filasAgregadas} Companion/s exportado/s a la BD.\n");
                foreach(Companion item in Factory.ListaCompanions)
                {
                    sb.AppendLine($"{item.Nombre} --- Fecha exportación: {DateTime.Now}");
                }
                sb.AppendLine("==============================\n\n");
                this.richTxtDB.Text += sb.ToString();
                MessageBox.Show($"{filasAgregadas} Companion/s agregado/s a la BD.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay ningún Companion para exportar a la BD.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Serializa a binario todos los Companions de la lista Factory.ListaCompanions que ya hayan sido fabricados.
        /// Muestra un mensaje notificando cuantos Companions fueron serializados.
        /// </summary>
        private void btnBinarySer_Click(object sender, EventArgs e)
        {
            List<Companion> listaComp = Factory.ListaCompanions;
            int cantidadSerializados = 0;

            foreach (Companion item in listaComp)
            {
                if (item.SelloFabricacion)
                {
                    if (item is Cook)
                    {
                        Cook aux = (Cook)item;
                        Serializer<Cook>.SerializeToBinary(aux, "Archivos\\listado_companions.bin");
                    }
                    else if (item is Housekeeper)
                    {
                        Housekeeper aux = (Housekeeper)item;
                        Serializer<Housekeeper>.SerializeToBinary(aux, "Archivos\\listado_companions.bin");
                    }
                    else
                    {
                        Manager aux = (Manager)item;
                        Serializer<Manager>.SerializeToBinary(aux, "Archivos\\listado_companions.bin");
                    }
                    cantidadSerializados++;
                }
            }
            MessageBox.Show($"{cantidadSerializados} Companion/s agregado/s al archvio binario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Serializa a XML los Companions de la lista Factory.ListaCompanions.
        /// </summary>
        private void btnXmlSer_Click(object sender, EventArgs e)
        {
            Serializer<List<Companion>>.SerializeToXml(Factory.ListaCompanions, "Archivos\\listado_companions.xml");
            MessageBox.Show($"{Factory.ListaCompanions.Count} Companion/s agregado/s al archvio XML.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Establece el estado de la fabrica mediante el método Factory.EncenderFabrica.
        /// </summary>
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

        /// <summary>
        /// Pone en cola de fabricación a los Companions que correspondan.
        /// </summary>
        private void btnColaFabricacion_Click(object sender, EventArgs e)
        {
            if (Factory.PonerEnCola())
            {
                MessageBox.Show($"Cola de fabricación lista!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No hay ningún Companion para poner en cola de fabricación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Fabrica los Companions que estén en cola de fabricación.
        /// </summary>
        private void btnFabricar_Click(object sender, EventArgs e)
        {
            int companionsFabricados = Factory.Fabricar();

            if (companionsFabricados > 0)
            {
                MessageBox.Show($"{companionsFabricados} Companion/s fabricados con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No hay ningún Companion en cola para fabricar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.richTxtLista.Text = "";
            this.listarContador = 0;
        }
    }
}
