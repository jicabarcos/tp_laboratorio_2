
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
            this.btnXmlDeser = new System.Windows.Forms.Button();
            this.btnBinarySer = new System.Windows.Forms.Button();
            this.btnBinaryDeser = new System.Windows.Forms.Button();
            this.btnDBImport = new System.Windows.Forms.Button();
            this.btnDBExport = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGuardarTxt = new System.Windows.Forms.Button();
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
            this.btnXmlSer.Location = new System.Drawing.Point(434, 371);
            this.btnXmlSer.Name = "btnXmlSer";
            this.btnXmlSer.Size = new System.Drawing.Size(80, 30);
            this.btnXmlSer.TabIndex = 3;
            this.btnXmlSer.Text = "XML Import";
            this.btnXmlSer.UseVisualStyleBackColor = true;
            // 
            // btnXmlDeser
            // 
            this.btnXmlDeser.Location = new System.Drawing.Point(434, 408);
            this.btnXmlDeser.Name = "btnXmlDeser";
            this.btnXmlDeser.Size = new System.Drawing.Size(80, 30);
            this.btnXmlDeser.TabIndex = 4;
            this.btnXmlDeser.Text = "XML Export";
            this.btnXmlDeser.UseVisualStyleBackColor = true;
            // 
            // btnBinarySer
            // 
            this.btnBinarySer.Location = new System.Drawing.Point(520, 371);
            this.btnBinarySer.Name = "btnBinarySer";
            this.btnBinarySer.Size = new System.Drawing.Size(80, 30);
            this.btnBinarySer.TabIndex = 5;
            this.btnBinarySer.Text = "Binary Import";
            this.btnBinarySer.UseVisualStyleBackColor = true;
            // 
            // btnBinaryDeser
            // 
            this.btnBinaryDeser.Location = new System.Drawing.Point(520, 408);
            this.btnBinaryDeser.Name = "btnBinaryDeser";
            this.btnBinaryDeser.Size = new System.Drawing.Size(80, 30);
            this.btnBinaryDeser.TabIndex = 6;
            this.btnBinaryDeser.Text = "Binary Export";
            this.btnBinaryDeser.UseVisualStyleBackColor = true;
            // 
            // btnDBImport
            // 
            this.btnDBImport.Location = new System.Drawing.Point(606, 371);
            this.btnDBImport.Name = "btnDBImport";
            this.btnDBImport.Size = new System.Drawing.Size(80, 30);
            this.btnDBImport.TabIndex = 7;
            this.btnDBImport.Text = "DB Import";
            this.btnDBImport.UseVisualStyleBackColor = true;
            // 
            // btnDBExport
            // 
            this.btnDBExport.Location = new System.Drawing.Point(606, 408);
            this.btnDBExport.Name = "btnDBExport";
            this.btnDBExport.Size = new System.Drawing.Size(80, 30);
            this.btnDBExport.TabIndex = 8;
            this.btnDBExport.Text = "DB Export";
            this.btnDBExport.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(340, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 9;
            // 
            // btnGuardarTxt
            // 
            this.btnGuardarTxt.Location = new System.Drawing.Point(352, 371);
            this.btnGuardarTxt.Name = "btnGuardarTxt";
            this.btnGuardarTxt.Size = new System.Drawing.Size(75, 67);
            this.btnGuardarTxt.TabIndex = 10;
            this.btnGuardarTxt.Text = "Guardar .txt";
            this.btnGuardarTxt.UseVisualStyleBackColor = true;
            this.btnGuardarTxt.Click += new System.EventHandler(this.btnGuardarTxt_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarTxt);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnDBExport);
            this.Controls.Add(this.btnDBImport);
            this.Controls.Add(this.btnBinaryDeser);
            this.Controls.Add(this.btnBinarySer);
            this.Controls.Add(this.btnXmlDeser);
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
        private System.Windows.Forms.Button btnXmlDeser;
        private System.Windows.Forms.Button btnBinarySer;
        private System.Windows.Forms.Button btnBinaryDeser;
        private System.Windows.Forms.Button btnDBImport;
        private System.Windows.Forms.Button btnDBExport;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnGuardarTxt;
    }
}

