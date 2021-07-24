
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
            this.richTxtDB = new System.Windows.Forms.RichTextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.btnColaFabricacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(285, 371);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(73, 67);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Companions";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // richTxtLista
            // 
            this.richTxtLista.Location = new System.Drawing.Point(12, 24);
            this.richTxtLista.Name = "richTxtLista";
            this.richTxtLista.Size = new System.Drawing.Size(674, 341);
            this.richTxtLista.TabIndex = 1;
            this.richTxtLista.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 371);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 67);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "1) Agregar Companion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnXmlSer
            // 
            this.btnXmlSer.Location = new System.Drawing.Point(550, 371);
            this.btnXmlSer.Name = "btnXmlSer";
            this.btnXmlSer.Size = new System.Drawing.Size(65, 67);
            this.btnXmlSer.TabIndex = 4;
            this.btnXmlSer.Text = "Guardar .xml";
            this.btnXmlSer.UseVisualStyleBackColor = true;
            this.btnXmlSer.Click += new System.EventHandler(this.btnXmlSer_Click);
            // 
            // btnBinarySer
            // 
            this.btnBinarySer.Location = new System.Drawing.Point(621, 371);
            this.btnBinarySer.Name = "btnBinarySer";
            this.btnBinarySer.Size = new System.Drawing.Size(65, 67);
            this.btnBinarySer.TabIndex = 6;
            this.btnBinarySer.Text = "Guardar .bin";
            this.btnBinarySer.UseVisualStyleBackColor = true;
            this.btnBinarySer.Click += new System.EventHandler(this.btnBinarySer_Click);
            // 
            // btnDBImport
            // 
            this.btnDBImport.Location = new System.Drawing.Point(720, 371);
            this.btnDBImport.Name = "btnDBImport";
            this.btnDBImport.Size = new System.Drawing.Size(154, 67);
            this.btnDBImport.TabIndex = 7;
            this.btnDBImport.Text = "Importar desde DB";
            this.btnDBImport.UseVisualStyleBackColor = true;
            this.btnDBImport.Click += new System.EventHandler(this.btnDBImport_Click);
            // 
            // btnDBExport
            // 
            this.btnDBExport.Location = new System.Drawing.Point(886, 371);
            this.btnDBExport.Name = "btnDBExport";
            this.btnDBExport.Size = new System.Drawing.Size(154, 67);
            this.btnDBExport.TabIndex = 8;
            this.btnDBExport.Text = "Exportar a DB";
            this.btnDBExport.UseVisualStyleBackColor = true;
            this.btnDBExport.Click += new System.EventHandler(this.btnDBExport_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHora.Location = new System.Drawing.Point(578, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 9;
            // 
            // btnGuardarTxt
            // 
            this.btnGuardarTxt.Location = new System.Drawing.Point(479, 371);
            this.btnGuardarTxt.Name = "btnGuardarTxt";
            this.btnGuardarTxt.Size = new System.Drawing.Size(65, 67);
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
            // richTxtDB
            // 
            this.richTxtDB.Location = new System.Drawing.Point(720, 24);
            this.richTxtDB.Name = "richTxtDB";
            this.richTxtDB.Size = new System.Drawing.Size(320, 341);
            this.richTxtDB.TabIndex = 12;
            this.richTxtDB.Text = "";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.BackColor = System.Drawing.Color.Transparent;
            this.lblDB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDB.Location = new System.Drawing.Point(718, 9);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(98, 13);
            this.lblDB.TabIndex = 13;
            this.lblDB.Text = "Log Base de Datos";
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFabricar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFabricar.Location = new System.Drawing.Point(164, 371);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(115, 67);
            this.btnFabricar.TabIndex = 14;
            this.btnFabricar.Text = "3) FABRICAR";
            this.btnFabricar.UseVisualStyleBackColor = false;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // btnColaFabricacion
            // 
            this.btnColaFabricacion.Location = new System.Drawing.Point(88, 371);
            this.btnColaFabricacion.Name = "btnColaFabricacion";
            this.btnColaFabricacion.Size = new System.Drawing.Size(70, 67);
            this.btnColaFabricacion.TabIndex = 15;
            this.btnColaFabricacion.Text = "2) Preparar cola de fabricación";
            this.btnColaFabricacion.UseVisualStyleBackColor = true;
            this.btnColaFabricacion.Click += new System.EventHandler(this.btnColaFabricacion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.btnColaFabricacion);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.richTxtDB);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.RichTextBox richTxtDB;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Button btnColaFabricacion;
    }
}

