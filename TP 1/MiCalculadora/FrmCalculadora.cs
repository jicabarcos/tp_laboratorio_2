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

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        /// <summary>
        /// Constructor por defecto del form
        /// </summary>
        public FrmCalculadora()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Limpia los contenidos de txtNumero1, txtNumero2, cmbOperador y lblResultado
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.ResetText();
        }

        /// <summary>
        /// Realiza la operacion indicada
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns>Resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }
        
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar la calculadora?", "Cerrar", MessageBoxButtons.YesNo, 
               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Elimina los contenidos de txtNumero1, txtNumero2, cmbOperador y lblResultado por medio del metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();

            this.lblResultado.Text = num1.DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();

            this.lblResultado.Text = num1.BinarioDecimal(this.lblResultado.Text);
        }

        /// <summary>
        /// Realiza una operacion en base a los contenidos de txtNumero1, cmbOperador y txtNumero2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

    }
}
