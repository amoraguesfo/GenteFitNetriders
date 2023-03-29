using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
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
                String userTipo = MainController.userLogged.tipo;
                if (userTipo == "admin")
                {
                    this.Parent.FindForm().Hide();
                    FormAdminPanel formAdminPanel = new FormAdminPanel();
                    formAdminPanel.FormClosed += (s, args) => this.Parent.FindForm().Close();
                    formAdminPanel.Show();

                }
                else
                {
                    this.Parent.FindForm().Hide();
                    FormClientPanel formClientPanel = new FormClientPanel();
                    formClientPanel.FormClosed += (s, args) => this.Parent.FindForm().Close();
                    formClientPanel.Show();
                }

            }
            else
            {
                MessageBox.Show("Ususario o contraseña incorrectos");
            }
        }

    }
}
