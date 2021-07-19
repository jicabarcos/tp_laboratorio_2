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
    public partial class FormCalculadora : Form
    {
        #region Atributos
        int contadorABinario;
        int contadorADecimal;
        #endregion

        /// <summary>
        /// Constructor por defecto del form
        /// </summary>
        public FormCalculadora()
        {
            this.InitializeComponent();
            this.contadorABinario = 0;
            this.contadorADecimal = 0;
        }

        /// <summary>
        /// Llama al método limpiar al cargarse el formulario.
        /// </summary>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Vacía los textos de txtNumero1, txtNumero2, cmbOperador y lblResultado
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.cmbOperador.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
        }
        
        /// <summary>
        /// Pide confirmación de la salida.
        /// </summary>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salida = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salida == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Acción del botón btnLimpiar. Llama al método Limpiar.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Realiza la operación indicada por el operador entre los 2 números ingresados.
        /// </summary>
        /// <param name="numero1">Primer operando.</param>
        /// <param name="numero2">Segundo operando.</param>
        /// <param name="operador">Operador.</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Acción del botón btnOperar. Llama al método Operar y asigna su resultado al label lblResultado.
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero1.Text == String.Empty || this.txtNumero2.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar ambos números antes de operar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.lblResultado.Text = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
                for(int i = 0; i < this.lblResultado.Text.Length; i++)
                {
                    if(this.lblResultado.Text[i].ToString() == ".")
                    {
                        MessageBox.Show("El resultado no es un número entero.\nPuede obtener un resultado distinto del original cuando realice alguna conversión.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }
                if (this.lblResultado.Text[0].ToString() == "-")
                {
                    MessageBox.Show("El resultado es un número negativo.\nAl realizar una conversión sólo se tendrá en cuenta el valor absoluto.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(this.cmbOperador.Text != "+" && this.cmbOperador.Text != "-" && this.cmbOperador.Text != "*" && this.cmbOperador.Text != "/")
                {
                    MessageBox.Show("No seleccionó un operador válido.\nSe utilizará el '+'.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.contadorABinario = 0;
                this.contadorADecimal = 0;
            }
        }

        /// <summary>
        /// Acción del botón btnConvertirABinario. Evalúa si ya existe un resultado. 
        /// En caso positivo, lo convierte a binario. De lo contrario, muestra un mensaje.
        /// </summary>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != String.Empty)
            {
                if(this.contadorABinario == 0)
                {
                    Numero num = new Numero();
                    this.lblResultado.Text = num.DecimalBinario(this.lblResultado.Text);
                    this.contadorABinario = 1;
                    this.contadorADecimal = 0;
                }
                else
                {
                    MessageBox.Show("El resultado ya es un número binario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe obtener un resultado antes de intentar convertirlo a binario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Acción del botón btnConvertirADecimal. Evalúa si ya existe un resultado. 
        /// En caso positivo, lo convierte a binario. De lo contrario, muestra un mensaje.
        /// </summary>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != String.Empty)
            {
                if(this.contadorADecimal == 0)
                {
                    Numero num = new Numero();
                    this.lblResultado.Text = num.BinarioDecimal(this.lblResultado.Text);
                    this.contadorADecimal = 1;
                    this.contadorABinario = 0;
                }
                else
                {
                    MessageBox.Show("El resultado ya es un número decimal.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe tener un resultado convertido en binario para convertirlo de vuelta a decimal.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Acción del botón btnCerrar. Llama al método Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
