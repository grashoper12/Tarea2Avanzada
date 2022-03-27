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
    public partial class FrmClientes : Form
    {

        ClientesRepository clientesRepository = null;



        public FrmClientes()
        {
            InitializeComponent();
            clientesRepository = ClientesRepository.GetInstance();

        }

        private void BtnGuard_Click(object sender, EventArgs e)
        {

            try
            {

                ClientesModel clientesModel = new ClientesModel();
                clientesModel.Identificacion = TxtIdentificacion.Text;
                clientesModel.Genero = this.CmbGen.SelectedItem.ToString() == "Masculino" ? 'M' : 'F';
                clientesModel.FechaNacimiento = this.dtpFecNac.Value;
                clientesModel.FechaIngreso = this.dtpFecIng.Value;
                clientesModel.Nombre = TxtNomb.Text;
                clientesModel.PrimerApellido = TxtPape.Text;
                clientesModel.SegundoApellido = TxtSape.Text;
                clientesRepository.Insert(clientesModel);
                DisplayDataClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void DisplayDataClient ()
        {
            this.dataGridView1.Rows.Clear();
            try
            {
                var data = clientesRepository.GetAll();
                foreach (var item in data)
                {
                    if(item != null)
                    this.dataGridView1.Rows.Add(item.Identificacion, item.Nombre,item.PrimerApellido,item.SegundoApellido, item.Genero,item.FechaNacimiento,item.FechaIngreso);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }

}
