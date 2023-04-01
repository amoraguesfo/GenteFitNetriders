namespace GenteFitNetriders.Vista.Admin
{
    partial class FormAdminPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.btnUsusarios = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GenteFit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnReservas);
            this.panel1.Controls.Add(this.btnClases);
            this.panel1.Controls.Add(this.btnUsusarios);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(474, 12);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(85, 23);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnClases
            // 
            this.btnClases.Location = new System.Drawing.Point(345, 12);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(85, 23);
            this.btnClases.TabIndex = 2;
            this.btnClases.Text = "Clases";
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // btnUsusarios
            // 
            this.btnUsusarios.Location = new System.Drawing.Point(226, 12);
            this.btnUsusarios.Name = "btnUsusarios";
            this.btnUsusarios.Size = new System.Drawing.Size(75, 23);
            this.btnUsusarios.TabIndex = 1;
            this.btnUsusarios.Text = "Usuarios";
            this.btnUsusarios.UseVisualStyleBackColor = true;
            this.btnUsusarios.Click += new System.EventHandler(this.btnUsusarios_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Black;
            this.panelContenedor.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(784, 511);
            this.panelContenedor.TabIndex = 2;
            // 
            // FormAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminPrincipal";
            this.Load += new System.EventHandler(this.FormAdminPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnUsusarios;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnReservas;
    }
}