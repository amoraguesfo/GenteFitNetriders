namespace GenteFitNetriders.Vista.Client
{
    partial class FormClientReservas
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
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.ckFechaFilter = new System.Windows.Forms.CheckBox();
            this.ckClaseFilter = new System.Windows.Forms.CheckBox();
            this.dateTimeSearch = new System.Windows.Forms.DateTimePicker();
            this.textSearchClase = new System.Windows.Forms.TextBox();
            this.btnAnular = new FontAwesome.Sharp.IconButton();
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
            this.dataGridViewReservas.Location = new System.Drawing.Point(16, 80);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            this.dataGridViewReservas.Size = new System.Drawing.Size(979, 523);
            this.dataGridViewReservas.TabIndex = 2;
            this.dataGridViewReservas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewReservas_CellFormatting);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFilter.IconColor = System.Drawing.Color.White;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 30;
            this.btnFilter.Location = new System.Drawing.Point(552, 39);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(38, 34);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ckFechaFilter
            // 
            this.ckFechaFilter.AutoSize = true;
            this.ckFechaFilter.BackColor = System.Drawing.Color.Transparent;
            this.ckFechaFilter.ForeColor = System.Drawing.Color.White;
            this.ckFechaFilter.Location = new System.Drawing.Point(257, 43);
            this.ckFechaFilter.Name = "ckFechaFilter";
            this.ckFechaFilter.Size = new System.Drawing.Size(66, 24);
            this.ckFechaFilter.TabIndex = 34;
            this.ckFechaFilter.Text = "Fecha";
            this.ckFechaFilter.UseVisualStyleBackColor = false;
            // 
            // ckClaseFilter
            // 
            this.ckClaseFilter.AutoSize = true;
            this.ckClaseFilter.BackColor = System.Drawing.Color.Transparent;
            this.ckClaseFilter.ForeColor = System.Drawing.Color.White;
            this.ckClaseFilter.Location = new System.Drawing.Point(36, 43);
            this.ckClaseFilter.Name = "ckClaseFilter";
            this.ckClaseFilter.Size = new System.Drawing.Size(63, 24);
            this.ckClaseFilter.TabIndex = 33;
            this.ckClaseFilter.Text = "Clase";
            this.ckClaseFilter.UseVisualStyleBackColor = false;
            // 
            // dateTimeSearch
            // 
            this.dateTimeSearch.Location = new System.Drawing.Point(329, 43);
            this.dateTimeSearch.Name = "dateTimeSearch";
            this.dateTimeSearch.Size = new System.Drawing.Size(200, 27);
            this.dateTimeSearch.TabIndex = 32;
            // 
            // textSearchClase
            // 
            this.textSearchClase.ForeColor = System.Drawing.Color.DimGray;
            this.textSearchClase.Location = new System.Drawing.Point(106, 43);
            this.textSearchClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchClase.Name = "textSearchClase";
            this.textSearchClase.Size = new System.Drawing.Size(116, 27);
            this.textSearchClase.TabIndex = 31;
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAnular.Location = new System.Drawing.Point(837, 613);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(158, 40);
            this.btnAnular.TabIndex = 37;
            this.btnAnular.Text = "Anular clase";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // FormClientReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.ckFechaFilter);
            this.Controls.Add(this.ckClaseFilter);
            this.Controls.Add(this.dateTimeSearch);
            this.Controls.Add(this.textSearchClase);
            this.Controls.Add(this.dataGridViewReservas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormClientReservas";
            this.Text = "FormClientReservas";
            this.Load += new System.EventHandler(this.FormClientReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private FontAwesome.Sharp.IconButton btnFilter;
        private System.Windows.Forms.CheckBox ckFechaFilter;
        private System.Windows.Forms.CheckBox ckClaseFilter;
        private System.Windows.Forms.DateTimePicker dateTimeSearch;
        private System.Windows.Forms.TextBox textSearchClase;
        private FontAwesome.Sharp.IconButton btnAnular;
    }
}