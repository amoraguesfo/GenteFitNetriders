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
        
        public FormLoginPrincipal()
        {
            InitializeComponent();
          
        }


        
        private void FormLoginPrincipal_Load(object sender, EventArgs e)
        {
            //TODO cada vez que se clica aumenta la memoria, porque?
            btnLogin.Enabled = false;
            btnRegistro.Enabled = true;
            abrirFormInPanel(new FormLogin());
        }

        private void abrirFormInPanel(object formHijo)
        {
            if(this.panelContenedor.Controls.Count > 0)
            {
                   this.panelContenedor.Controls.RemoveAt(0);            
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
            btnLogin.Enabled = false;
            btnRegistro.Enabled = true;
            abrirFormInPanel(new FormLogin());
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnRegistro.Enabled = false;
            abrirFormInPanel(new FormRegister());
        }
    }
}
