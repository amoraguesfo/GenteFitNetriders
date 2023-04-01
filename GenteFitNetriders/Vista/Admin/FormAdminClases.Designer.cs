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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClases
            // 
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Location = new System.Drawing.Point(12, 38);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.Size = new System.Drawing.Size(788, 337);
            this.dataGridClases.TabIndex = 0;
            // 
            // btnDelClase
            // 
            this.btnDelClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelClase.Location = new System.Drawing.Point(685, 415);
            this.btnDelClase.Name = "btnDelClase";
            this.btnDelClase.Size = new System.Drawing.Size(103, 23);
            this.btnDelClase.TabIndex = 7;
            this.btnDelClase.Text = "Eliminar clase";
            this.btnDelClase.UseVisualStyleBackColor = true;
            this.btnDelClase.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportarXML.Location = new System.Drawing.Point(104, 415);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(87, 23);
            this.btnImportarXML.TabIndex = 6;
            this.btnImportarXML.Text = "Importar XML";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
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
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // addClase
            // 
            this.addClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addClase.AutoSize = true;
            this.addClase.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addClase.Location = new System.Drawing.Point(550, 415);
            this.addClase.Name = "addClase";
            this.addClase.Size = new System.Drawing.Size(103, 23);
            this.addClase.TabIndex = 8;
            this.addClase.Text = "Añadir clase";
            this.addClase.UseVisualStyleBackColor = true;
            this.addClase.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestion de clases";
            // 
            // FormAdminClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addClase);
            this.Controls.Add(this.btnDelClase);
            this.Controls.Add(this.btnImportarXML);
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.dataGridClases);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminClases";
            this.Text = "FormAdminClases";
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
        private System.Windows.Forms.Label label1;
    }
}