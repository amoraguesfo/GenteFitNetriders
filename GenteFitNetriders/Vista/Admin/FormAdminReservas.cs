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
    public partial class FormAdminReservas : Form
    {
        ReservasController controller;
        public FormAdminReservas()
        {
            InitializeComponent();
            controller = new ReservasController();
        }

        private void FormAdminReservas_Load(object sender, EventArgs e)
        {
            
            fillDataGrid(controller.getReservas());
            dataGridViewReservas.ColumnHeaderMouseClick += dataGridViewReservas_ColumnHeaderMouseClick;
        }

        private void fillDataGrid(IEnumerable<Modelo.ReservaViewModel> reservasList) { 

            dataGridViewReservas.DataSource = reservasList;
            dataGridViewReservas.Columns["id_usuario"].Visible = false;
            dataGridViewReservas.Columns["id_clase"].Visible = false;
        }
        private void dataGridViewReservas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dataGridViewReservas.Columns[e.ColumnIndex];

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
            IEnumerable<Modelo.ReservaViewModel> dataSource = (IEnumerable<Modelo.ReservaViewModel>)dataGridViewReservas.DataSource;
            string columnName = clickedColumn.Name;

            // Sort the data using LINQ
            IEnumerable<Modelo.ReservaViewModel> sortedData;
            if (sortDirection == ListSortDirection.Ascending)
                sortedData = dataSource.OrderBy(d => d.GetType().GetProperty(columnName).GetValue(d, null));
            else
                sortedData = dataSource.OrderByDescending(d => d.GetType().GetProperty(columnName).GetValue(d, null));

            // Set the sorted data as the DataGridView's data source
            dataGridViewReservas.DataSource = sortedData.ToList();

            // Set the sort glyph
            DataGridViewColumnHeaderCell headerCell = dataGridViewReservas.Columns[e.ColumnIndex].HeaderCell;
            if (sortDirection == ListSortDirection.Ascending)
                headerCell.SortGlyphDirection = SortOrder.Ascending;
            else
                headerCell.SortGlyphDirection = SortOrder.Descending;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            //Fix no hacer nada si no hay registros
            if (dataGridViewReservas.Rows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta reserva?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Modelo.ReservaViewModel reserva = (Modelo.ReservaViewModel)dataGridViewReservas.CurrentRow.DataBoundItem;
                controller.deleteReserva(reserva.id);
                MessageBox.Show("La reserva se ha eliminado correctamente");
                fillDataGrid(controller.getReservas());
            }


        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            ReservasXML exportXML = new ReservasXML();
            exportXML.exportReservasXML();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            ReservasXML reservasXML = new ReservasXML();
            reservasXML.importReservasXML();
            fillDataGrid(controller.getReservas());
        }

        private void dateTimeSearch_ValueChanged(object sender, EventArgs e)
        {
           // fillDataGrid(controller.getReservasByFecha(dateTimeSearch.Value));
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            String usuario,clase, fecha;
            if (ckUserFilter.Checked)
            {
                usuario = textSearchUser.Text;
            }
            else
            {
                usuario = null;
            }
            if (ckClaseFilter.Checked)
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


            fillDataGrid(controller.getReservasByFilter(usuario,clase, fecha));
        }
    }
}
