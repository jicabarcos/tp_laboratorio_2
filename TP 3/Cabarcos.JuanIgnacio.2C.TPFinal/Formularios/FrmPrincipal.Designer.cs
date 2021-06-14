
namespace Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListar = new System.Windows.Forms.Button();
            this.richTxtLista = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(624, 371);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 67);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Companions";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // richTxtLista
            // 
            this.richTxtLista.Location = new System.Drawing.Point(12, 10);
            this.richTxtLista.Name = "richTxtLista";
            this.richTxtLista.Size = new System.Drawing.Size(776, 355);
            this.richTxtLista.TabIndex = 1;
            this.richTxtLista.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 371);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 67);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Companion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.richTxtLista);
            this.Controls.Add(this.btnListar);
            this.Name = "FrmPrincipal";
            this.Text = "Fabrica de Companions - Juan Ignacio Cabarcos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RichTextBox richTxtLista;
        private System.Windows.Forms.Button btnAgregar;
    }
}

