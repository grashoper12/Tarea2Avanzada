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
    public partial class FrmConsultar_Clentes : Form
    {
        ClientesRepository repo = null;

        public FrmConsultar_Clentes()
        {
            InitializeComponent();
            this.repo = ClientesRepository.GetInstance();
            this.Fill();
        }

        private void BtnConsultaClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesModel cli2 = (ClientesModel)this.CmbConsultaClientes.SelectedItem;
                if (this.CmbConsultaClientes.Items.Count == 0) return;

                ClientesModel cli = repo.GetById(cli2.Identificacion);

                this.DtgConsultarClientes.Rows.Clear();

                if (cli != null)
                {
                    this.DtgConsultarClientes.Rows.Add(cli.Nombre, cli.PrimerApellido, cli.SegundoApellido, cli.Identificacion, cli.Genero, cli.FechaNacimiento, cli.FechaIngreso);
                }
                else
                {
                    MessageBox.Show("No se encontro el cliente...!!!!");
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
                ClientesModel[] list = repo.GetAll();

                if (list != null)
                {
                    this.CmbConsultaClientes.DisplayMember = "Nombre";
                    this.CmbConsultaClientes.DisplayMember = "Identificacion";
                    this.CmbConsultaClientes.DataSource = list;
                }



            }
            catch { }
        }
    }
}
