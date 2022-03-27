using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2.Repository;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        ClientesRepository clientesRepository = null;
        public Form1()
        {
            InitializeComponent();

            clientesRepository = ClientesRepository.GetInstance();
            var data = clientesRepository.GetAll();

        }
    }
}
