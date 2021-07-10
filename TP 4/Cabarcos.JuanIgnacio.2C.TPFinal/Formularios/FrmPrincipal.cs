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
using Entidades;

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
            this.SetHora();
            //this.btnGuardarTxt.Click += btnGuardarTxt_Click;
            Factory.GuardarCompanionTxt += this.RealizarGuardadoTxt;
        }

        /// <summary>
        /// Click del botón btnListar. Muestra la lista de Companions, verificando que no se haya mostrado antes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click(object sender, EventArgs e)
        {
            if(aux==0)
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

        private void RealizarGuardadoTxt()
        {
            if (this.btnGuardarTxt.InvokeRequired)
            {
                CrearDelegate d = new CrearDelegate(RealizarGuardadoTxt);
                this.Invoke(d);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("..\\..\\..\\Listado_Companions.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine(this.lblHora.Text + "\n");
                    sw.WriteLine(Factory.MostrarListado<Companion>());
                    sw.Write("==============================\n");
                }
            }

        }
    }
}
