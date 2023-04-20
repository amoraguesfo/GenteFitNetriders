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
            this.btnAnular = new System.Windows.Forms.Button();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.Location = new System.Drawing.Point(895, 613);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(100, 35);
            this.btnAnular.TabIndex = 3;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(16, 18);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.Size = new System.Drawing.Size(979, 585);
            this.dataGridViewReservas.TabIndex = 2;
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

        }

        #endregion

        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
    }
}