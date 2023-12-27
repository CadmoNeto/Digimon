namespace CadmoTeste.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.criarDigimonBt = new System.Windows.Forms.Button();
            this.exibirDigimonBt = new System.Windows.Forms.Button();
            this.admBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton1 = new CadmoTeste.Forms.Custom.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // criarDigimonBt
            // 
            this.criarDigimonBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarDigimonBt.Location = new System.Drawing.Point(293, 81);
            this.criarDigimonBt.Name = "criarDigimonBt";
            this.criarDigimonBt.Size = new System.Drawing.Size(120, 46);
            this.criarDigimonBt.TabIndex = 0;
            this.criarDigimonBt.Text = "Criar Digimon";
            this.criarDigimonBt.UseVisualStyleBackColor = true;
            this.criarDigimonBt.Click += new System.EventHandler(this.criarDigimonBt_Click);
            // 
            // exibirDigimonBt
            // 
            this.exibirDigimonBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirDigimonBt.Location = new System.Drawing.Point(293, 133);
            this.exibirDigimonBt.Name = "exibirDigimonBt";
            this.exibirDigimonBt.Size = new System.Drawing.Size(120, 46);
            this.exibirDigimonBt.TabIndex = 1;
            this.exibirDigimonBt.Text = "Exibir Digimon";
            this.exibirDigimonBt.UseVisualStyleBackColor = true;
            this.exibirDigimonBt.Click += new System.EventHandler(this.exibirDigimonBt_Click);
            // 
            // admBt
            // 
            this.admBt.Enabled = false;
            this.admBt.Font = new System.Drawing.Font("SimSun", 11F);
            this.admBt.Location = new System.Drawing.Point(293, 199);
            this.admBt.Name = "admBt";
            this.admBt.Size = new System.Drawing.Size(120, 46);
            this.admBt.TabIndex = 2;
            this.admBt.Text = "Administrador";
            this.admBt.UseVisualStyleBackColor = true;
            this.admBt.Visible = false;
            this.admBt.Click += new System.EventHandler(this.admBt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 355);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadmoTeste.Properties.Resources.DigimonLogo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customButton1.BorderRadius = 45;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(6, 106);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(268, 45);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admBt);
            this.Controls.Add(this.exibirDigimonBt);
            this.Controls.Add(this.criarDigimonBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button criarDigimonBt;
        private System.Windows.Forms.Button exibirDigimonBt;
        private System.Windows.Forms.Button admBt;
        private System.Windows.Forms.Panel panel1;
        private Custom.CustomButton customButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}