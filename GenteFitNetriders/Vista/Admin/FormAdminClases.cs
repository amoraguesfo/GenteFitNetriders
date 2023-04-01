using GenteFitNetriders.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Admin
{
    public partial class FormAdminClases : Form
    {
        private MainController controller;
        public FormAdminClases()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void FormAdminClases_Load(object sender, EventArgs e)
        {
            dataGridClases.DataSource = controller.getClases();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormAminAddClase formAdminAddClase =  new FormAminAddClase();

            formAdminAddClase.ShowDialog();
            dataGridClases.DataSource = controller.getClases();

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            Modelo.ClaseViewModel clase = (Modelo.ClaseViewModel)dataGridClases.CurrentRow.DataBoundItem;
            controller.deleteClase(clase.id);
            MessageBox.Show("LA clase se ha eliminado correctamente");
            dataGridClases.DataSource = controller.getClases();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            ImportXML importXML = new ImportXML();  
            importXML.importClasesXML();
            dataGridClases.DataSource = controller.getClases();
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            ExportXML exportXML = new ExportXML();
            exportXML.exportClaseXML();
        }


    }
}
