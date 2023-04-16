using FontAwesome.Sharp;
using GenteFitNetriders.Controlador;
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
    
        public FormLoginPrincipal()
        {
            InitializeComponent();
            ActiveButton(btnLogin, RGBColors.color1);
          
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(154, 205, 50);
            public static Color color2 = Color.FromArgb(0, 0, 0);
            public static Color color3 = Color.FromArgb(255,0 , 0);
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
                currentButton.BackColor = RGBColors.color2;
            }
        }

        private void FormLoginPrincipal_Load(object sender, EventArgs e)
        {
            //TODO cada vez que se clica aumenta la memoria, porque?

            abrirFormInPanel(new FormLogin());
        }

        private void abrirFormInPanel(object formHijo)
        {
            if(this.panelContenedor.Controls.Count > 0)
            {

                   this.panelContenedor.Controls.RemoveAt(0);
                   Debug.WriteLine(this.panelContenedor.Controls.Count);        

            }
            
            Form fh = formHijo as Form;
            
            fh.TopLevel = false;
            fh.Dock =DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();  
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            abrirFormInPanel(new FormLogin());
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            abrirFormInPanel(new FormRegister());
        }

    }
}
