using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using GenteFitNetriders.Vista.Admin;
using GenteFitNetriders.Vista.utils;
using System;
using System.Windows.Forms;

namespace GenteFitNetriders
{
    public partial class FormLogin : Form
    {
        private MainController controller = null;

        public FormLogin()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string email = textUser.Text;
            string pwd = textPassword.Text;
            
            //- Llamar al form correspondiente segun admin o cliente
            if (controller.UserLogin(email, pwd))
            
            {
                String userTipo = Common.userLogged.tipo;
                if (userTipo == "admin")
                {
                   this.Parent.FindForm().Hide();
                   FormAdminPrincipal principal = new FormAdminPrincipal();
                   principal.FormClosed += (s, args) => this.Parent.FindForm().Show();
                   principal.Show();

                }
                else
                {
                    this.Parent.FindForm().Hide();
                    FormClientPanel clientPanel = new FormClientPanel();
                    clientPanel.FormClosed += (s, args) => this.Parent.FindForm().Show();
                    clientPanel.Show();
                }

            }
            else
            {
                MessageBox.Show("Ususario o contraseña incorrectos");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "email@example.com") {
                textUser.Text = "";
                textUser.ForeColor = RGBColors.negro;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Contraseña")
            {
                textPassword.Text = "";
                textPassword.ForeColor = RGBColors.negro;
                textPassword.UseSystemPasswordChar = true;
            }
        }



    }
}
