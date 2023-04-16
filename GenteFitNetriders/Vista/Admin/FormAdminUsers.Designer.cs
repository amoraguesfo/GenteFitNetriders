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
            this.btnExportarXML = new System.Windows.Forms.Button();
            this.btnImportarXML = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(13, 14);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(768, 479);
            this.dataGridUsers.TabIndex = 1;
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarXML.Location = new System.Drawing.Point(16, 546);
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(115, 35);
            this.btnExportarXML.TabIndex = 2;
            this.btnExportarXML.Text = "Exportar XML";
            this.btnExportarXML.UseVisualStyleBackColor = true;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportarXML.Location = new System.Drawing.Point(139, 546);
            this.btnImportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(116, 35);
            this.btnImportarXML.TabIndex = 3;
            this.btnImportarXML.Text = "Importar XML";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelUser.Location = new System.Drawing.Point(647, 546);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(137, 35);
            this.btnDelUser.TabIndex = 4;
            this.btnDelUser.Text = "Eliminar usuario";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // FormAdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnImportarXML);
            this.Controls.Add(this.btnExportarXML);
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

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnExportarXML;
        private System.Windows.Forms.Button btnImportarXML;
        private System.Windows.Forms.Button btnDelUser;
    }
}