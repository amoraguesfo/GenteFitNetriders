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
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportarXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClases
            // 
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Location = new System.Drawing.Point(12, 12);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.Size = new System.Drawing.Size(788, 363);
            this.dataGridClases.TabIndex = 0;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelUser.Location = new System.Drawing.Point(685, 415);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(103, 23);
            this.btnDelUser.TabIndex = 7;
            this.btnDelUser.Text = "Eliminar usuario";
            this.btnDelUser.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportar.Location = new System.Drawing.Point(104, 415);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(87, 23);
            this.btnImportar.TabIndex = 6;
            this.btnImportar.Text = "Importar XML";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarXML.Location = new System.Drawing.Point(12, 415);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(86, 23);
            this.btnExportarXML.TabIndex = 5;
            this.btnExportarXML.Text = "Exportar XML";
            this.btnExportarXML.UseVisualStyleBackColor = true;
            // 
            // FormAdminClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.dataGridClases);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminClases";
            this.Text = "FormAdminClases";
            this.Load += new System.EventHandler(this.FormAdminClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClases;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportarXML;
    }
}