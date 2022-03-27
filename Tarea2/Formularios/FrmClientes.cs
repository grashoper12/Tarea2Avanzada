using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2.Entidades;
using Tarea2.Repository;

namespace Tarea2.Formularios
{
    public partial class FrmClientes : Form
    {

        ClientesRepository clientesRepository = null;
        Regex regex = new Regex("^[0-9]{9}$");



        public FrmClientes()
        {
            InitializeComponent();
            clientesRepository = ClientesRepository.GetInstance();
            this.CmbGen.SelectedIndex = 0;
        }

        private void BtnGuard_Click(object sender, EventArgs e)
        {

            try
            {
                if (validarCampos())
                {
                    ClientesModel clientesModel = new ClientesModel();
                    clientesModel.Identificacion = TxtIdentificacion.Text;
                    clientesModel.Genero = this.CmbGen.SelectedItem.ToString() == "Masculino" ? 'M' : 'F';
                    clientesModel.FechaNacimiento = this.dtpFecNac.Value;
                    clientesModel.FechaIngreso = this.dtpFecIng.Value;
                    clientesModel.Nombre = TxtNomb.Text;
                    clientesModel.PrimerApellido = TxtPape.Text;
                    clientesModel.SegundoApellido = TxtSape.Text;
                    string msj = clientesRepository.Insert(clientesModel);
                    DisplayDataClient();
                    MessageBox.Show(msj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void DisplayDataClient()
        {
            this.dataGridView1.Rows.Clear();
            try
            {
                var data = clientesRepository.GetAll();
                foreach (var item in data)
                {
                    if (item != null)
                        this.dataGridView1.Rows.Add(item.Identificacion, item.Nombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.FechaNacimiento, item.FechaIngreso);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private bool validarCampos()
        {
            bool valida = true;
            try
            {
                if (this.TxtNomb.Text.Equals("") || this.TxtPape.Text.Equals("") || this.TxtSape.Text.Equals("")
                    || this.TxtIdentificacion.Text.Equals("") || this.CmbGen.SelectedItem.ToString().Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos son requeridos..!!");
                    valida = false;
                }
                else if (!regex.IsMatch(this.TxtIdentificacion.Text))
                {
                    MessageBox.Show("Ingrese una cedúla válida Ejm: 126590365 ..!!");
                    valida = false;
                }
                return valida;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }

}
