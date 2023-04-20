using FontAwesome.Sharp;
using GenteFitNetriders.Vista.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GenteFitNetriders.Vista.Admin
{
    public partial class FormAdminPrincipal : Form
    {
        private IconButton currentButton;
        private Form formHijoActual;
        public FormAdminPrincipal()
        {
            InitializeComponent();
        }

        private void FormAdminPrincipal_Load(object sender, EventArgs e)
        {
            //TODO cada vez que se clica aumenta la memoria, porque?
            ActiveButton(btnUsuarios, RGBColors.verde1);
            AbrirFormHijo(new FormAdminUsers());
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Estilo del botton
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                //Estilo del botton
                currentButton.BackColor = RGBColors.negro;
            }
        }
        private void AbrirFormHijo(Form formHijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijoActual.TopLevel = false;
            formHijoActual.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijoActual);
            this.panelContenedor.Tag = formHijoActual;
            formHijoActual.Show();
        }



        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormAdminUsers());
        }

        private void btnClases_Click(object sender, EventArgs e)
        {

            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormAdminClases());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormAdminReservas());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
