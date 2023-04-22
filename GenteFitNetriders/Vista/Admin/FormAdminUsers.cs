using GenteFitNetriders.Controlador;
using GenteFitNetriders.Controlador.XML;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GenteFitNetriders.Vista
{
    public partial class FormAdminUsers : Form
    {
        private UserController controller;
        public FormAdminUsers()
        {
            InitializeComponent();
            controller = new UserController();
        }


        
        private void FormAdminPanel_Load(object sender, System.EventArgs e)
        {

            fillDataGrid(controller.getUsers());

        }
        private void fillDataGrid(IEnumerable<Modelo.UserViewModel> usersList)
        {
            dataGridUsers.DataSource = usersList;
            dataGridUsers.Columns["password"].Visible = false;
            
        }
        private void btnDelUser_Click(object sender, System.EventArgs e)
        {
            Modelo.UserViewModel user = (Modelo.UserViewModel)dataGridUsers.CurrentRow.DataBoundItem;
            controller.deleteUser(user.id);
            MessageBox.Show("El usuario se ha eliminado correctamente");
            fillDataGrid(controller.getUsers());
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
           UserXML userXML = new UserXML();
            userXML.exportUsusariosXML();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {

            UserXML userXML = new UserXML();
            userXML.importUsuariosXML();
            fillDataGrid(controller.getUsers());
        }

        private void textSearchUser_KeyUp(object sender, KeyEventArgs e)
        {
            String userName = textSearchUser.Text;
            fillDataGrid(controller.getUsersByNombre(userName));
        }


    }
}
