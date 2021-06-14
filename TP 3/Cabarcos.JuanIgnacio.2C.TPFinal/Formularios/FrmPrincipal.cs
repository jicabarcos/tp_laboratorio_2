using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        public int aux = 0;

        /// <summary>
        /// Constructor publico de la clase FrmPrincipal
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load del Form. Instancia algunos Companions y los agrega a la Factory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        { 

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
    }
}
