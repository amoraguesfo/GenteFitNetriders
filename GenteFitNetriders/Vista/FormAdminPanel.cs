using GenteFitNetriders.Controlador;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GenteFitNetriders.Vista
{
    public partial class FormAdminPanel : Form
    {
        private MainController controller;
        public FormAdminPanel()
        {
            InitializeComponent();
            controller = new MainController();
        }


        
        private void FormAdminPanel_Load(object sender, System.EventArgs e)
        {
            dataGridUsers.DataSource =  controller.getUsers();

        }

        private void btnDelUser_Click(object sender, System.EventArgs e)
        {
            Modelo.UserViewModel user = (Modelo.UserViewModel)dataGridUsers.CurrentRow.DataBoundItem;
            controller.deleteUser(user.id);
            dataGridUsers.DataSource = controller.getUsers();
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            controller.exportUsusariosXML();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            controller.exportUsusariosXML();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            controller.importarUsuariosXML();
            dataGridUsers.DataSource = controller.getUsers();
        }
    }
}
