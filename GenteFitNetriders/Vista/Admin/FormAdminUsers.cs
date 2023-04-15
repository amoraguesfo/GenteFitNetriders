using GenteFitNetriders.Controlador;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GenteFitNetriders.Vista
{
    public partial class FormAdminUsers : Form
    {
        private MainController controller;
        public FormAdminUsers()
        {
            InitializeComponent();
            controller = new MainController();
        }


        
        private void FormAdminPanel_Load(object sender, System.EventArgs e)
        {

            fillDataGrid();

        }
        private void fillDataGrid()
        {
            dataGridUsers.DataSource = controller.getUsers();
            dataGridUsers.Columns["password"].Visible = false;
            
        }
        private void btnDelUser_Click(object sender, System.EventArgs e)
        {
            Modelo.UserViewModel user = (Modelo.UserViewModel)dataGridUsers.CurrentRow.DataBoundItem;
            controller.deleteUser(user.id);
            MessageBox.Show("El usuario se ha eliminado correctamente");
            fillDataGrid();
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            ExportXML exportXML = new ExportXML();
            exportXML.exportUsusariosXML();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            
            ImportXML importXML = new ImportXML();
            importXML.importUsuariosXML();
            fillDataGrid();
        }


    }
}
