using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Client
{
    public partial class FormClientEditProfile : Form
    {   
        MainController controller;
        private FormClientPanel fparent;
        public FormClientEditProfile(FormClientPanel fp)
        {
            InitializeComponent();
            fparent = fp;
            controller = new MainController();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Limpiado de inputs
            string nombre = textNombre.Text.Trim();
            string email = textEmail.Text.Trim();
            string telefono = textTelefono.Text.Trim();
            string edad = textEdad.Text.Trim();
            string sexo = rbMasculino.Checked ? "m" : "f";
            string pwd1 = textPassword.Text;
            string pwd2 = textConfirmPassword.Text;

            StringBuilder err = new StringBuilder();
            bool isValid = true;

            // Validar el nombre

            if (!UtilsValidateInputs.IsValidName(nombre))
            {
                err.AppendLine("El campo de nombre es obligatorio.");
                isValid = false;
            }
            // Validar la edad
            int edadVal;
            if (!int.TryParse(edad, out edadVal))
            {
                err.AppendLine("La edad debe ser un número entero.");
                isValid = false;
            }
            // Validar el correo electrónico
            if (!UtilsValidateInputs.IsValidEmail(email))
            {
                err.AppendLine("El correo electrónico no es válido.");
                isValid = false;
            }
            // Validar el telefono
            if (!UtilsValidateInputs.IsValidTelf(telefono))
            {
                err.AppendLine("El telefono no es válido.");
                isValid = false;
            }
            //Validar contraseñas
            if (!UtilsValidateInputs.IsValidPassword(pwd1))
            {
                err.AppendLine("La contraseña es demasiado corta");
                isValid = false;
            }
            //Comparar contraseñas
            if (!UtilsValidateInputs.PasswordsMatch(pwd1, pwd2))
            {
                err.AppendLine("Las contraseñas no coinciden");
                isValid = false;
            }
            // Si todos los campos son válidos, agregar el usuario
            if (isValid)
            {
                if (controller.editUser(Common.userLogged.id, nombre, email, sexo, edadVal, telefono, pwd1))
               {
                    //TODO Buscar mejor solucion que pasar el padre btnActualizar iniciar session para cobiar el label del menu 
                    fparent.labelNombre.Text = Common.userLogged.nombre;
                    MessageBox.Show("Los datos se han actualizado correctamente");

                }
                else
                {
                    MessageBox.Show("El email ya esta registrado");
                }
            }
            else
            {
                MessageBox.Show(err.ToString(), "Error de validación");
            }


        }
        private void FormClientEditProfile_Load(object sender, EventArgs e)
        {
            textNombre.Text = Common.userLogged.nombre;
            textEmail.Text = Common.userLogged.email;
            textEdad.Text = Common.userLogged.edad.ToString();
            if(Common.userLogged.sexo == "m")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFemenino.Checked = true;
            }         
            textTelefono.Text = Common.userLogged.num_telefono;
            textPassword.Text = Common.userLogged.password;
            textConfirmPassword.Text = Common.userLogged.password;

        }

    }
            

}
