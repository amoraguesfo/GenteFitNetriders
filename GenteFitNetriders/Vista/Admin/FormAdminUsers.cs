using GenteFitNetriders.Controlador;
using GenteFitNetriders.Controlador.XML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            dataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsers.ColumnHeaderMouseClick += dataGridClases_ColumnHeaderMouseClick;


        }
        private void fillDataGrid(IEnumerable<Modelo.UserViewModel> usersList)
        {
            dataGridUsers.DataSource = usersList;
            dataGridUsers.Columns["password"].Visible = false;
            
        }
        private void dataGridClases_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dataGridUsers.Columns[e.ColumnIndex];

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
            IEnumerable<Modelo.UserViewModel> dataSource = (IEnumerable<Modelo.UserViewModel>)dataGridUsers.DataSource;
            string columnName = clickedColumn.Name;

            // Sort the data using LINQ
            IEnumerable<Modelo.UserViewModel> sortedData;
            if (sortDirection == ListSortDirection.Ascending)
                sortedData = dataSource.OrderBy(d => d.GetType().GetProperty(columnName).GetValue(d, null));
            else
                sortedData = dataSource.OrderByDescending(d => d.GetType().GetProperty(columnName).GetValue(d, null));

            // Set the sorted data as the DataGridView's data source
            dataGridUsers.DataSource = sortedData.ToList();

            // Set the sort glyph
            DataGridViewColumnHeaderCell headerCell = dataGridUsers.Columns[e.ColumnIndex].HeaderCell;
            if (sortDirection == ListSortDirection.Ascending)
                headerCell.SortGlyphDirection = SortOrder.Ascending;
            else
                headerCell.SortGlyphDirection = SortOrder.Descending;
        }
        private void btnDelUser_Click(object sender, System.EventArgs e)
        {
            //Fix no hacer nada si no hay registros
            if (dataGridUsers.Rows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Seguro que quieres borrar este usuario?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Modelo.UserViewModel user = (Modelo.UserViewModel)dataGridUsers.CurrentRow.DataBoundItem;
                controller.deleteUser(user.id);
                MessageBox.Show("El usuario se ha eliminado correctamente");
                fillDataGrid(controller.getUsers());
            }

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
