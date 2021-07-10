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
    public partial class FrmAgregarCompanion : Form
    {
        public FrmAgregarCompanion()
        {
            InitializeComponent();
        }

        private void FrmAgregarCompanion_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click del botón btnAgregar. Dependiendo del tipo de Companion que se desee crear, toma datos y los agrega
        /// a la lista en forma de nuevo objeto Companion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipoCompanion = this.cmbBoxTipo.Text;
            List<ETarea> tareas = new List<ETarea>();
            List<EUtensilio> utensilios = new List<EUtensilio>();

            switch (this.cmbBoxTipo.Text)
            {
                case "Cook":                    
                    if(this.chBoxCocinar.Checked == true)
                    {
                        tareas.Add(ETarea.Cocinar);
                    }
                    if (this.chBoxComprarComida.Checked == true)
                    {
                        tareas.Add(ETarea.ComprarComida);
                    }
                    if (this.chBoxCubiertos.Checked == true)
                    {
                        utensilios.Add(EUtensilio.Cubiertos);
                    }
                    if (this.chBoxOllas.Checked == true)
                    {
                        utensilios.Add(EUtensilio.Ollas);
                    }
                    if (this.chBoxSartenes.Checked == true)
                    {
                        utensilios.Add(EUtensilio.Sartenes);
                    }
                    Cook cookToCreate = new Cook(tareas, utensilios);
                    NameGenerator<Cook>.CompanionName(cookToCreate);
                    Factory.AgregarCompanion(cookToCreate);
                    MessageBox.Show("Nuevo Cook creado con éxito!");
                    this.Close();
                    break;
                
                case "Housekeeper":
                    if (this.chBoxLimpiar.Checked == true)
                    {
                        tareas.Add(ETarea.Limpiar);
                    }
                    if (this.chBoxOrdenar.Checked == true)
                    {
                        tareas.Add(ETarea.Ordenar);
                    }
                    if (this.chBoxBarrer.Checked == true)
                    {
                        tareas.Add(ETarea.Barrer);
                    }
                    Housekeeper housekeeperToCreate = new Housekeeper(tareas);
                    NameGenerator<Housekeeper>.CompanionName(housekeeperToCreate);
                    Factory.AgregarCompanion(housekeeperToCreate);
                    MessageBox.Show("Nuevo Housekeeper creado con éxito!");
                    this.Close();
                    break;

                case "Manager":
                    if (this.chBoxComprarComida.Checked == true)
                    {
                        tareas.Add(ETarea.ComprarComida);
                    }
                    if (this.chBoxOrganizarGastos.Checked == true)
                    {
                        tareas.Add(ETarea.OrganizarGastos);
                    }
                    Manager managerToCreate = new Manager(tareas, this.cmbBoxNivelAcceso.Text);
                    NameGenerator<Manager>.CompanionName(managerToCreate);
                    Factory.AgregarCompanion(managerToCreate);
                    MessageBox.Show("Nuevo Manager creado con éxito!");
                    this.Close();
                    break;

                default:
                    MessageBox.Show("No ha seleccionado un tipo de Companion válido.");
                    break;

            }
        }
    }
}
