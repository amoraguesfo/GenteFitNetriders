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
            this.btnRegister = new System.Windows.Forms.Button();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.ForeColor = System.Drawing.Color.DimGray;
            this.textEmail.Location = new System.Drawing.Point(428, 151);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(231, 27);
            this.textEmail.TabIndex = 4;
            this.textEmail.Text = "Email";
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textPassword
            // 
            this.textPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textPassword.Location = new System.Drawing.Point(428, 285);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(231, 27);
            this.textPassword.TabIndex = 6;
            this.textPassword.Text = "Contraseña";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(559, 404);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textConfirmPassword.Location = new System.Drawing.Point(428, 339);
            this.textConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(231, 27);
            this.textConfirmPassword.TabIndex = 7;
            this.textConfirmPassword.Text = "Confirma contraseña";
            this.textConfirmPassword.Enter += new System.EventHandler(this.textConfirmPassword_Enter);
            this.textConfirmPassword.Leave += new System.EventHandler(this.textConfirmPassword_Leave);
            // 
            // textNombre
            // 
            this.textNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textNombre.Location = new System.Drawing.Point(125, 151);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(231, 27);
            this.textNombre.TabIndex = 1;
            this.textNombre.Text = "Nombre";
            this.textNombre.Enter += new System.EventHandler(this.textNombre_Enter);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            // 
            // textEdad
            // 
            this.textEdad.ForeColor = System.Drawing.Color.DimGray;
            this.textEdad.Location = new System.Drawing.Point(428, 206);
            this.textEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(57, 27);
            this.textEdad.TabIndex = 3;
            this.textEdad.Text = "Edad";
            this.textEdad.Enter += new System.EventHandler(this.textEdad_Enter);
            this.textEdad.Leave += new System.EventHandler(this.textEdad_Leave);
            // 
            // textTelefono
            // 
            this.textTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.textTelefono.Location = new System.Drawing.Point(125, 206);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(231, 27);
            this.textTelefono.TabIndex = 2;
            this.textTelefono.Text = "Teléfono";
            this.textTelefono.Enter += new System.EventHandler(this.textTelefono_Enter);
            this.textTelefono.Leave += new System.EventHandler(this.textTelefono_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(150, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(485, 41);
            this.label9.TabIndex = 19;
            this.label9.Text = "Introduce tus datos para registrarte";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(125, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sexo";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(23, 56);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(92, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(23, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFitNetriders.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenteFit inicio de Sesión";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
    }
}

