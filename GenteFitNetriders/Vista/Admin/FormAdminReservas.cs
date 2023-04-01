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
    public partial class FormAdminReservas : Form
    {
        MainController controller;
        public FormAdminReservas()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void FormAdminReservas_Load(object sender, EventArgs e)
        {
            dataGridViewReservas.DataSource = controller.getReservas();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Modelo.ReservaViewModel reserva = (Modelo.ReservaViewModel)dataGridViewReservas.CurrentRow.DataBoundItem;
            controller.deleteClase(reserva.id);
            MessageBox.Show("La reservas se ha eliminado correctamente");
            dataGridViewReservas.DataSource = controller.getReservas();
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            controller.exportarReservasXML();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            controller.importarReservasXML();
            dataGridViewReservas.DataSource = controller.getReservas();
        }
    }
}
