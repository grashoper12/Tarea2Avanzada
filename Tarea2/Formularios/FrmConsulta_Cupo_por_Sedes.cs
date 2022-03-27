using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2.Entidades;
using Tarea2.Repository;

namespace Tarea2.Formularios
{
    public partial class FrmConsulta_Cupo_por_Sedes : Form
    {
        CuposSedesRepository cuposSedesRepository = new CuposSedesRepository();
        SedesRepository sedesRepository = new SedesRepository();

        public FrmConsulta_Cupo_por_Sedes()
        {
            InitializeComponent();
            this.fill();
        }

        private void BtnConsultaCupoPorSedes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbSedesConsultaCupoSedes.SelectedItem != null)
                {
                    SedesModel sedesModel = (SedesModel)this.CmbSedesConsultaCupoSedes.SelectedItem;

                    CuposSedeModel cuposSedeModel = this.cuposSedesRepository.GetCuposBySede(sedesModel);

                    if (cuposSedeModel != null)
                    {
                        this.DtgConsultaCupoPorSedes.Rows.Clear();

                        this.DtgConsultaCupoPorSedes.Rows.Add(cuposSedeModel.sedesModel.Nombre, cuposSedeModel.sedesModel.Direccion, cuposSedeModel.sedesModel.Telefono, cuposSedeModel.Cupos, cuposSedeModel.Fecha);
                    }
                    else MessageBox.Show("No se han registrado cupos para la sede seleccionada..!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void fill()
        {
            try
            {
                SedesModel[] sedes = sedesRepository.GetAll();

                for (int i = 0; i < SedesRepository.Cantidad; i++)
                {
                    this.CmbSedesConsultaCupoSedes.DisplayMember = "Nombre";
                    this.CmbSedesConsultaCupoSedes.DataSource = sedes;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
