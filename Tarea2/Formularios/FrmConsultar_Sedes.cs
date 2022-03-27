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
    public partial class FrmConsultar_Sedes : Form
    {
        SedesRepository sedesrepo = new SedesRepository();
        public FrmConsultar_Sedes()
        {
            InitializeComponent();
            this.Fill();
        }

        private void BtnConsultarSedes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbConsultarSedes.SelectedValue != null)
                {
                    int IdSede = int.Parse(this.CmbConsultarSedes.SelectedValue.ToString());


                    SedesModel sedes = sedesrepo.GetById(IdSede);

                    this.DtgConsultarSedes.Rows.Clear();
                    this.DtgConsultarSedes.Rows.Add(sedes.IdSede, sedes.Nombre, sedes.Direccion, sedes.Estado, sedes.Telefono);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fill()
        {
            try
            {
                SedesViewModel[] sedes = sedesrepo.GetAllView();

                if (sedes != null)
                {
                    this.CmbConsultarSedes.DisplayMember = "Nombre";
                    this.CmbConsultarSedes.ValueMember = "IdSede";
                    this.CmbConsultarSedes.DataSource = sedes;
                }


            }
            catch { }
        }
    }
}
