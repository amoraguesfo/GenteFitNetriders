using GenteFitNetriders.Controlador;
using GenteFitNetriders.Controlador.XML;
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
        private ClaseController controller;
        public FormAdminClases()
        {
            InitializeComponent();
            controller = new ClaseController();
        }

        private void FormAdminClases_Load(object sender, EventArgs e)
        {

            fillDataGrid(controller.getClases());
            dataGridClases.ColumnHeaderMouseClick += dataGridClases_ColumnHeaderMouseClick;

        }

        private void fillDataGrid(IEnumerable<Modelo.ClaseViewModel> classList)
        {
            dataGridClases.DataSource = classList;
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

        private void addClase_Click(object sender, EventArgs e)
        {

            FormAminAddClase formAdminAddClase =  new FormAminAddClase();

            formAdminAddClase.ShowDialog();
            fillDataGrid(controller.getClases());

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres borrar esta clase?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Modelo.ClaseViewModel clase = (Modelo.ClaseViewModel)dataGridClases.CurrentRow.DataBoundItem;
                controller.deleteClase(clase.id);
                MessageBox.Show("La clase se ha eliminado correctamente");
                fillDataGrid(controller.getClases());
            }

        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            ClasesXML clasesXML = new ClasesXML();
            clasesXML.importClasesXML();
            fillDataGrid(controller.getClases());
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            ClasesXML clasesXML = new ClasesXML();
            clasesXML.exportClaseXML();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            String clase, fecha;
            if(ckUserFilter.Checked)
            {
                clase = textSearchClase.Text;
            }
            else
            {
                clase = null;
            }
            if (ckFechaFilter.Checked)
            {
                fecha = dateTimeSearch.Value.Date.ToString("yyyy-MM-dd");
            }
            else
            {
                fecha = null;
            }


            fillDataGrid(controller.getClasesByFecha(clase, fecha));
        }
    }
}
