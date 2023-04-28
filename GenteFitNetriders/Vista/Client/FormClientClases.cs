﻿using GenteFitNetriders.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Client
{
    public partial class FormClientClases : Form
    {
        ClaseController controllerReservas;
        ReservasController controller;
        public FormClientClases()
        {
            InitializeComponent();
            controllerReservas = new ClaseController();
            controller = new ReservasController();
        }

        private void FormClientClases_Load(object sender, EventArgs e)
        {
            //fillDataGrid(controllerReservas.getClases());
            dataGridViewClases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClases.ColumnHeaderMouseClick += dataGridClases_ColumnHeaderMouseClick;
            filter();
        }


        private void fillDataGrid(IEnumerable<Modelo.ClaseViewModel> classList)
        {
            dataGridViewClases.DataSource = classList;
            dataGridViewClases.Columns["id"].Visible = false;
        }


        private void dataGridClases_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dataGridViewClases.Columns[e.ColumnIndex];

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
            IEnumerable<Modelo.ClaseViewModel> dataSource = (IEnumerable<Modelo.ClaseViewModel>)dataGridViewClases.DataSource;
            string columnName = clickedColumn.Name;

            // Sort the data using LINQ
            IEnumerable<Modelo.ClaseViewModel> sortedData;
            if (sortDirection == ListSortDirection.Ascending)
                sortedData = dataSource.OrderBy(d => d.GetType().GetProperty(columnName).GetValue(d, null));
            else
                sortedData = dataSource.OrderByDescending(d => d.GetType().GetProperty(columnName).GetValue(d, null));

            // Set the sorted data as the DataGridView's data source
            dataGridViewClases.DataSource = sortedData.ToList();

            // Set the sort glyph
            DataGridViewColumnHeaderCell headerCell = dataGridViewClases.Columns[e.ColumnIndex].HeaderCell;
            if (sortDirection == ListSortDirection.Ascending)
                headerCell.SortGlyphDirection = SortOrder.Ascending;
            else
                headerCell.SortGlyphDirection = SortOrder.Descending;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
         
            Modelo.ClaseViewModel clase = (Modelo.ClaseViewModel)dataGridViewClases.CurrentRow.DataBoundItem;
            var resrvasUser = controller.getReservasByUser(Common.userLogged.id);
            foreach (var res in resrvasUser)
            {
                if (res.id_clase == clase.id) {
                    MessageBox.Show("Ya tinenes reserva para esta clase");
                    return;
                }    
            }
            //TODO mirar si esto se puede mejorar usando find o contains del EF:
            //si ya se tiene reserva no se puede reservar
                string estado = controller.getReservasByClass(clase.id).Count() < clase.plazas ? "reservada" : "espera";
                controller.addReserva(Common.userLogged.id, clase.id, estado);
                MessageBox.Show("La reserva se ha realizado correctamente");
            filter();
            //fillDataGrid(controllerReservas.getClases());


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {
            String clase, fecha;
            if (ckUserFilter.Checked)
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


            fillDataGrid(controllerReservas.getClasesByFecha(clase, fecha));
        }

    }


}

