using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using System;
using System.Windows.Forms;

namespace GenteFitNetriders
{
    public partial class FormRegister : Form
    {
        private readonly MainController controller = null;
        public FormRegister()
        {
            InitializeComponent();
            controller = new MainController();   
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string email = textUser.Text;
            string pwd = textPassword.Text;

            this.Hide();
            FormClientPanel formClientPanel = new FormClientPanel();
            formClientPanel.FormClosed += (s, args) => this.Close();
            formClientPanel.SetController(controller);
            formClientPanel.Show();
        }



    }
}
