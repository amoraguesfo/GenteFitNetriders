using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using GenteFitNetriders.Vista.utils;
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
            String sexo = rbMasculino.Checked ? "m" : "f";
            
            if (controller.addUser(textNombre.Text,
                                    textEmail.Text,
                                    sexo,
                                    int.Parse(textEdad.Text),//TODO tratar error parseo
                                    textTelefono.Text,
                                    textPassword.Text))
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

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "Nombre")
            {
                textNombre.Text = "";
                textNombre.ForeColor = RGBColors.negro;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Nombre";
                textNombre.ForeColor = RGBColors.gris;
            }
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Text == "Teléfono")
            {
                textTelefono.Text = "";
                textTelefono.ForeColor = RGBColors.negro;
            }
        }

        private void textTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Text == "")
            {
                textTelefono.Text = "Teléfono";
                textTelefono.ForeColor = RGBColors.gris;
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Text = "";
                textEmail.ForeColor = RGBColors.negro;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email";
                textEmail.ForeColor = RGBColors.gris;
            }
        }

        private void textEdad_Enter(object sender, EventArgs e)
        {
            if (textEdad.Text == "Edad")
            {
                textEdad.Text = "";
                textEdad.ForeColor = RGBColors.negro;
            }
        }

        private void textEdad_Leave(object sender, EventArgs e)
        {
            if (textEdad.Text == "")
            {
                textEdad.Text = "Edad";
                textEdad.ForeColor = RGBColors.gris;
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

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Contraseña";
                textPassword.ForeColor = RGBColors.gris;
                textPassword.UseSystemPasswordChar = false;
            }
        }

        private void textConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text == "Confirma contraseña")
            {
                textConfirmPassword.Text = "";
                textConfirmPassword.ForeColor = RGBColors.negro;
                textConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void textConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text == "")
            {
                textConfirmPassword.Text = "Confirma contraseña";
                textConfirmPassword.ForeColor = RGBColors.gris;
                textConfirmPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
