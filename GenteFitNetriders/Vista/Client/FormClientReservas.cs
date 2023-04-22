using GenteFitNetriders.Controlador;
using GenteFitNetriders.Vista.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Client
{
    public partial class FormClientReservas : Form
    {
        ReservasController controller;
        public FormClientReservas()
        {
            InitializeComponent();
            controller = new ReservasController();
        }

        private void FormClientReservas_Load(object sender, EventArgs e)
        {
            fillDataGrid(controller.getReservasByUser(Common.userLogged.id));
            dataGridViewReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservas.ColumnHeaderMouseClick += dataGridViewReservas_ColumnHeaderMouseClick;
        }

        private void fillDataGrid(IEnumerable<Modelo.ReservaViewModel> reservasList)
        {
            dataGridViewReservas.DataSource = reservasList;
            dataGridViewReservas.Columns["id"].Visible = false;
            dataGridViewReservas.Columns["id_usuario"].Visible = false;
            dataGridViewReservas.Columns["id_clase"].Visible = false;
            dataGridViewReservas.Columns["nombre_usuario"].Visible = false;
            dataGridViewReservas.Columns["email_usuario"].Visible = false;
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
            //Fix no hacer nada si no hay filas
            if (dataGridViewReservas.Rows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Seguro que quieres anular la reserva?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Modelo.ReservaViewModel reserva = (Modelo.ReservaViewModel)dataGridViewReservas.CurrentRow.DataBoundItem;
                //TODO marcar la reserva como anulada, solo el admin puede borrar datos de la BBDD
                //controller.editReserva(reserva.id,reserva.id_usuario, reserva.id_clase, "cancelada");
                controller.deleteReserva(reserva.id);
                MessageBox.Show("La reserva se ha anulado correctamente");
                fillDataGrid(controller.getReservasByUser(Common.userLogged.id));
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            String usuario = Common.userLogged.nombre, clase, fecha;

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


            fillDataGrid(controller.getReservasByFilter(usuario, clase, fecha));
        }

        private void dataGridViewReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
 
                foreach (DataGridViewRow row in dataGridViewReservas.Rows)
                {
                    // Get the value of the 'Estado' column
                    string estado = row.Cells["estado"].Value.ToString();

                    // Set the color of the cell based on the value
                    if (estado == "reservada")
                    {
                        row.Cells["estado"].Style.BackColor = RGBColors.verde1;
                    }
                    else
                    {
                        row.Cells["estado"].Style.BackColor = RGBColors.amarillo;
                    }
                }

        }
    }
}
