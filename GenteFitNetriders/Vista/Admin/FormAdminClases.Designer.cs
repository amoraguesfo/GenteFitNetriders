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
            this.btnDelClase = new System.Windows.Forms.Button();
            this.btnImportarXML = new System.Windows.Forms.Button();
            this.btnExportarXML = new System.Windows.Forms.Button();
            this.addClase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClases
            // 
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Location = new System.Drawing.Point(13, 14);
            this.dataGridClases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.Size = new System.Drawing.Size(774, 522);
            this.dataGridClases.TabIndex = 0;
            // 
            // btnDelClase
            // 
            this.btnDelClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelClase.Location = new System.Drawing.Point(646, 546);
            this.btnDelClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelClase.Name = "btnDelClase";
            this.btnDelClase.Size = new System.Drawing.Size(137, 35);
            this.btnDelClase.TabIndex = 7;
            this.btnDelClase.Text = "Eliminar clase";
            this.btnDelClase.UseVisualStyleBackColor = true;
            this.btnDelClase.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportarXML.Location = new System.Drawing.Point(139, 546);
            this.btnImportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(116, 35);
            this.btnImportarXML.TabIndex = 6;
            this.btnImportarXML.Text = "Importar XML";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarXML.Location = new System.Drawing.Point(16, 546);
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(115, 35);
            this.btnExportarXML.TabIndex = 5;
            this.btnExportarXML.Text = "Exportar XML";
            this.btnExportarXML.UseVisualStyleBackColor = true;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // addClase
            // 
            this.addClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addClase.AutoSize = true;
            this.addClase.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addClase.Location = new System.Drawing.Point(466, 546);
            this.addClase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addClase.Name = "addClase";
            this.addClase.Size = new System.Drawing.Size(137, 35);
            this.addClase.TabIndex = 8;
            this.addClase.Text = "Añadir clase";
            this.addClase.UseVisualStyleBackColor = true;
            this.addClase.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdminClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.addClase);
            this.Controls.Add(this.btnDelClase);
            this.Controls.Add(this.btnImportarXML);
            this.Controls.Add(this.btnExportarXML);
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
        private System.Windows.Forms.Button btnDelClase;
        private System.Windows.Forms.Button btnImportarXML;
        private System.Windows.Forms.Button btnExportarXML;
        private System.Windows.Forms.Button addClase;
    }
}