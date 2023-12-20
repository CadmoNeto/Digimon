namespace CadmoTeste.Forms
{
    partial class AdicionarDigimon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarDigimon));
            this.especieBox = new System.Windows.Forms.TextBox();
            this.estagioCombo = new System.Windows.Forms.ComboBox();
            this.estagioLabel = new System.Windows.Forms.Label();
            this.createDigimonButton = new System.Windows.Forms.Button();
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.especieLabel = new System.Windows.Forms.Label();
            this.nivelLabel = new System.Windows.Forms.Label();
            this.nivelBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // especieBox
            // 
            this.especieBox.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieBox.Location = new System.Drawing.Point(107, 14);
            this.especieBox.MaxLength = 20;
            this.especieBox.Name = "especieBox";
            this.especieBox.Size = new System.Drawing.Size(143, 20);
            this.especieBox.TabIndex = 1;
            // 
            // estagioCombo
            // 
            this.estagioCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.estagioCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estagioCombo.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estagioCombo.FormattingEnabled = true;
            this.estagioCombo.Location = new System.Drawing.Point(107, 70);
            this.estagioCombo.Name = "estagioCombo";
            this.estagioCombo.Size = new System.Drawing.Size(143, 19);
            this.estagioCombo.TabIndex = 3;
            // 
            // estagioLabel
            // 
            this.estagioLabel.AutoSize = true;
            this.estagioLabel.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estagioLabel.Location = new System.Drawing.Point(12, 73);
            this.estagioLabel.Name = "estagioLabel";
            this.estagioLabel.Size = new System.Drawing.Size(53, 11);
            this.estagioLabel.TabIndex = 14;
            this.estagioLabel.Text = "Estágio:";
            // 
            // createDigimonButton
            // 
            this.createDigimonButton.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDigimonButton.Location = new System.Drawing.Point(256, 11);
            this.createDigimonButton.Name = "createDigimonButton";
            this.createDigimonButton.Size = new System.Drawing.Size(118, 103);
            this.createDigimonButton.TabIndex = 15;
            this.createDigimonButton.Text = "Adicionar Digimon";
            this.createDigimonButton.UseVisualStyleBackColor = true;
            this.createDigimonButton.Click += new System.EventHandler(this.createDigimonButton_Click);
            // 
            // tipoCombo
            // 
            this.tipoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tipoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipoCombo.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCombo.FormattingEnabled = true;
            this.tipoCombo.Location = new System.Drawing.Point(107, 42);
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(143, 19);
            this.tipoCombo.TabIndex = 2;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLabel.Location = new System.Drawing.Point(12, 45);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(35, 11);
            this.tipoLabel.TabIndex = 10;
            this.tipoLabel.Text = "Tipo:";
            // 
            // especieLabel
            // 
            this.especieLabel.AutoSize = true;
            this.especieLabel.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieLabel.Location = new System.Drawing.Point(12, 17);
            this.especieLabel.Name = "especieLabel";
            this.especieLabel.Size = new System.Drawing.Size(53, 11);
            this.especieLabel.TabIndex = 8;
            this.especieLabel.Text = "Espécie:";
            // 
            // nivelLabel
            // 
            this.nivelLabel.AutoSize = true;
            this.nivelLabel.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelLabel.Location = new System.Drawing.Point(12, 101);
            this.nivelLabel.Name = "nivelLabel";
            this.nivelLabel.Size = new System.Drawing.Size(89, 11);
            this.nivelLabel.TabIndex = 16;
            this.nivelLabel.Text = "Nível Inicial:";
            // 
            // nivelBox
            // 
            this.nivelBox.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelBox.Location = new System.Drawing.Point(107, 98);
            this.nivelBox.MaxLength = 3;
            this.nivelBox.Name = "nivelBox";
            this.nivelBox.Size = new System.Drawing.Size(143, 20);
            this.nivelBox.TabIndex = 4;
            this.nivelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nivelBox_KeyPress);
            // 
            // AdicionarDigimon
            // 
            this.AcceptButton = this.createDigimonButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 128);
            this.Controls.Add(this.nivelBox);
            this.Controls.Add(this.nivelLabel);
            this.Controls.Add(this.especieBox);
            this.Controls.Add(this.estagioCombo);
            this.Controls.Add(this.estagioLabel);
            this.Controls.Add(this.createDigimonButton);
            this.Controls.Add(this.tipoCombo);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.especieLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarDigimon";
            this.Text = "AdicionarDigimon";
            this.Load += new System.EventHandler(this.AdicionarDigimon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox especieBox;
        private System.Windows.Forms.ComboBox estagioCombo;
        private System.Windows.Forms.Label estagioLabel;
        private System.Windows.Forms.Button createDigimonButton;
        private System.Windows.Forms.ComboBox tipoCombo;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label especieLabel;
        private System.Windows.Forms.Label nivelLabel;
        private System.Windows.Forms.TextBox nivelBox;
    }
}