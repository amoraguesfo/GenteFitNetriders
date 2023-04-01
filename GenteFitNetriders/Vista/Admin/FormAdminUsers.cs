﻿using GenteFitNetriders.Controlador;
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
            dataGridUsers.DataSource =  controller.getUsers();

        }

        private void btnDelUser_Click(object sender, System.EventArgs e)
        {
            Modelo.UserViewModel user = (Modelo.UserViewModel)dataGridUsers.CurrentRow.DataBoundItem;
            controller.deleteUser(user.id);
            MessageBox.Show("El ususario se ha eliminado correctamente");
            dataGridUsers.DataSource = controller.getUsers();
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
            dataGridUsers.DataSource = controller.getUsers();
        }


    }
}
