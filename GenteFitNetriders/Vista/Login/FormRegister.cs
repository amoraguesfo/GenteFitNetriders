using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using System;
using System.Windows.Forms;

namespace GenteFitNetriders
{
    public partial class FormRegister : Form
    {
        private MainController controller;
        public FormRegister()
        {
            InitializeComponent();
            controller = new MainController();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (controller.addUser(textNombre.Text, textEmail.Text, textSexo.Text, int.Parse(textEdad.Text), textTelefono.Text, textPassword.Text))
            {

               // this.Parent.FindForm().Hide();
                FormClientPanel formClientPanel = new FormClientPanel();
               // formClientPanel.FormClosed += (s, args) => this.Parent.FindForm().Close();
                formClientPanel.Show();
            }
            else
            {
                MessageBox.Show("Error al crear el usuario");
            }
        }
    }
}
