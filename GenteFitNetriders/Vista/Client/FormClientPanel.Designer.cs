namespace GenteFitNetriders.Vista
{
    partial class FormClientPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnVerClases = new FontAwesome.Sharp.IconButton();
            this.btnMisReservas = new FontAwesome.Sharp.IconButton();
            this.btnEditarPerfil = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVerClases);
            this.panel1.Controls.Add(this.btnMisReservas);
            this.panel1.Controls.Add(this.btnEditarPerfil);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 67);
            this.panel1.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(233, 37);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
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
            this.panelContenedor.TabIndex = 3;
            // 
            // btnVerClases
            // 
            this.btnVerClases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerClases.BackColor = System.Drawing.Color.Black;
            this.btnVerClases.FlatAppearance.BorderSize = 0;
            this.btnVerClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClases.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClases.ForeColor = System.Drawing.Color.White;
            this.btnVerClases.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnVerClases.IconColor = System.Drawing.Color.White;
            this.btnVerClases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerClases.IconSize = 32;
            this.btnVerClases.Location = new System.Drawing.Point(588, 14);
            this.btnVerClases.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(130, 40);
            this.btnVerClases.TabIndex = 9;
            this.btnVerClases.Text = "Clases";
            this.btnVerClases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerClases.UseVisualStyleBackColor = false;
            this.btnVerClases.Click += new System.EventHandler(this.btnVerClases_Click);
            // 
            // btnMisReservas
            // 
            this.btnMisReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMisReservas.BackColor = System.Drawing.Color.Black;
            this.btnMisReservas.FlatAppearance.BorderSize = 0;
            this.btnMisReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisReservas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisReservas.ForeColor = System.Drawing.Color.White;
            this.btnMisReservas.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnMisReservas.IconColor = System.Drawing.Color.White;
            this.btnMisReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisReservas.IconSize = 32;
            this.btnMisReservas.Location = new System.Drawing.Point(728, 14);
            this.btnMisReservas.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnMisReservas.Name = "btnMisReservas";
            this.btnMisReservas.Size = new System.Drawing.Size(130, 40);
            this.btnMisReservas.TabIndex = 8;
            this.btnMisReservas.Text = "Mis Reservas";
            this.btnMisReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisReservas.UseVisualStyleBackColor = false;
            this.btnMisReservas.Click += new System.EventHandler(this.btnMisReservas_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPerfil.BackColor = System.Drawing.Color.Black;
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnEditarPerfil.IconColor = System.Drawing.Color.White;
            this.btnEditarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPerfil.IconSize = 32;
            this.btnEditarPerfil.Location = new System.Drawing.Point(868, 13);
            this.btnEditarPerfil.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(130, 40);
            this.btnEditarPerfil.TabIndex = 7;
            this.btnEditarPerfil.Text = "Editar perfil";
            this.btnEditarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
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
            this.label1.TabIndex = 10;
            this.label1.Text = "GenteFit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormClientPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormClientPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnVerClases;
        private FontAwesome.Sharp.IconButton btnMisReservas;
        private FontAwesome.Sharp.IconButton btnEditarPerfil;
        private System.Windows.Forms.Label label1;
    }
}