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
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            dataGridViewReservas.DataSource = controller.getReservasByUser(Common.userLogged.id);
            dataGridViewReservas.Columns["id"].Visible = false;
            dataGridViewReservas.Columns["id_usuario"].Visible = false;
            dataGridViewReservas.Columns["id_clase"].Visible = false;
            dataGridViewReservas.Columns["nombre_usuario"].Visible = false;
            dataGridViewReservas.Columns["email_usuario"].Visible = false;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Modelo.ReservaViewModel reserva = (Modelo.ReservaViewModel)dataGridViewReservas.CurrentRow.DataBoundItem;
            //TODO marcar la reserva como anulada, solo el admin puede borrar datos de la BBDD
            controller.deleteReserva(reserva.id);
            MessageBox.Show("La reserva se ha anulado correctamente");
            fillDataGrid();
        }
    }
}
