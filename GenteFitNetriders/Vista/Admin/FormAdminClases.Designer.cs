namespace GenteFitNetriders.Vista.Admin
{
    partial class FormAdminClases
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
            this.dataGridClases = new System.Windows.Forms.DataGridView();
            this.textSearchClase = new System.Windows.Forms.TextBox();
            this.dateTimeSearch = new System.Windows.Forms.DateTimePicker();
            this.ckFechaFilter = new System.Windows.Forms.CheckBox();
            this.ckUserFilter = new System.Windows.Forms.CheckBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnDelClase = new FontAwesome.Sharp.IconButton();
            this.btnImportarXML = new FontAwesome.Sharp.IconButton();
            this.btnExportarXML = new FontAwesome.Sharp.IconButton();
            this.addClase = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClases
            // 
            this.dataGridClases.AllowUserToAddRows = false;
            this.dataGridClases.AllowUserToDeleteRows = false;
            this.dataGridClases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Location = new System.Drawing.Point(13, 78);
            this.dataGridClases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.ReadOnly = true;
            this.dataGridClases.Size = new System.Drawing.Size(978, 520);
            this.dataGridClases.TabIndex = 0;
            // 
            // textSearchClase
            // 
            this.textSearchClase.ForeColor = System.Drawing.Color.DimGray;
            this.textSearchClase.Location = new System.Drawing.Point(106, 33);
            this.textSearchClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchClase.Name = "textSearchClase";
            this.textSearchClase.Size = new System.Drawing.Size(116, 27);
            this.textSearchClase.TabIndex = 11;
            // 
            // dateTimeSearch
            // 
            this.dateTimeSearch.Location = new System.Drawing.Point(340, 33);
            this.dateTimeSearch.Name = "dateTimeSearch";
            this.dateTimeSearch.Size = new System.Drawing.Size(200, 27);
            this.dateTimeSearch.TabIndex = 15;
            // 
            // ckFechaFilter
            // 
            this.ckFechaFilter.AutoSize = true;
            this.ckFechaFilter.ForeColor = System.Drawing.Color.White;
            this.ckFechaFilter.Location = new System.Drawing.Point(268, 33);
            this.ckFechaFilter.Name = "ckFechaFilter";
            this.ckFechaFilter.Size = new System.Drawing.Size(66, 24);
            this.ckFechaFilter.TabIndex = 27;
            this.ckFechaFilter.Text = "Fecha";
            this.ckFechaFilter.UseVisualStyleBackColor = true;
            // 
            // ckUserFilter
            // 
            this.ckUserFilter.AutoSize = true;
            this.ckUserFilter.ForeColor = System.Drawing.Color.White;
            this.ckUserFilter.Location = new System.Drawing.Point(36, 33);
            this.ckUserFilter.Name = "ckUserFilter";
            this.ckUserFilter.Size = new System.Drawing.Size(63, 24);
            this.ckUserFilter.TabIndex = 26;
            this.ckUserFilter.Text = "Clase";
            this.ckUserFilter.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(562, 29);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 34);
            this.iconButton1.TabIndex = 29;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelClase
            // 
            this.btnDelClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelClase.BackColor = System.Drawing.Color.Transparent;
            this.btnDelClase.FlatAppearance.BorderSize = 0;
            this.btnDelClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelClase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelClase.ForeColor = System.Drawing.Color.White;
            this.btnDelClase.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelClase.IconColor = System.Drawing.Color.White;
            this.btnDelClase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelClase.IconSize = 32;
            this.btnDelClase.Location = new System.Drawing.Point(833, 608);
            this.btnDelClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelClase.Name = "btnDelClase";
            this.btnDelClase.Size = new System.Drawing.Size(158, 40);
            this.btnDelClase.TabIndex = 36;
            this.btnDelClase.Text = "Eliminar Clase";
            this.btnDelClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelClase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelClase.UseVisualStyleBackColor = false;
            this.btnDelClase.Click += new System.EventHandler(this.btnDelClase_Click);
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
            this.btnImportarXML.Location = new System.Drawing.Point(123, 608);
            this.btnImportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(102, 40);
            this.btnImportarXML.TabIndex = 35;
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
            this.btnExportarXML.Location = new System.Drawing.Point(13, 608);
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(102, 40);
            this.btnExportarXML.TabIndex = 34;
            this.btnExportarXML.Text = "Exportar";
            this.btnExportarXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarXML.UseVisualStyleBackColor = false;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // addClase
            // 
            this.addClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addClase.BackColor = System.Drawing.Color.Transparent;
            this.addClase.FlatAppearance.BorderSize = 0;
            this.addClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClase.ForeColor = System.Drawing.Color.White;
            this.addClase.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.addClase.IconColor = System.Drawing.Color.White;
            this.addClase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addClase.IconSize = 32;
            this.addClase.Location = new System.Drawing.Point(667, 608);
            this.addClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addClase.Name = "addClase";
            this.addClase.Size = new System.Drawing.Size(158, 40);
            this.addClase.TabIndex = 37;
            this.addClase.Text = "Nueva Clase";
            this.addClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addClase.UseVisualStyleBackColor = false;
            this.addClase.Click += new System.EventHandler(this.addClase_Click);
            // 
            // FormAdminClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.addClase);
            this.Controls.Add(this.btnDelClase);
            this.Controls.Add(this.btnImportarXML);
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ckFechaFilter);
            this.Controls.Add(this.ckUserFilter);
            this.Controls.Add(this.dateTimeSearch);
            this.Controls.Add(this.textSearchClase);
            this.Controls.Add(this.dataGridClases);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdminClases";
            this.Load += new System.EventHandler(this.FormAdminClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClases;
        private System.Windows.Forms.TextBox textSearchClase;
        private System.Windows.Forms.DateTimePicker dateTimeSearch;
        private System.Windows.Forms.CheckBox ckFechaFilter;
        private System.Windows.Forms.CheckBox ckUserFilter;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnDelClase;
        private FontAwesome.Sharp.IconButton btnImportarXML;
        private FontAwesome.Sharp.IconButton btnExportarXML;
        private FontAwesome.Sharp.IconButton addClase;
    }
}