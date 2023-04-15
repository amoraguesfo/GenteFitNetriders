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
using System.Xml.Linq;

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

            fillDataGrid();
            dataGridClases.ColumnHeaderMouseClick += dataGridClases_ColumnHeaderMouseClick;

        }

        private void fillDataGrid()
        {
            dataGridClases.DataSource = controller.getClases();
            dataGridClases.Columns["id"].Visible = false;
        }
        private void dataGridClases_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dataGridClases.Columns[e.ColumnIndex];

            // Check if the clicked column is a sortable column
            if (clickedColumn.SortMode != DataGridViewColumnSortMode.Automatic)
                return;

            // Determine the sort direction
            ListSortDirection sortDirection;
            if (clickedColumn.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
                sortDirection = ListSortDirection.Descending;
            else
                sortDirection = ListSortDirection.Ascending;

            // Get the data source and column name
            IEnumerable<Modelo.ClaseViewModel> dataSource = (IEnumerable<Modelo.ClaseViewModel>)dataGridClases.DataSource;
            string columnName = clickedColumn.Name;

            // Sort the data using LINQ
            IEnumerable<Modelo.ClaseViewModel> sortedData;
            if (sortDirection == ListSortDirection.Ascending)
                sortedData = dataSource.OrderBy(d => d.GetType().GetProperty(columnName).GetValue(d, null));
            else
                sortedData = dataSource.OrderByDescending(d => d.GetType().GetProperty(columnName).GetValue(d, null));

            // Set the sorted data as the DataGridView's data source
            dataGridClases.DataSource = sortedData.ToList();

            // Set the sort glyph
            DataGridViewColumnHeaderCell headerCell = dataGridClases.Columns[e.ColumnIndex].HeaderCell;
            if (sortDirection == ListSortDirection.Ascending)
                headerCell.SortGlyphDirection = SortOrder.Ascending;
            else
                headerCell.SortGlyphDirection = SortOrder.Descending;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormAminAddClase formAdminAddClase =  new FormAminAddClase();

            formAdminAddClase.ShowDialog();
            fillDataGrid();

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            Modelo.ClaseViewModel clase = (Modelo.ClaseViewModel)dataGridClases.CurrentRow.DataBoundItem;
            controller.deleteClase(clase.id);
            MessageBox.Show("LA clase se ha eliminado correctamente");
            fillDataGrid();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            ImportXML importXML = new ImportXML();  
            importXML.importClasesXML();
            fillDataGrid();
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            ExportXML exportXML = new ExportXML();
            exportXML.exportClaseXML();
        }


    }
}
