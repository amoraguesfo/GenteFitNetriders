using FontAwesome.Sharp;
using GenteFitNetriders.Controlador;
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

namespace GenteFitNetriders.Vista
{
    public partial class FormLoginPrincipal : Form
    {
        private IconButton currentButton;
        private Form formHijoActual;
        public FormLoginPrincipal()
        {
            InitializeComponent();
            ActiveButton(btnLogin, RGBColors.verde1);
          
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null) {
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

        private void FormLoginPrincipal_Load(object sender, EventArgs e)
        {
            //TODO cada vez que se clica aumenta la memoria, porque?

            AbrirFormHijo(new FormLogin());
        }

        private void AbrirFormHijo(Form formHijo)
        {

            if(formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijoActual.TopLevel = false;
            formHijoActual.Dock =DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijoActual);
            this.panelContenedor.Tag = formHijoActual;
            formHijoActual.Show();  
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormLogin());
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormRegister());
        }

    }
}
