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
    public partial class FrmConsultar_Sedes_de_Clientes : Form
    {
        ClientesRepository clientesRepository = null;
        AfiliacionSedeRepository afiliacion = new AfiliacionSedeRepository();
        public FrmConsultar_Sedes_de_Clientes()
        {
            InitializeComponent();
            this.clientesRepository = ClientesRepository.GetInstance();
            this.fill();
        }

        private void BtnConsultarSedClientes_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem != null)
            {
                ClientesModel cli = (ClientesModel)this.comboBox1.SelectedItem;

                SedesModel[] sedes = this.afiliacion.GetAfiliacionByCliente(cli);

                this.DtgConsulSedClientes.Rows.Clear();
                if (sedes == null) return;
                for (int i = 0; i < sedes.Length; i++)
                {
                    if (sedes[i] != null)
                    {
                        this.DtgConsulSedClientes.Rows.Add(sedes[i].IdSede, sedes[i].Nombre, sedes[i].Telefono, sedes[i].Direccion);
                    }
                }

            }
        }

        private void fill()
        {
            try
            {
                ClientesModel[] clientes = this.clientesRepository.GetAll();

                if (clientes != null)
                {
                    this.comboBox1.DisplayMember = "Nombre";
                    this.comboBox1.DataSource = clientes;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
