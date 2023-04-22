namespace GenteFitNetriders.Vista.Client
{
    partial class FormClientClases
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
            this.dataGridViewClases = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ckFechaFilter = new System.Windows.Forms.CheckBox();
            this.ckUserFilter = new System.Windows.Forms.CheckBox();
            this.dateTimeSearch = new System.Windows.Forms.DateTimePicker();
            this.textSearchClase = new System.Windows.Forms.TextBox();
            this.btnReservar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClases
            // 
            this.dataGridViewClases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClases.Location = new System.Drawing.Point(16, 75);
            this.dataGridViewClases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewClases.Name = "dataGridViewClases";
            this.dataGridViewClases.Size = new System.Drawing.Size(979, 528);
            this.dataGridViewClases.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(560, 34);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 34);
            this.iconButton1.TabIndex = 34;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ckFechaFilter
            // 
            this.ckFechaFilter.AutoSize = true;
            this.ckFechaFilter.ForeColor = System.Drawing.Color.White;
            this.ckFechaFilter.Location = new System.Drawing.Point(266, 38);
            this.ckFechaFilter.Name = "ckFechaFilter";
            this.ckFechaFilter.Size = new System.Drawing.Size(66, 24);
            this.ckFechaFilter.TabIndex = 33;
            this.ckFechaFilter.Text = "Fecha";
            this.ckFechaFilter.UseVisualStyleBackColor = true;
            // 
            // ckUserFilter
            // 
            this.ckUserFilter.AutoSize = true;
            this.ckUserFilter.ForeColor = System.Drawing.Color.White;
            this.ckUserFilter.Location = new System.Drawing.Point(34, 38);
            this.ckUserFilter.Name = "ckUserFilter";
            this.ckUserFilter.Size = new System.Drawing.Size(63, 24);
            this.ckUserFilter.TabIndex = 32;
            this.ckUserFilter.Text = "Clase";
            this.ckUserFilter.UseVisualStyleBackColor = true;
            // 
            // dateTimeSearch
            // 
            this.dateTimeSearch.Location = new System.Drawing.Point(338, 38);
            this.dateTimeSearch.Name = "dateTimeSearch";
            this.dateTimeSearch.Size = new System.Drawing.Size(200, 27);
            this.dateTimeSearch.TabIndex = 31;
            // 
            // textSearchClase
            // 
            this.textSearchClase.ForeColor = System.Drawing.Color.DimGray;
            this.textSearchClase.Location = new System.Drawing.Point(104, 38);
            this.textSearchClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchClase.Name = "textSearchClase";
            this.textSearchClase.Size = new System.Drawing.Size(116, 27);
            this.textSearchClase.TabIndex = 30;
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.BackColor = System.Drawing.Color.Transparent;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnReservar.IconColor = System.Drawing.Color.White;
            this.btnReservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservar.IconSize = 32;
            this.btnReservar.Location = new System.Drawing.Point(837, 613);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(158, 40);
            this.btnReservar.TabIndex = 38;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // FormClientClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ckFechaFilter);
            this.Controls.Add(this.ckUserFilter);
            this.Controls.Add(this.dateTimeSearch);
            this.Controls.Add(this.textSearchClase);
            this.Controls.Add(this.dataGridViewClases);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormClientClases";
            this.Text = "FormClientClases";
            this.Load += new System.EventHandler(this.FormClientClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClases;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.CheckBox ckFechaFilter;
        private System.Windows.Forms.CheckBox ckUserFilter;
        private System.Windows.Forms.DateTimePicker dateTimeSearch;
        private System.Windows.Forms.TextBox textSearchClase;
        private FontAwesome.Sharp.IconButton btnReservar;
    }
}