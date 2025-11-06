namespace FeriaOnline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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


        private System.Windows.Forms.Label lblFeria;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOlvido;

        /// <summary>
        /// Method required for Designer support - initializes controls.
        /// </summary>
        private void InitializeComponent()
        {
            lblFeria = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnLogin = new Button();
            btnOlvido = new Button();
            SuspendLayout();
            // 
            // lblFeria
            // 
            lblFeria.AutoSize = true;
            lblFeria.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFeria.Location = new Point(132, 9);
            lblFeria.Name = "lblFeria";
            lblFeria.Size = new Size(118, 25);
            lblFeria.TabIndex = 0;
            lblFeria.Text = "Feria Online";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(12, 100);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(100, 57);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(100, 97);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(200, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOlvido
            // 
            btnOlvido.Location = new Point(200, 140);
            btnOlvido.Name = "btnOlvido";
            btnOlvido.Size = new Size(100, 23);
            btnOlvido.TabIndex = 6;
            btnOlvido.Text = "Olvidé Contraseña";
            btnOlvido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 200);
            Controls.Add(btnOlvido);
            Controls.Add(btnLogin);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblFeria);
            Name = "Form1";
            Text = "Feria Online";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
