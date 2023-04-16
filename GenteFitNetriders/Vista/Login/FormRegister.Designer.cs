namespace GenteFitNetriders
{
    partial class FormRegister
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textSexo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(530, 174);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(231, 27);
            this.textEmail.TabIndex = 0;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(530, 225);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(231, 27);
            this.textPassword.TabIndex = 1;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contrasseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(148, 303);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repite Contrasseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Location = new System.Drawing.Point(530, 275);
            this.textConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.PasswordChar = '*';
            this.textConfirmPassword.Size = new System.Drawing.Size(231, 27);
            this.textConfirmPassword.TabIndex = 6;
            this.textConfirmPassword.TextChanged += new System.EventHandler(this.textConfirmPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(117, 122);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(248, 27);
            this.textNombre.TabIndex = 8;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(117, 176);
            this.textEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(248, 27);
            this.textEdad.TabIndex = 13;
            this.textEdad.TextChanged += new System.EventHandler(this.textEdad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(388, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telefono";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(530, 120);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(231, 27);
            this.textTelefono.TabIndex = 15;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 233);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sexo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textSexo
            // 
            this.textSexo.Location = new System.Drawing.Point(117, 227);
            this.textSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(62, 27);
            this.textSexo.TabIndex = 17;
            this.textSexo.TextChanged += new System.EventHandler(this.textSexo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Introduce tus datos para registrarte";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenteFit inicio de Sesión";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSexo;
        private System.Windows.Forms.Label label9;
    }
}

