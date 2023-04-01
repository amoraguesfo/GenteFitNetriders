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

namespace GenteFitNetriders.Vista.Client
{
    public partial class FormClientReservas : Form
    {
        MainController controller;
        public FormClientReservas()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void FormClientReservas_Load(object sender, EventArgs e)
        {
            dataGridViewReservas.DataSource = controller.getReservasByUser(Common.userLogged.id);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Modelo.ReservaViewModel reserva = (Modelo.ReservaViewModel)dataGridViewReservas.CurrentRow.DataBoundItem;
            //TODO marcar la reserva como anulada, solo el admin puede borrar datos de la BBDD
            controller.deleteReserva(reserva.id);
            MessageBox.Show("La reserva se ha realizado correctamente");
            dataGridViewReservas.DataSource = controller.getReservasByUser(Common.userLogged.id);
        }
    }
}
