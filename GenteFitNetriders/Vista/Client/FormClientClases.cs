using GenteFitNetriders.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Client
{
    public partial class FormClientClases : Form
    {
        MainController controller;
        public FormClientClases()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void FormClientClases_Load(object sender, EventArgs e)
        {
            dataGridViewClases.DataSource = controller.getClases();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
         
            Modelo.ClaseViewModel clase = (Modelo.ClaseViewModel)dataGridViewClases.CurrentRow.DataBoundItem;
            var resrvasUser = controller.getReservasByUser(Common.userLogged.id);
            foreach (var res in resrvasUser)
            {
                if (res.id_clase == clase.id) {
                    MessageBox.Show("Ya tinenes reserva para esta clase");
                    return;
                }    
            }
            //TODO mirar si esto se puede mejorar usando find o contains del EF:
            //si ya se tiene reserva no se puede reservar
                string estado = controller.getReservasByClass(clase.id).Count() < clase.plazas ? "reservada" : "espera";
                controller.addReserva(Common.userLogged.id, clase.id, estado);
                MessageBox.Show("La reserva se ha realizado correctamente");
                    
        }


    }
}
