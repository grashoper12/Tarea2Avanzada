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
    public partial class FrmRegistro_Cupo_por_Sedes : Form
    {
        CuposSedesRepository cuposSedesRepository = new CuposSedesRepository();
        SedesRepository sedesRepository = new SedesRepository();
        Regex regex = new Regex("^([1-9]{1})([0-9]{1,})?$");

        public FrmRegistro_Cupo_por_Sedes()
        {
            InitializeComponent();
            this.fill();
        }

        private void BtnGuardarRegCupoPorSedes_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaCampos())
                {
                    CuposSedeModel cupos = new CuposSedeModel();
                    cupos.sedesModel = (SedesModel)this.CmbSedeRegCupoSedes.SelectedItem;
                    cupos.Cupos = int.Parse(this.TxtCuposDisponibles.Text);
                    cupos.Fecha = this.dtpFecha.Value;

                    string msj = cuposSedesRepository.Insert(cupos);

                    MessageBox.Show(msj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validaCampos()
        {
            bool valida = true;
            try
            {
                if (this.CmbSedeRegCupoSedes.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione la Sede");
                    valida = false;
                }else if (!regex.IsMatch(this.TxtCuposDisponibles.Text))
                {
                    MessageBox.Show("El campo cupo debe ser un número y mayor a 0..!!");
                    valida = false;
                }
                return valida;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fill()
        {
            try
            {
                SedesModel[] sedes = sedesRepository.GetAll();

                for (int i = 0; i < SedesRepository.Cantidad; i++)
                {
                    this.CmbSedeRegCupoSedes.DisplayMember = "Nombre";
                    this.CmbSedeRegCupoSedes.DataSource = sedes;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
