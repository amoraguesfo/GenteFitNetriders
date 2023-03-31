using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using GenteFitNetriders.Vista.Admin;
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
                    //this.Parent.FindForm().Hide();
                   FormAdminPrincipal principal = new FormAdminPrincipal();
                    //formAdminPanel.FormClosed += (s, args) => this.Parent.FindForm().Close();
                    principal.Show();

                }
                else
                {
                    //this.Parent.FindForm().Hide();
                    FormAdminPrincipal principal = new FormAdminPrincipal();
                    //formClientPanel.FormClosed += (s, args) => this.Parent.FindForm().Close();
                    principal.Show();
                }

            }
            else
            {
                MessageBox.Show("Ususario o contraseña incorrectos");
            }
        }

    }
}
