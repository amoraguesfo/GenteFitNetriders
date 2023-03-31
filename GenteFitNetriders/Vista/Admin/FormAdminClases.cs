using GenteFitNetriders.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Admin
{
    public partial class FormAdminClases : Form
    {
        private MainController controller;
        public FormAdminClases()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void FormAdminClases_Load(object sender, EventArgs e)
        {
            dataGridClases.DataSource = controller.getClases();
        }
    }
}
