
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
            this.btnXmlSer = new System.Windows.Forms.Button();
            this.btnBinarySer = new System.Windows.Forms.Button();
            this.btnDBImport = new System.Windows.Forms.Button();
            this.btnDBExport = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGuardarTxt = new System.Windows.Forms.Button();
            this.chBoxEncender = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(182, 371);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 67);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Companions";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // richTxtLista
            // 
            this.richTxtLista.Location = new System.Drawing.Point(12, 24);
            this.richTxtLista.Name = "richTxtLista";
            this.richTxtLista.Size = new System.Drawing.Size(776, 341);
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
            // btnXmlSer
            // 
            this.btnXmlSer.Location = new System.Drawing.Point(509, 371);
            this.btnXmlSer.Name = "btnXmlSer";
            this.btnXmlSer.Size = new System.Drawing.Size(80, 67);
            this.btnXmlSer.TabIndex = 4;
            this.btnXmlSer.Text = "Guardar .xml";
            this.btnXmlSer.UseVisualStyleBackColor = true;
            this.btnXmlSer.Click += new System.EventHandler(this.btnXmlSer_Click);
            // 
            // btnBinarySer
            // 
            this.btnBinarySer.Location = new System.Drawing.Point(595, 371);
            this.btnBinarySer.Name = "btnBinarySer";
            this.btnBinarySer.Size = new System.Drawing.Size(80, 67);
            this.btnBinarySer.TabIndex = 6;
            this.btnBinarySer.Text = "Guardar .bin";
            this.btnBinarySer.UseVisualStyleBackColor = true;
            this.btnBinarySer.Click += new System.EventHandler(this.btnBinarySer_Click);
            // 
            // btnDBImport
            // 
            this.btnDBImport.Location = new System.Drawing.Point(681, 371);
            this.btnDBImport.Name = "btnDBImport";
            this.btnDBImport.Size = new System.Drawing.Size(107, 30);
            this.btnDBImport.TabIndex = 7;
            this.btnDBImport.Text = "Importar desde DB";
            this.btnDBImport.UseVisualStyleBackColor = true;
            this.btnDBImport.Click += new System.EventHandler(this.btnDBImport_Click);
            // 
            // btnDBExport
            // 
            this.btnDBExport.Location = new System.Drawing.Point(681, 408);
            this.btnDBExport.Name = "btnDBExport";
            this.btnDBExport.Size = new System.Drawing.Size(107, 30);
            this.btnDBExport.TabIndex = 8;
            this.btnDBExport.Text = "Exportar a DB";
            this.btnDBExport.UseVisualStyleBackColor = true;
            this.btnDBExport.Click += new System.EventHandler(this.btnDBExport_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Location = new System.Drawing.Point(340, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 9;
            // 
            // btnGuardarTxt
            // 
            this.btnGuardarTxt.Location = new System.Drawing.Point(427, 371);
            this.btnGuardarTxt.Name = "btnGuardarTxt";
            this.btnGuardarTxt.Size = new System.Drawing.Size(75, 67);
            this.btnGuardarTxt.TabIndex = 10;
            this.btnGuardarTxt.Text = "Guardar .txt";
            this.btnGuardarTxt.UseVisualStyleBackColor = true;
            this.btnGuardarTxt.Click += new System.EventHandler(this.btnGuardarTxt_Click);
            // 
            // chBoxEncender
            // 
            this.chBoxEncender.AutoSize = true;
            this.chBoxEncender.Location = new System.Drawing.Point(12, 5);
            this.chBoxEncender.Name = "chBoxEncender";
            this.chBoxEncender.Size = new System.Drawing.Size(115, 17);
            this.chBoxEncender.TabIndex = 11;
            this.chBoxEncender.Text = "Fabrica Encendida";
            this.chBoxEncender.UseVisualStyleBackColor = true;
            this.chBoxEncender.CheckedChanged += new System.EventHandler(this.chBoxEncender_CheckedChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chBoxEncender);
            this.Controls.Add(this.btnGuardarTxt);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnDBExport);
            this.Controls.Add(this.btnDBImport);
            this.Controls.Add(this.btnBinarySer);
            this.Controls.Add(this.btnXmlSer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.richTxtLista);
            this.Controls.Add(this.btnListar);
            this.Name = "FrmPrincipal";
            this.Text = "Fabrica de Companions - Juan Ignacio Cabarcos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RichTextBox richTxtLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnXmlSer;
        private System.Windows.Forms.Button btnBinarySer;
        private System.Windows.Forms.Button btnDBImport;
        private System.Windows.Forms.Button btnDBExport;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnGuardarTxt;
        private System.Windows.Forms.CheckBox chBoxEncender;
    }
}

