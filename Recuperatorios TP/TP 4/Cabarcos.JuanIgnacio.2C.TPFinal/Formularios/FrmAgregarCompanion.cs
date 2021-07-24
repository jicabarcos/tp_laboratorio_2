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
using Entidades.Excepciones;

namespace Formularios
{
    public partial class FrmAgregarCompanion : Form
    {
        /// <summary>
        /// Constructor publico de la clase FrmAgregarCompanion.
        /// </summary>
        public FrmAgregarCompanion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load del formulario.
        /// </summary>
        private void FrmAgregarCompanion_Load(object sender, EventArgs e)
        {
                     
        }

        /// <summary>
        /// Click del botón btnAgregar. Dependiendo del tipo de Companion que se desee crear, toma datos y los agrega
        /// a la lista en forma de nuevo objeto Companion.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipoCompanion = this.cmbBoxTipo.Text;
            List<ETarea> tareas = new List<ETarea>();
            List<EUtensilio> utensilios = new List<EUtensilio>();

            try
            {
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
                        if (this.cmbBoxNivelAcceso.Text == "Bajo" || this.cmbBoxNivelAcceso.Text == "Medio" || this.cmbBoxNivelAcceso.Text == "Alto")
                        {
                            Manager managerToCreate = new Manager(tareas, this.cmbBoxNivelAcceso.Text);
                            NameGenerator<Manager>.CompanionName(managerToCreate);
                            Factory.AgregarCompanion(managerToCreate);
                        }
                        else
                        {
                            throw new InvalidAccessLevelException("No ha seleccionado un nivel de acceso válido. Si eligió \"Manager\", se le asignará Bajo como nivel de acceso.");
                        }
                        
                        MessageBox.Show("Nuevo Manager creado con éxito!");
                        this.Close();
                        break;

                    default:
                        throw new InvalidCompanionNameException("No ha seleccionado un tipo de Companion válido. Se le asignará un Housekeeper.");
                }                

            }
            catch(FabricaApagadaException ex)
            {
                MessageBox.Show(ex.Message, "Fábrica apagada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            catch(InvalidAccessLevelException ex)
            {
                MessageBox.Show(ex.Message, "Nivel de acceso inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbBoxNivelAcceso.Text = "Bajo";
            }
            catch (InvalidCompanionNameException ex)
            {
                MessageBox.Show(ex.Message, "Tipo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbBoxTipo.Text = "Housekeeper";
            }
        }        

        /// <summary>
        /// Restablece los valores por defecto de los controles contenidos dentro del GroupBox gBox.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.gBox.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox aux = (ComboBox)item;
                    aux.SelectedItem = "";
                }
                else if (item is CheckBox)
                {
                    CheckBox aux = (CheckBox)item;
                    aux.Checked = false;
                }
            }
        }
    }
}
