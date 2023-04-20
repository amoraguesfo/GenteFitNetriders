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
            this.btnReservar = new System.Windows.Forms.Button();
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
            this.dataGridViewClases.Location = new System.Drawing.Point(16, 18);
            this.dataGridViewClases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewClases.Name = "dataGridViewClases";
            this.dataGridViewClases.Size = new System.Drawing.Size(979, 585);
            this.dataGridViewClases.TabIndex = 0;
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.Location = new System.Drawing.Point(895, 613);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 35);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClases;
        private System.Windows.Forms.Button btnReservar;
    }
}