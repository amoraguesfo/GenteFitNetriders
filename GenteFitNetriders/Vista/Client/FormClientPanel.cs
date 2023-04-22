using FontAwesome.Sharp;
using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista.Client;
using GenteFitNetriders.Vista.utils;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista
{

    public partial class FormClientPanel : Form
    {
            
        private IconButton currentButton;
        private Form formHijoActual;
        public FormClientPanel()
        {
            InitializeComponent();

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
        private void FormClientPanel_Load(object sender, System.EventArgs e)
        {
            labelNombre.Text = Common.userLogged.nombre;
            ActiveButton(btnMisReservas, RGBColors.verde1);
            AbrirFormHijo(new FormClientReservas());
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

        private void btnEditarPerfil_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormClientEditProfile(this));
        }
        private void btnVerClases_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormClientClases());
        }


        private void btnMisReservas_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.verde1);
            AbrirFormHijo(new FormClientReservas());
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }


}
