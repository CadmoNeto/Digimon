﻿namespace CadmoTeste.Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exibirDigimonBt = new CadmoTeste.Forms.Custom.CustomButton();
            this.criarDigimonBt = new CadmoTeste.Forms.Custom.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admBt = new CadmoTeste.Forms.Custom.CustomButton();
            this.id = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomelabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exibirDigimonBt);
            this.panel1.Controls.Add(this.criarDigimonBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 355);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CadmoTeste.Properties.Resources.DigimonLogo1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exibirDigimonBt
            // 
            this.exibirDigimonBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exibirDigimonBt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exibirDigimonBt.BorderRadius = 45;
            this.exibirDigimonBt.BorderSize = 0;
            this.exibirDigimonBt.FlatAppearance.BorderSize = 0;
            this.exibirDigimonBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exibirDigimonBt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.exibirDigimonBt.ForeColor = System.Drawing.Color.Black;
            this.exibirDigimonBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exibirDigimonBt.Location = new System.Drawing.Point(6, 222);
            this.exibirDigimonBt.Name = "exibirDigimonBt";
            this.exibirDigimonBt.Size = new System.Drawing.Size(268, 45);
            this.exibirDigimonBt.TabIndex = 5;
            this.exibirDigimonBt.Text = "Exibir Digimon";
            this.exibirDigimonBt.TextColor = System.Drawing.Color.Black;
            this.exibirDigimonBt.UseVisualStyleBackColor = false;
            this.exibirDigimonBt.Click += new System.EventHandler(this.exibirDigimonBt_Click);
            // 
            // criarDigimonBt
            // 
            this.criarDigimonBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.criarDigimonBt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.criarDigimonBt.BorderRadius = 45;
            this.criarDigimonBt.BorderSize = 0;
            this.criarDigimonBt.FlatAppearance.BorderSize = 0;
            this.criarDigimonBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criarDigimonBt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.criarDigimonBt.ForeColor = System.Drawing.Color.Black;
            this.criarDigimonBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.criarDigimonBt.Location = new System.Drawing.Point(6, 148);
            this.criarDigimonBt.Name = "criarDigimonBt";
            this.criarDigimonBt.Size = new System.Drawing.Size(268, 45);
            this.criarDigimonBt.TabIndex = 4;
            this.criarDigimonBt.Text = "Criar Digimon";
            this.criarDigimonBt.TextColor = System.Drawing.Color.Black;
            this.criarDigimonBt.UseVisualStyleBackColor = false;
            this.criarDigimonBt.Click += new System.EventHandler(this.criarDigimonBt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.admBt);
            this.panel2.Controls.Add(this.id);
            this.panel2.Controls.Add(this.nome);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nomelabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 315);
            this.panel2.TabIndex = 4;
            // 
            // admBt
            // 
            this.admBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admBt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admBt.BorderRadius = 45;
            this.admBt.BorderSize = 0;
            this.admBt.FlatAppearance.BorderSize = 0;
            this.admBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admBt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.admBt.ForeColor = System.Drawing.Color.Black;
            this.admBt.Location = new System.Drawing.Point(6, 203);
            this.admBt.Name = "admBt";
            this.admBt.Size = new System.Drawing.Size(147, 45);
            this.admBt.TabIndex = 6;
            this.admBt.Text = "Administrador";
            this.admBt.TextColor = System.Drawing.Color.Black;
            this.admBt.UseVisualStyleBackColor = true;
            this.admBt.Visible = false;
            this.admBt.Click += new System.EventHandler(this.admoBt_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.id.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.id.Location = new System.Drawing.Point(60, 105);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(96, 17);
            this.id.TabIndex = 5;
            this.id.Text = "id";
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.nome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.nome.Location = new System.Drawing.Point(60, 76);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(96, 17);
            this.nome.TabIndex = 4;
            this.nome.Text = "nome";
            // 
            // idLabel
            // 
            this.idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.idLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(3, 105);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digimon Tamer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dados do";
            // 
            // nomelabel
            // 
            this.nomelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.nomelabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.nomelabel.Location = new System.Drawing.Point(3, 76);
            this.nomelabel.Name = "nomelabel";
            this.nomelabel.Size = new System.Drawing.Size(53, 17);
            this.nomelabel.TabIndex = 0;
            this.nomelabel.Text = "Nome:";
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(463, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 15;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(449, -3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(18, 19);
            this.minimize.TabIndex = 16;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(168)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(297, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 321);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.panel4.Location = new System.Drawing.Point(298, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 323);
            this.panel4.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 355);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Custom.CustomButton criarDigimonBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.CustomButton exibirDigimonBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label nomelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nome;
        private Custom.CustomButton admBt;
    }
}