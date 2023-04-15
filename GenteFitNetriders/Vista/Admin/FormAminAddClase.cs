using GenteFitNetriders.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //controller.addClase(textClase.Text, textProfesor.Text, int.Parse(textPazas.Text), monthCalendarFecha.BoldedDates[0], new TimeSpan(dateTimePickerHora.Value.Hour, dateTimePickerHora.Value.Minute, dateTimePickerHora.Value.Second), int.Parse(textDuracion.Text));
            controller.addClase(textClase.Text, textProfesor.Text, int.Parse(textPazas.Text), new DateTime(dateTimePickerFecha.Value.Ticks), new TimeSpan(dateTimePickerHora.Value.Hour, dateTimePickerHora.Value.Minute, 0), int.Parse(textDuracion.Text));
            MessageBox.Show("LA clase se ha añadido correctamente");
            this.Close();
        }


    }
}
