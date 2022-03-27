using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Formularios
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void BtnRegSedes_Click(object sender, EventArgs e)
        {
            FrmSedes frmsedes = new FrmSedes();
            frmsedes.Show();
        }

        private void BtnRegClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmclientes = new FrmClientes();
            frmclientes.Show();
        }

        private void BtnRegSedeDeCliente_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Sede_de__Clientes frmregistrarsedecliente = new FrmRegistrar_Sede_de__Clientes();
            frmregistrarsedecliente.Show();
        }

        private void BtnConsulSedesDeCliente_Click(object sender, EventArgs e)
        {
            FrmConsultar_Sedes_de_Clientes frmconsultarsedeclientes = new FrmConsultar_Sedes_de_Clientes();
            frmconsultarsedeclientes.Show();
        }

        private void BtnConsulSedes_Click(object sender, EventArgs e)
        {
            FrmConsultar_Sedes_de_Clientes frmconsultarsedesclientes = new FrmConsultar_Sedes_de_Clientes();
            frmconsultarsedesclientes.Show();
        }

        private void BtnConsulClientes_Click(object sender, EventArgs e)
        {
            FrmConsultar_Clentes frmconsultarclientes = new FrmConsultar_Clentes();
            frmconsultarclientes.Show();
        }

        private void BtnRegCupoPorSedes_Click(object sender, EventArgs e)
        {
            FrmRegistro_Cupo_por_Sedes frmregistrocuposedes = new FrmRegistro_Cupo_por_Sedes();
            frmregistrocuposedes.Show();
        }

        private void BtnConsulCupoPorSedes_Click(object sender, EventArgs e)
        {
            FrmRegistro_Cupo_por_Sedes frmregistrocuposedes = new FrmRegistro_Cupo_por_Sedes();
            frmregistrocuposedes.Show();
        }
    }
}
