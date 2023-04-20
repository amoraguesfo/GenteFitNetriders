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
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnClases = new FontAwesome.Sharp.IconButton();
            this.btnReservas = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "GenteFit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnClases);
            this.panel1.Controls.Add(this.btnReservas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 67);
            this.panel1.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 32;
            this.btnUsuarios.Location = new System.Drawing.Point(588, 14);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(130, 40);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClases
            // 
            this.btnClases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClases.BackColor = System.Drawing.Color.Black;
            this.btnClases.FlatAppearance.BorderSize = 0;
            this.btnClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClases.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClases.ForeColor = System.Drawing.Color.White;
            this.btnClases.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnClases.IconColor = System.Drawing.Color.White;
            this.btnClases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClases.IconSize = 32;
            this.btnClases.Location = new System.Drawing.Point(726, 14);
            this.btnClases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(130, 40);
            this.btnClases.TabIndex = 5;
            this.btnClases.Text = "Clases";
            this.btnClases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClases.UseVisualStyleBackColor = false;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservas.BackColor = System.Drawing.Color.Black;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnReservas.IconColor = System.Drawing.Color.White;
            this.btnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservas.IconSize = 32;
            this.btnReservas.Location = new System.Drawing.Point(864, 14);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(130, 40);
            this.btnReservas.TabIndex = 4;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Black;
            this.panelContenedor.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 67);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1008, 662);
            this.panelContenedor.TabIndex = 2;
            // 
            // FormAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnClases;
        private FontAwesome.Sharp.IconButton btnReservas;
    }
}