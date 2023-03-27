using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using System;
using System.Windows.Forms;

namespace GenteFitNetriders
{
    public partial class FormLogin : Form
    {
        private readonly MainController controller = null;
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
                String userTipo = controller.GetUserLogged().tipo;
                if (userTipo == "admin")
                {
                    this.Hide();
                    FormAdminPanel formAdminPanel = new FormAdminPanel();
                    formAdminPanel.FormClosed += (s, args) => this.Close();
                    formAdminPanel.SetController(controller);
                    formAdminPanel.Show();

                }
                else
                {
                    this.Hide();
                    FormClientPanel formClientPanel = new FormClientPanel();
                    formClientPanel.FormClosed += (s, args) => this.Close();
                    formClientPanel.SetController(controller);
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
