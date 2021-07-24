
namespace Formularios
{
    partial class FrmAgregarCompanion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblTareas = new System.Windows.Forms.Label();
            this.chBoxLimpiar = new System.Windows.Forms.CheckBox();
            this.chBoxOrdenar = new System.Windows.Forms.CheckBox();
            this.chBoxBarrer = new System.Windows.Forms.CheckBox();
            this.chBoxCocinar = new System.Windows.Forms.CheckBox();
            this.chBoxComprarComida = new System.Windows.Forms.CheckBox();
            this.chBoxOrganizarGastos = new System.Windows.Forms.CheckBox();
            this.lblNivelDeAcceso = new System.Windows.Forms.Label();
            this.cmbBoxNivelAcceso = new System.Windows.Forms.ComboBox();
            this.lblUtensilios = new System.Windows.Forms.Label();
            this.chBoxCubiertos = new System.Windows.Forms.CheckBox();
            this.chBoxOllas = new System.Windows.Forms.CheckBox();
            this.chBoxSartenes = new System.Windows.Forms.CheckBox();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(326, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 48);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar a la lista";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipo.Location = new System.Drawing.Point(23, 12);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbBoxTipo
            // 
            this.cmbBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTipo.FormattingEnabled = true;
            this.cmbBoxTipo.Items.AddRange(new object[] {
            "Cook",
            "Housekeeper",
            "Manager"});
            this.cmbBoxTipo.Location = new System.Drawing.Point(177, 14);
            this.cmbBoxTipo.Name = "cmbBoxTipo";
            this.cmbBoxTipo.Size = new System.Drawing.Size(131, 21);
            this.cmbBoxTipo.TabIndex = 1;
            // 
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTareas.Location = new System.Drawing.Point(23, 56);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(62, 20);
            this.lblTareas.TabIndex = 4;
            this.lblTareas.Text = "Tareas:";
            // 
            // chBoxLimpiar
            // 
            this.chBoxLimpiar.AutoSize = true;
            this.chBoxLimpiar.Location = new System.Drawing.Point(177, 60);
            this.chBoxLimpiar.Name = "chBoxLimpiar";
            this.chBoxLimpiar.Size = new System.Drawing.Size(59, 17);
            this.chBoxLimpiar.TabIndex = 5;
            this.chBoxLimpiar.Text = "Limpiar";
            this.chBoxLimpiar.UseVisualStyleBackColor = true;
            // 
            // chBoxOrdenar
            // 
            this.chBoxOrdenar.AutoSize = true;
            this.chBoxOrdenar.Location = new System.Drawing.Point(258, 60);
            this.chBoxOrdenar.Name = "chBoxOrdenar";
            this.chBoxOrdenar.Size = new System.Drawing.Size(64, 17);
            this.chBoxOrdenar.TabIndex = 6;
            this.chBoxOrdenar.Text = "Ordenar";
            this.chBoxOrdenar.UseVisualStyleBackColor = true;
            // 
            // chBoxBarrer
            // 
            this.chBoxBarrer.AutoSize = true;
            this.chBoxBarrer.Location = new System.Drawing.Point(341, 59);
            this.chBoxBarrer.Name = "chBoxBarrer";
            this.chBoxBarrer.Size = new System.Drawing.Size(54, 17);
            this.chBoxBarrer.TabIndex = 7;
            this.chBoxBarrer.Text = "Barrer";
            this.chBoxBarrer.UseVisualStyleBackColor = true;
            // 
            // chBoxCocinar
            // 
            this.chBoxCocinar.AutoSize = true;
            this.chBoxCocinar.Location = new System.Drawing.Point(177, 83);
            this.chBoxCocinar.Name = "chBoxCocinar";
            this.chBoxCocinar.Size = new System.Drawing.Size(62, 17);
            this.chBoxCocinar.TabIndex = 8;
            this.chBoxCocinar.Text = "Cocinar";
            this.chBoxCocinar.UseVisualStyleBackColor = true;
            // 
            // chBoxComprarComida
            // 
            this.chBoxComprarComida.AutoSize = true;
            this.chBoxComprarComida.Location = new System.Drawing.Point(258, 83);
            this.chBoxComprarComida.Name = "chBoxComprarComida";
            this.chBoxComprarComida.Size = new System.Drawing.Size(103, 17);
            this.chBoxComprarComida.TabIndex = 9;
            this.chBoxComprarComida.Text = "Comprar Comida";
            this.chBoxComprarComida.UseVisualStyleBackColor = true;
            // 
            // chBoxOrganizarGastos
            // 
            this.chBoxOrganizarGastos.AutoSize = true;
            this.chBoxOrganizarGastos.Location = new System.Drawing.Point(177, 106);
            this.chBoxOrganizarGastos.Name = "chBoxOrganizarGastos";
            this.chBoxOrganizarGastos.Size = new System.Drawing.Size(107, 17);
            this.chBoxOrganizarGastos.TabIndex = 10;
            this.chBoxOrganizarGastos.Text = "Organizar Gastos";
            this.chBoxOrganizarGastos.UseVisualStyleBackColor = true;
            // 
            // lblNivelDeAcceso
            // 
            this.lblNivelDeAcceso.AutoSize = true;
            this.lblNivelDeAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNivelDeAcceso.Location = new System.Drawing.Point(23, 148);
            this.lblNivelDeAcceso.Name = "lblNivelDeAcceso";
            this.lblNivelDeAcceso.Size = new System.Drawing.Size(123, 20);
            this.lblNivelDeAcceso.TabIndex = 11;
            this.lblNivelDeAcceso.Text = "Nivel de acceso:";
            // 
            // cmbBoxNivelAcceso
            // 
            this.cmbBoxNivelAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNivelAcceso.FormattingEnabled = true;
            this.cmbBoxNivelAcceso.Items.AddRange(new object[] {
            "Bajo",
            "Medio",
            "Alto"});
            this.cmbBoxNivelAcceso.Location = new System.Drawing.Point(177, 150);
            this.cmbBoxNivelAcceso.Name = "cmbBoxNivelAcceso";
            this.cmbBoxNivelAcceso.Size = new System.Drawing.Size(131, 21);
            this.cmbBoxNivelAcceso.TabIndex = 12;
            // 
            // lblUtensilios
            // 
            this.lblUtensilios.AutoSize = true;
            this.lblUtensilios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUtensilios.Location = new System.Drawing.Point(23, 212);
            this.lblUtensilios.Name = "lblUtensilios";
            this.lblUtensilios.Size = new System.Drawing.Size(82, 20);
            this.lblUtensilios.TabIndex = 13;
            this.lblUtensilios.Text = "Utensilios:";
            // 
            // chBoxCubiertos
            // 
            this.chBoxCubiertos.AutoSize = true;
            this.chBoxCubiertos.Location = new System.Drawing.Point(177, 216);
            this.chBoxCubiertos.Name = "chBoxCubiertos";
            this.chBoxCubiertos.Size = new System.Drawing.Size(70, 17);
            this.chBoxCubiertos.TabIndex = 14;
            this.chBoxCubiertos.Text = "Cubiertos";
            this.chBoxCubiertos.UseVisualStyleBackColor = true;
            // 
            // chBoxOllas
            // 
            this.chBoxOllas.AutoSize = true;
            this.chBoxOllas.Location = new System.Drawing.Point(177, 239);
            this.chBoxOllas.Name = "chBoxOllas";
            this.chBoxOllas.Size = new System.Drawing.Size(49, 17);
            this.chBoxOllas.TabIndex = 15;
            this.chBoxOllas.Text = "Ollas";
            this.chBoxOllas.UseVisualStyleBackColor = true;
            // 
            // chBoxSartenes
            // 
            this.chBoxSartenes.AutoSize = true;
            this.chBoxSartenes.Location = new System.Drawing.Point(177, 262);
            this.chBoxSartenes.Name = "chBoxSartenes";
            this.chBoxSartenes.Size = new System.Drawing.Size(68, 17);
            this.chBoxSartenes.TabIndex = 16;
            this.chBoxSartenes.Text = "Sartenes";
            this.chBoxSartenes.UseVisualStyleBackColor = true;
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.chBoxSartenes);
            this.gBox.Controls.Add(this.chBoxOllas);
            this.gBox.Controls.Add(this.chBoxCubiertos);
            this.gBox.Controls.Add(this.lblUtensilios);
            this.gBox.Controls.Add(this.cmbBoxNivelAcceso);
            this.gBox.Controls.Add(this.lblNivelDeAcceso);
            this.gBox.Controls.Add(this.chBoxOrganizarGastos);
            this.gBox.Controls.Add(this.chBoxComprarComida);
            this.gBox.Controls.Add(this.chBoxCocinar);
            this.gBox.Controls.Add(this.chBoxBarrer);
            this.gBox.Controls.Add(this.chBoxOrdenar);
            this.gBox.Controls.Add(this.chBoxLimpiar);
            this.gBox.Controls.Add(this.lblTareas);
            this.gBox.Controls.Add(this.cmbBoxTipo);
            this.gBox.Controls.Add(this.lblTipo);
            this.gBox.Location = new System.Drawing.Point(11, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(416, 312);
            this.gBox.TabIndex = 18;
            this.gBox.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(11, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 48);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmAgregarCompanion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 384);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmAgregarCompanion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarCompanion";
            this.Load += new System.EventHandler(this.FrmAgregarCompanion_Load);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbBoxTipo;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.CheckBox chBoxLimpiar;
        private System.Windows.Forms.CheckBox chBoxOrdenar;
        private System.Windows.Forms.CheckBox chBoxBarrer;
        private System.Windows.Forms.CheckBox chBoxCocinar;
        private System.Windows.Forms.CheckBox chBoxComprarComida;
        private System.Windows.Forms.CheckBox chBoxOrganizarGastos;
        private System.Windows.Forms.Label lblNivelDeAcceso;
        private System.Windows.Forms.ComboBox cmbBoxNivelAcceso;
        private System.Windows.Forms.Label lblUtensilios;
        private System.Windows.Forms.CheckBox chBoxCubiertos;
        private System.Windows.Forms.CheckBox chBoxOllas;
        private System.Windows.Forms.CheckBox chBoxSartenes;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Button btnLimpiar;
    }
}