using GenteFitNetriders.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textUser.Text;
            string pwd = textPassword.Text;

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var lst = from d in db.Usuarios
                          where d.email == email
                          && d.password == pwd
                          select d;
                if (lst.Count() > 0)
                {
                    this.Hide();
                    FormAdminPanel formAdminPanel = new FormAdminPanel();
                    formAdminPanel.FormClosed += (s, args) => this.Close();
                    formAdminPanel.Show();
                }
                else
                {
                    MessageBox.Show("Ususario o contraseña incorrectos");
                }
            }
        }

    }
}
