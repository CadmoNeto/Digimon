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
            this.criarDigimonBt = new System.Windows.Forms.Button();
            this.exibirDigimonBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criarDigimonBt
            // 
            this.criarDigimonBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarDigimonBt.Location = new System.Drawing.Point(14, 16);
            this.criarDigimonBt.Name = "criarDigimonBt";
            this.criarDigimonBt.Size = new System.Drawing.Size(114, 46);
            this.criarDigimonBt.TabIndex = 0;
            this.criarDigimonBt.Text = "Criar Digimon";
            this.criarDigimonBt.UseVisualStyleBackColor = true;
            this.criarDigimonBt.Click += new System.EventHandler(this.criarDigimonBt_Click);
            // 
            // exibirDigimonBt
            // 
            this.exibirDigimonBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirDigimonBt.Location = new System.Drawing.Point(134, 16);
            this.exibirDigimonBt.Name = "exibirDigimonBt";
            this.exibirDigimonBt.Size = new System.Drawing.Size(114, 46);
            this.exibirDigimonBt.TabIndex = 1;
            this.exibirDigimonBt.Text = "Exibir Digimon";
            this.exibirDigimonBt.UseVisualStyleBackColor = true;
            this.exibirDigimonBt.Click += new System.EventHandler(this.exibirDigimonBt_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 144);
            this.Controls.Add(this.exibirDigimonBt);
            this.Controls.Add(this.criarDigimonBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button criarDigimonBt;
        private System.Windows.Forms.Button exibirDigimonBt;
    }
}