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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
