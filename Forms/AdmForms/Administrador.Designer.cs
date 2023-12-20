namespace CadmoTeste.Forms
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.addDigiBt = new System.Windows.Forms.Button();
            this.addDigiEvoBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDigiBt
            // 
            this.addDigiBt.Font = new System.Drawing.Font("SimSun", 11F);
            this.addDigiBt.Location = new System.Drawing.Point(12, 12);
            this.addDigiBt.Name = "addDigiBt";
            this.addDigiBt.Size = new System.Drawing.Size(114, 46);
            this.addDigiBt.TabIndex = 3;
            this.addDigiBt.Text = "Adicionar Digimon";
            this.addDigiBt.UseVisualStyleBackColor = true;
            this.addDigiBt.Click += new System.EventHandler(this.addDigiBt_Click);
            // 
            // addDigiEvoBt
            // 
            this.addDigiEvoBt.Font = new System.Drawing.Font("SimSun", 11F);
            this.addDigiEvoBt.Location = new System.Drawing.Point(152, 12);
            this.addDigiEvoBt.Name = "addDigiEvoBt";
            this.addDigiEvoBt.Size = new System.Drawing.Size(114, 46);
            this.addDigiEvoBt.TabIndex = 4;
            this.addDigiEvoBt.Text = "Adicionar DigiEvolução";
            this.addDigiEvoBt.UseVisualStyleBackColor = true;
            this.addDigiEvoBt.Click += new System.EventHandler(this.addDigiEvoBt_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(276, 92);
            this.Controls.Add(this.addDigiEvoBt);
            this.Controls.Add(this.addDigiBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDigiBt;
        private System.Windows.Forms.Button addDigiEvoBt;
    }
}