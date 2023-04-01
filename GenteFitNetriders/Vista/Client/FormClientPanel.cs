using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista.Client;
using System.Diagnostics;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista
{

    public partial class FormClientPanel : Form
    {

        public FormClientPanel()
        {
            InitializeComponent();

        }

        private void FormClientPanel_Load(object sender, System.EventArgs e)
        {
            labelNombre.Text = Common.userLogged.nombre;
            btnVerClases.Enabled = true;
            btnMisReservas.Enabled = true;
            btnEditarPerfil.Enabled = true;
            abrirFormInPanel(new FormClientClases());
        }

        private void btnVerClases_Click(object sender, System.EventArgs e)
        {
            btnVerClases.Enabled = false;
            btnMisReservas.Enabled = true;
            btnEditarPerfil.Enabled = true;
            abrirFormInPanel(new FormClientClases());
        }


        private void btnMisReservas_Click(object sender, System.EventArgs e)
        {
            btnVerClases.Enabled = true;
            btnMisReservas.Enabled = false;
            btnEditarPerfil.Enabled = true;
            abrirFormInPanel(new FormClientReservas());
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

        private void btnEditarPerfil_Click(object sender, System.EventArgs e)
        {
            btnVerClases.Enabled = true;
            btnMisReservas.Enabled = true;
            btnEditarPerfil.Enabled = false;
            abrirFormInPanel(new FormClientEditProfile(this));
        }
    }


}
