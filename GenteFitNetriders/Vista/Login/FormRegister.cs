using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista;
using GenteFitNetriders.Vista.utils;
using System;
using System.Text;
using System.Text.RegularExpressions;
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
            //Limpiado de inputs
            string nombre = textNombre.Text.Trim();
            string email = textEmail.Text.Trim();
            string telefono = textTelefono.Text.Trim();
            string edad = textEdad.Text.Trim();
            string sexo = rbMasculino.Checked ? "m" : "f";
            string pwd1 = textPassword.Text;
            string pwd2 = textConfirmPassword.Text;

            //Validación de datos (NOTA: mejor opción usar DataAnnotations en el modelo y enfocar la app como MVP,
            //moviendo la lógica de validación a la capa presentador?
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
            if (!UtilsValidateInputs.PasswordsMatch(pwd1,pwd2))
            {
                err.AppendLine("Las contraseñas no coinciden");
                isValid = false;
            }
            // Si todos los campos son válidos, agregar el usuario
            if (isValid)
            {
                if (controller.addUser(textNombre.Text,
                                         textEmail.Text,
                                         sexo,
                                         int.Parse(textEdad.Text),
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
            else
            {
                MessageBox.Show(err.ToString(), "Error de validación");
            }

 
        }

    }
}
