namespace GenteFitNetriders.Vista
{
    partial class FormAdminUsers
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
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textSearchUser = new System.Windows.Forms.TextBox();
            this.btnExportarXML = new FontAwesome.Sharp.IconButton();
            this.btnImportarXML = new FontAwesome.Sharp.IconButton();
            this.btnDelUser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(13, 78);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.Size = new System.Drawing.Size(979, 520);
            this.dataGridUsers.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fitrar por usuario";
            // 
            // textSearchUser
            // 
            this.textSearchUser.ForeColor = System.Drawing.Color.DimGray;
            this.textSearchUser.Location = new System.Drawing.Point(139, 41);
            this.textSearchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchUser.Name = "textSearchUser";
            this.textSearchUser.Size = new System.Drawing.Size(180, 27);
            this.textSearchUser.TabIndex = 9;
            this.textSearchUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearchUser_KeyUp);
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
            this.btnExportarXML.Location = new System.Drawing.Point(14, 605);
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(102, 40);
            this.btnExportarXML.TabIndex = 11;
            this.btnExportarXML.Text = "Exportar";
            this.btnExportarXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarXML.UseVisualStyleBackColor = false;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
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
            this.btnImportarXML.Location = new System.Drawing.Point(124, 605);
            this.btnImportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(102, 40);
            this.btnImportarXML.TabIndex = 12;
            this.btnImportarXML.Text = "Importar";
            this.btnImportarXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarXML.UseVisualStyleBackColor = false;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDelUser.FlatAppearance.BorderSize = 0;
            this.btnDelUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUser.ForeColor = System.Drawing.Color.White;
            this.btnDelUser.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelUser.IconColor = System.Drawing.Color.White;
            this.btnDelUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelUser.IconSize = 32;
            this.btnDelUser.Location = new System.Drawing.Point(834, 605);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(158, 40);
            this.btnDelUser.TabIndex = 13;
            this.btnDelUser.Text = "Eliminar Usuario";
            this.btnDelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // FormAdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnImportarXML);
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSearchUser);
            this.Controls.Add(this.dataGridUsers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdminUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenteFit Panel de Administración";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSearchUser;
        private FontAwesome.Sharp.IconButton btnExportarXML;
        private FontAwesome.Sharp.IconButton btnImportarXML;
        private FontAwesome.Sharp.IconButton btnDelUser;
    }
}