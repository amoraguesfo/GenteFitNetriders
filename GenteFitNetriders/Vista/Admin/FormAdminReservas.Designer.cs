namespace GenteFitNetriders.Vista.Admin
{
    partial class FormAdminReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.dateTimeSearch = new System.Windows.Forms.DateTimePicker();
            this.textSearchUser = new System.Windows.Forms.TextBox();
            this.ckUserFilter = new System.Windows.Forms.CheckBox();
            this.ckFechaFilter = new System.Windows.Forms.CheckBox();
            this.textSearchClase = new System.Windows.Forms.TextBox();
            this.ckClaseFilter = new System.Windows.Forms.CheckBox();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnAnular = new FontAwesome.Sharp.IconButton();
            this.btnImportarXML = new FontAwesome.Sharp.IconButton();
            this.btnExportarXML = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AllowUserToDeleteRows = false;
            this.dataGridViewReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(13, 85);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            this.dataGridViewReservas.Size = new System.Drawing.Size(982, 513);
            this.dataGridViewReservas.TabIndex = 4;
            this.dataGridViewReservas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridUsers_CellFormatting);
            // 
            // dateTimeSearch
            // 
            this.dateTimeSearch.Location = new System.Drawing.Point(584, 49);
            this.dateTimeSearch.Name = "dateTimeSearch";
            this.dateTimeSearch.Size = new System.Drawing.Size(200, 27);
            this.dateTimeSearch.TabIndex = 19;
            this.dateTimeSearch.ValueChanged += new System.EventHandler(this.dateTimeSearch_ValueChanged);
            // 
            // textSearchUser
            // 
            this.textSearchUser.ForeColor = System.Drawing.Color.DimGray;
            this.textSearchUser.Location = new System.Drawing.Point(107, 49);
            this.textSearchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchUser.Name = "textSearchUser";
            this.textSearchUser.Size = new System.Drawing.Size(134, 27);
            this.textSearchUser.TabIndex = 20;
            // 
            // ckUserFilter
            // 
            this.ckUserFilter.AutoSize = true;
            this.ckUserFilter.ForeColor = System.Drawing.Color.White;
            this.ckUserFilter.Location = new System.Drawing.Point(16, 49);
            this.ckUserFilter.Name = "ckUserFilter";
            this.ckUserFilter.Size = new System.Drawing.Size(84, 24);
            this.ckUserFilter.TabIndex = 23;
            this.ckUserFilter.Text = "Ususario";
            this.ckUserFilter.UseVisualStyleBackColor = true;
            // 
            // ckFechaFilter
            // 
            this.ckFechaFilter.AutoSize = true;
            this.ckFechaFilter.ForeColor = System.Drawing.Color.White;
            this.ckFechaFilter.Location = new System.Drawing.Point(512, 49);
            this.ckFechaFilter.Name = "ckFechaFilter";
            this.ckFechaFilter.Size = new System.Drawing.Size(66, 24);
            this.ckFechaFilter.TabIndex = 25;
            this.ckFechaFilter.Text = "Fecha";
            this.ckFechaFilter.UseVisualStyleBackColor = true;
            // 
            // textSearchClase
            // 
            this.textSearchClase.ForeColor = System.Drawing.Color.DimGray;
            this.textSearchClase.Location = new System.Drawing.Point(361, 49);
            this.textSearchClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchClase.Name = "textSearchClase";
            this.textSearchClase.Size = new System.Drawing.Size(116, 27);
            this.textSearchClase.TabIndex = 16;
            // 
            // ckClaseFilter
            // 
            this.ckClaseFilter.AutoSize = true;
            this.ckClaseFilter.ForeColor = System.Drawing.Color.White;
            this.ckClaseFilter.Location = new System.Drawing.Point(291, 49);
            this.ckClaseFilter.Name = "ckClaseFilter";
            this.ckClaseFilter.Size = new System.Drawing.Size(63, 24);
            this.ckClaseFilter.TabIndex = 24;
            this.ckClaseFilter.Text = "Clase";
            this.ckClaseFilter.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFilter.IconColor = System.Drawing.Color.White;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 30;
            this.btnFilter.Location = new System.Drawing.Point(807, 45);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(38, 34);
            this.btnFilter.TabIndex = 30;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnAnular.IconColor = System.Drawing.Color.White;
            this.btnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnular.IconSize = 32;
            this.btnAnular.Location = new System.Drawing.Point(837, 608);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(158, 40);
            this.btnAnular.TabIndex = 33;
            this.btnAnular.Text = "Eliminar Reserva";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarXML.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarXML.FlatAppearance.BorderSize = 0;
            this.btnImportarXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImportarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarXML.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarXML.ForeColor = System.Drawing.Color.White;
            this.btnImportarXML.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnImportarXML.IconColor = System.Drawing.Color.White;
            this.btnImportarXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportarXML.IconSize = 32;
            this.btnImportarXML.Location = new System.Drawing.Point(127, 608);
            this.btnImportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(102, 40);
            this.btnImportarXML.TabIndex = 32;
            this.btnImportarXML.Text = "Importar";
            this.btnImportarXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarXML.UseVisualStyleBackColor = false;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarXML.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarXML.FlatAppearance.BorderSize = 0;
            this.btnExportarXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarXML.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarXML.ForeColor = System.Drawing.Color.White;
            this.btnExportarXML.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnExportarXML.IconColor = System.Drawing.Color.White;
            this.btnExportarXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarXML.IconSize = 32;
            this.btnExportarXML.Location = new System.Drawing.Point(17, 608);
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(102, 40);
            this.btnExportarXML.TabIndex = 31;
            this.btnExportarXML.Text = "Exportar";
            this.btnExportarXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarXML.UseVisualStyleBackColor = false;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // FormAdminReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnImportarXML);
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.ckFechaFilter);
            this.Controls.Add(this.ckClaseFilter);
            this.Controls.Add(this.ckUserFilter);
            this.Controls.Add(this.textSearchUser);
            this.Controls.Add(this.dateTimeSearch);
            this.Controls.Add(this.textSearchClase);
            this.Controls.Add(this.dataGridViewReservas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdminReservas";
            this.Text = "FormAdminReservas";
            this.Load += new System.EventHandler(this.FormAdminReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.DateTimePicker dateTimeSearch;
        private System.Windows.Forms.TextBox textSearchUser;
        private System.Windows.Forms.CheckBox ckUserFilter;
        private System.Windows.Forms.CheckBox ckFechaFilter;
        private System.Windows.Forms.TextBox textSearchClase;
        private System.Windows.Forms.CheckBox ckClaseFilter;
        private FontAwesome.Sharp.IconButton btnFilter;
        private FontAwesome.Sharp.IconButton btnAnular;
        private FontAwesome.Sharp.IconButton btnImportarXML;
        private FontAwesome.Sharp.IconButton btnExportarXML;
    }
}