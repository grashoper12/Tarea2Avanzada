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
    public partial class FrmSedes : Form
    {
        SedesRepository sedesrepo = new SedesRepository();
        public FrmSedes()
        {

            InitializeComponent();


        }

        private void BtnGuardarSede_Click(object sender, EventArgs e)
        {
            

            try
            {
                SedesModel sedesmodel = new SedesModel();

                sedesmodel.IdSede = int.Parse(TxtIdSede.Text);
                sedesmodel.Nombre = TxtNombreSede.Text;
                sedesmodel.Telefono = TxtNombreSede.Text;
                sedesmodel.Estado = CmbEstadoSede.SelectedItem.ToString() == "Activo" ? true : false;
                sedesmodel.Direccion = TxtDireccion.Text;

                sedesrepo.Insert(sedesmodel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }
    }
}
