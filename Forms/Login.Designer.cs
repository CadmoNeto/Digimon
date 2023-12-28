namespace CadmoTeste.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuario = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.senhaText = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.welcome2 = new System.Windows.Forms.Label();
            this.welcome3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.cadastrarBt = new CadmoTeste.Forms.Custom.CustomButton();
            this.loginBt = new CadmoTeste.Forms.Custom.CustomButton();
            this.checkLembrarConta = new System.Windows.Forms.CheckBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usuario.AutoSize = true;
            this.usuario.Enabled = false;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(281, 126);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 19);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuário:";
            // 
            // senha
            // 
            this.senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.senha.AutoSize = true;
            this.senha.Enabled = false;
            this.senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(281, 180);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(64, 19);
            this.senha.TabIndex = 1;
            this.senha.Text = "Senha:";
            // 
            // usuarioText
            // 
            this.usuarioText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioText.Location = new System.Drawing.Point(283, 145);
            this.usuarioText.MaxLength = 20;
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(268, 26);
            this.usuarioText.TabIndex = 1;
            // 
            // senhaText
            // 
            this.senhaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.senhaText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaText.Location = new System.Drawing.Point(283, 199);
            this.senhaText.MaxLength = 8;
            this.senhaText.Name = "senhaText";
            this.senhaText.Size = new System.Drawing.Size(268, 26);
            this.senhaText.TabIndex = 2;
            this.senhaText.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 380);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CadmoTeste.Properties.Resources.DigimonLogo;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 380);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // welcome
            // 
            this.welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(305, 50);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(224, 19);
            this.welcome.TabIndex = 11;
            this.welcome.Text = "Bem-vindo ao Mundo Digital";
            // 
            // welcome2
            // 
            this.welcome2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.welcome2.AutoSize = true;
            this.welcome2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome2.Location = new System.Drawing.Point(281, 69);
            this.welcome2.Name = "welcome2";
            this.welcome2.Size = new System.Drawing.Size(277, 19);
            this.welcome2.TabIndex = 12;
            this.welcome2.Text = "Acesse utilizando suas credenciais";
            // 
            // welcome3
            // 
            this.welcome3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.welcome3.AutoSize = true;
            this.welcome3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome3.Location = new System.Drawing.Point(323, 88);
            this.welcome3.Name = "welcome3";
            this.welcome3.Size = new System.Drawing.Size(187, 19);
            this.welcome3.TabIndex = 13;
            this.welcome3.Text = "ou crie uma conta nova";
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(538, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 14;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minimize.AutoSize = true;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(524, -3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(18, 19);
            this.minimize.TabIndex = 15;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // cadastrarBt
            // 
            this.cadastrarBt.BackColor = System.Drawing.Color.White;
            this.cadastrarBt.BackgroundColor = System.Drawing.Color.White;
            this.cadastrarBt.BorderRadius = 45;
            this.cadastrarBt.BorderSize = 0;
            this.cadastrarBt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(156)))), ((int)(((byte)(244)))));
            this.cadastrarBt.FlatAppearance.BorderSize = 0;
            this.cadastrarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarBt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBt.ForeColor = System.Drawing.Color.Black;
            this.cadastrarBt.Location = new System.Drawing.Point(283, 312);
            this.cadastrarBt.Name = "cadastrarBt";
            this.cadastrarBt.Size = new System.Drawing.Size(268, 45);
            this.cadastrarBt.TabIndex = 5;
            this.cadastrarBt.Text = "CADASTRAR";
            this.cadastrarBt.TextColor = System.Drawing.Color.Black;
            this.cadastrarBt.UseVisualStyleBackColor = false;
            this.cadastrarBt.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // loginBt
            // 
            this.loginBt.BackColor = System.Drawing.Color.White;
            this.loginBt.BackgroundColor = System.Drawing.Color.White;
            this.loginBt.BorderRadius = 45;
            this.loginBt.BorderSize = 0;
            this.loginBt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(156)))), ((int)(((byte)(244)))));
            this.loginBt.FlatAppearance.BorderSize = 0;
            this.loginBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBt.ForeColor = System.Drawing.Color.Black;
            this.loginBt.Location = new System.Drawing.Point(283, 261);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(268, 45);
            this.loginBt.TabIndex = 4;
            this.loginBt.Text = "LOGIN";
            this.loginBt.TextColor = System.Drawing.Color.Black;
            this.loginBt.UseVisualStyleBackColor = false;
            this.loginBt.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkLembrarConta
            // 
            this.checkLembrarConta.AutoSize = true;
            this.checkLembrarConta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLembrarConta.Location = new System.Drawing.Point(285, 231);
            this.checkLembrarConta.Name = "checkLembrarConta";
            this.checkLembrarConta.Size = new System.Drawing.Size(84, 18);
            this.checkLembrarConta.TabIndex = 3;
            this.checkLembrarConta.Text = "Lembrar-me";
            this.checkLembrarConta.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(556, 380);
            this.Controls.Add(this.checkLembrarConta);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.welcome3);
            this.Controls.Add(this.welcome2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.cadastrarBt);
            this.Controls.Add(this.senhaText);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuarioText);
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox usuarioText;
        private System.Windows.Forms.TextBox senhaText;
        private System.Windows.Forms.Panel panel5;
        private Custom.CustomButton loginBt;
        private Custom.CustomButton cadastrarBt;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label welcome2;
        private System.Windows.Forms.Label welcome3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkLembrarConta;
    }
}