using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista.utils;
using System;
using System.Text;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Admin
{
    public partial class FormAminAddClase : Form
    {
        MainController controller;
        public FormAminAddClase()
        {
            InitializeComponent();
            controller = new MainController();

            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.CustomFormat = "HH:mm";
            dateTimePickerHora.Format = DateTimePickerFormat.Custom;
        }

        private void btnAddClase_Click(object sender, EventArgs e)
        {
            
            //Limpiado de inputs
            string clase = textClase.Text.Trim();
            string profesor = textProfesor.Text.Trim();
            string plazas = textPazas.Text.Trim();
            string duracion = textDuracion.Text.Trim();

            StringBuilder err = new StringBuilder();
            bool isValid = true;

            // Validar la clase

            if (!UtilsValidateInputs.IsValidName(clase))
            {
                err.AppendLine("El campo de clase es obligatorio.");
                isValid = false;
            }
            //Validar el profesor
            if (!UtilsValidateInputs.IsValidName(profesor))
            {
                err.AppendLine("El campo profesor es obligatorio.");
                isValid = false;
            }
            // Validar plazas
            int plazasVal = 0;
            if (!int.TryParse(plazas, out plazasVal))
            {
                err.AppendLine("El numero de plazas debe ser un número entero.");
                isValid = false;

            }
            if (plazasVal < 0)
            {
                err.AppendLine("El numero de plazas no puede ser negativo");
                isValid = false;
            }

            // Validar la duracion
            int duracionVal = 0;
            if (!int.TryParse(duracion, out duracionVal))
            {
                err.AppendLine("La duracion debe ser en minutos");
                isValid = false;
            }
            if (duracionVal < 0)
            {
                err.AppendLine("La duración no puede ser negativa");
                isValid = false;
            }

            // Si todos los campos son válidos, agregar la clase
            if (isValid)
            {
                //controller.addClase(textClase.Text, textProfesor.Text, int.Parse(textPazas.Text), monthCalendarFecha.BoldedDates[0], new TimeSpan(dateTimePickerHora.Value.Hour, dateTimePickerHora.Value.Minute, dateTimePickerHora.Value.Second), int.Parse(textDuracion.Text));
                if (controller.addClase(
                    clase,
                    profesor,
                    plazasVal,
                    new DateTime(dateTimePickerFecha.Value.Ticks),
                    new TimeSpan(dateTimePickerHora.Value.Hour,dateTimePickerHora.Value.Minute, 0),
                    duracionVal))
                {
                    MessageBox.Show("La clase se ha añadido correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede crear la clase");
                }      
            }
            else
            {
                MessageBox.Show(err.ToString(), "Error de validación");
            }
        }

    }
}
