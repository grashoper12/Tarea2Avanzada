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
    public partial class FrmSedes : Form
    {
        SedesRepository sedesrepo = new SedesRepository();

        Regex regex = new Regex("^[0-9]{1,}$");
        Regex regexTelefono = new Regex("^[2678]{1}[0-9]{3}-[0-9]{4}$");

        public FrmSedes()
        {
            InitializeComponent();
            this.CmbEstadoSede.SelectedIndex = 0;
        }

        private void BtnGuardarSede_Click(object sender, EventArgs e)
        {


            try
            {
                if (validarCampos())
                {
                    SedesModel sedesmodel = new SedesModel();

                    sedesmodel.IdSede = int.Parse(TxtIdSede.Text);
                    sedesmodel.Nombre = TxtNombreSede.Text;
                    sedesmodel.Telefono = this.TxtNumTelefono.Text;
                    sedesmodel.Estado = CmbEstadoSede.SelectedItem.ToString() == "Activo" ? true : false;
                    sedesmodel.Direccion = TxtDireccion.Text;

                    string msj = sedesrepo.Insert(sedesmodel);

                    this.displayData();

                    MessageBox.Show(msj);
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
                if (this.TxtIdSede.Text.Equals("") || this.TxtDireccion.Equals("") || this.TxtNombreSede.Text.Equals("")
                    || this.TxtNumTelefono.Text.Equals("") || this.CmbEstadoSede.SelectedItem.ToString().Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos son requeridos..!!!");
                    valida = false;
                }
                else if (!regex.IsMatch(this.TxtIdSede.Text))
                {
                    MessageBox.Show("El Id de sede debe ser un número..!!!");
                    valida = false;
                }
                else if (!this.regexTelefono.IsMatch(this.TxtNumTelefono.Text))
                {
                    MessageBox.Show("Ingrese un teléfono válido Ejm 7845-9632 ..!!!");
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

        private void displayData()
        {
            try
            {
                SedesModel[] sedes = sedesrepo.GetAll();

                this.dgvSedes.Rows.Clear();

                for (int i = 0; i < SedesRepository.Cantidad; i++)
                {
                    this.dgvSedes.Rows.Add(sedes[i].IdSede, sedes[i].Nombre, sedes[i].Direccion, sedes[i].Estado, sedes[i].Telefono);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
