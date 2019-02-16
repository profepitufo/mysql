namespace BDMySQL
{
    partial class FormConectarMySQL
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
            this.labelServidor = new System.Windows.Forms.Label();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.ServidorTextBox = new System.Windows.Forms.TextBox();
            this.PuertoTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.ConectarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.BackColor = System.Drawing.Color.Transparent;
            this.labelServidor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServidor.ForeColor = System.Drawing.Color.Lavender;
            this.labelServidor.Location = new System.Drawing.Point(98, 61);
            this.labelServidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(58, 17);
            this.labelServidor.TabIndex = 0;
            this.labelServidor.Text = "Servidor";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.BackColor = System.Drawing.Color.Transparent;
            this.labelPuerto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuerto.ForeColor = System.Drawing.Color.Lavender;
            this.labelPuerto.Location = new System.Drawing.Point(98, 133);
            this.labelPuerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(48, 17);
            this.labelPuerto.TabIndex = 0;
            this.labelPuerto.Text = "Puerto";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Lavender;
            this.labelUsuario.Location = new System.Drawing.Point(98, 205);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(54, 17);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Lavender;
            this.labelPassword.Location = new System.Drawing.Point(98, 277);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 17);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            // 
            // ServidorTextBox
            // 
            this.ServidorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServidorTextBox.Location = new System.Drawing.Point(214, 61);
            this.ServidorTextBox.Name = "ServidorTextBox";
            this.ServidorTextBox.Size = new System.Drawing.Size(100, 24);
            this.ServidorTextBox.TabIndex = 1;
            // 
            // PuertoTextBox
            // 
            this.PuertoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PuertoTextBox.Location = new System.Drawing.Point(214, 130);
            this.PuertoTextBox.Name = "PuertoTextBox";
            this.PuertoTextBox.Size = new System.Drawing.Size(100, 24);
            this.PuertoTextBox.TabIndex = 2;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioTextBox.Location = new System.Drawing.Point(214, 199);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(100, 24);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordTextBox.Location = new System.Drawing.Point(214, 268);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.PasswordChar = '*';
            this.PassWordTextBox.Size = new System.Drawing.Size(100, 24);
            this.PassWordTextBox.TabIndex = 4;
            this.PassWordTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ConectarButton
            // 
            this.ConectarButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ConectarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConectarButton.Location = new System.Drawing.Point(101, 326);
            this.ConectarButton.Name = "ConectarButton";
            this.ConectarButton.Size = new System.Drawing.Size(213, 38);
            this.ConectarButton.TabIndex = 9;
            this.ConectarButton.Text = "Conectar a MySQL";
            this.ConectarButton.UseVisualStyleBackColor = false;
            this.ConectarButton.Click += new System.EventHandler(this.ConectarButton_Click);
            // 
            // FormTestingMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::BDMySQL.Properties.Resources.mysqlLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 403);
            this.Controls.Add(this.ConectarButton);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.PuertoTextBox);
            this.Controls.Add(this.ServidorTextBox);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelPuerto);
            this.Controls.Add(this.labelServidor);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTestingMySQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion a MySQL";
            this.Load += new System.EventHandler(this.FormTestingMySQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox ServidorTextBox;
        private System.Windows.Forms.TextBox PuertoTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Button ConectarButton;
    }
}

