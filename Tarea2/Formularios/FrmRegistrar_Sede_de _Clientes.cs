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


    public partial class FrmRegistrar_Sede_de__Clientes : Form
    {
        AfiliacionSedeRepository afiliacionSedeRepository = new AfiliacionSedeRepository();
        SedesRepository sedesRepository = new SedesRepository();
        ClientesRepository clientesRepository = null;

        Regex regex = new Regex("^[1-9]{1,}$");
        ClientesModel clientesModel;
        int cantidad = 0;
        SedesModel[] sedes;
        bool guardado = false;

        public FrmRegistrar_Sede_de__Clientes()
        {
            InitializeComponent();
            clientesRepository = ClientesRepository.GetInstance();
            fill();
        }

        private void BtnGuardarRegSedeDeCliente_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (this.cmSedes.SelectedItem != null && this.CmbSeleccionDeCliente.SelectedItem != null && this.regex.IsMatch(this.TxtIdAfiliacion.Text))
                {

                    clientesModel = (ClientesModel)this.CmbSeleccionDeCliente.SelectedItem;
                    SedesModel sedesModel = (SedesModel)this.cmSedes.SelectedItem;


                    if (cantidad < 10)
                    {
                        if (Existe(sedesModel.IdSede))
                        {
                            MessageBox.Show($"Ya la sede {sedesModel.Nombre} ha sido agregada al cliente {clientesModel.Nombre}");
                            return;
                        }

                        this.dataGridView1.Rows.Add(sedesModel.IdSede, sedesModel.Nombre, sedesModel.Estado, sedesModel.Telefono, sedesModel.Direccion);
                        cantidad++;
                    }
                    else
                    {
                        MessageBox.Show($"Ya no puede afiliar mas sedes al cliente: {clientesModel.Nombre}, Cedula: {nuevo}..!!");
                    }

                }
                else
                {
                    MessageBox.Show("Todos los campos son requeridos..!!!\nEl Id Afiliacion debe ser un numero y mayor a 0..!!");
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
                ClientesModel[] cleintes = clientesRepository.GetAll();

                if (sedes != null)
                {
                    this.cmSedes.DisplayMember = "Nombre";
                    this.cmSedes.DataSource = sedes;
                }

                if (cleintes != null)
                {
                    this.CmbSeleccionDeCliente.DisplayMember = "Nombre";
                    this.CmbSeleccionDeCliente.DataSource = cleintes;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GUADRA CAMBIOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (guardado == false)
            {
                sedes = new SedesModel[10];

                try
                {
                    int rows = this.dataGridView1.Rows.Count - 1;
                    for (int i = 0; i < rows; i++)
                    {
                        SedesModel sedesModel = new SedesModel();

                        sedesModel.IdSede = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                        sedesModel.Nombre = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                        sedesModel.Estado = this.dataGridView1.Rows[i].Cells[2].Value.ToString() == "True";
                        sedesModel.Telefono = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                        sedesModel.Direccion = this.dataGridView1.Rows[i].Cells[4].Value.ToString();

                        sedes[i] = sedesModel;
                    }

                    AfiliciacionSedeModel afiliciacionSedeModel = new AfiliciacionSedeModel();
                    afiliciacionSedeModel.sedesModel = sedes;
                    afiliciacionSedeModel.clientesModel = clientesModel;
                    afiliciacionSedeModel.IdAfiliacion = int.Parse(this.TxtIdAfiliacion.Text);

                    string msj = afiliacionSedeRepository.Insert(afiliciacionSedeModel);
                    guardado = true;
                    this.dataGridView1.Rows.Clear();
                    cantidad = 0;

                    MessageBox.Show(msj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool Existe(int idsede)
        {
            try
            {
                int rows = this.dataGridView1.Rows.Count - 1;
                for (int i = 0; i < rows; i++)
                {

                    int column = this.dataGridView1.Rows[i].Cells.Count - 1;

                    for (int j = 0; j < column; j++)
                    {

                        if (int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString()) == idsede)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CmbSeleccionDeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
