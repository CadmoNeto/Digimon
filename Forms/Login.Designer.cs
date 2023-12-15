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
            this.loginBt = new System.Windows.Forms.Button();
            this.cadastrarBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(12, 116);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(53, 11);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuário:";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(12, 150);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(41, 11);
            this.senha.TabIndex = 1;
            this.senha.Text = "Senha:";
            // 
            // usuarioText
            // 
            this.usuarioText.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioText.Location = new System.Drawing.Point(64, 109);
            this.usuarioText.MaxLength = 20;
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(151, 22);
            this.usuarioText.TabIndex = 2;
            // 
            // senhaText
            // 
            this.senhaText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaText.Location = new System.Drawing.Point(64, 143);
            this.senhaText.MaxLength = 8;
            this.senhaText.Name = "senhaText";
            this.senhaText.Size = new System.Drawing.Size(151, 22);
            this.senhaText.TabIndex = 3;
            this.senhaText.UseSystemPasswordChar = true;
            // 
            // loginBt
            // 
            this.loginBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBt.Location = new System.Drawing.Point(15, 182);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(88, 42);
            this.loginBt.TabIndex = 5;
            this.loginBt.Text = "Login";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // cadastrarBt
            // 
            this.cadastrarBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBt.Location = new System.Drawing.Point(127, 182);
            this.cadastrarBt.Name = "cadastrarBt";
            this.cadastrarBt.Size = new System.Drawing.Size(88, 42);
            this.cadastrarBt.TabIndex = 6;
            this.cadastrarBt.Text = "Cadastrar";
            this.cadastrarBt.UseVisualStyleBackColor = true;
            this.cadastrarBt.Click += new System.EventHandler(this.cadastrarBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadmoTeste.Properties.Resources.digvice__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 230);
            this.Controls.Add(this.cadastrarBt);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.senhaText);
            this.Controls.Add(this.usuarioText);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox usuarioText;
        private System.Windows.Forms.TextBox senhaText;
        private System.Windows.Forms.Button loginBt;
        private System.Windows.Forms.Button cadastrarBt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}