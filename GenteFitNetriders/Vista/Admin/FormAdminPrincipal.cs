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
        public FormAdminPrincipal()
        {
            InitializeComponent();
        }

        private void FormAdminPrincipal_Load(object sender, EventArgs e)
        {
            //TODO cada vez que se clica aumenta la memoria, porque?
            btnClases.Enabled = true;
            btnUsusarios.Enabled = false;
            abrirFormInPanel(new FormAdminUsers());
        }

        private void abrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {

                this.panelContenedor.Controls.RemoveAt(0);
                Debug.WriteLine(this.panelContenedor.Controls.Count);

            }

            Form fh = formHijo as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }



        private void btnUsusarios_Click(object sender, EventArgs e)
        {

            btnUsusarios.Enabled = false;
            btnClases.Enabled = true;
            btnReservas.Enabled = true;
            abrirFormInPanel(new FormAdminUsers());
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            
            btnUsusarios.Enabled = true;
            btnClases.Enabled = false;
            btnReservas.Enabled = true;
            abrirFormInPanel(new FormAdminClases());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            btnClases.Enabled = true;
            btnUsusarios.Enabled = true;
            btnReservas.Enabled = false;
            abrirFormInPanel(new FormAdminReservas());

        }
    }
}
