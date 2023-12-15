using CadmoTeste.Data;

namespace CadmoTeste
{
    partial class CriarDigimon
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarDigimon));
            this.especieLabel = new System.Windows.Forms.Label();
            this.especieCombo = new System.Windows.Forms.ComboBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.createDigimonButton = new System.Windows.Forms.Button();
            this.estagioLabel = new System.Windows.Forms.Label();
            this.estagioCombo = new System.Windows.Forms.ComboBox();
            this.nome = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // especieLabel
            // 
            this.especieLabel.AutoSize = true;
            this.especieLabel.Location = new System.Drawing.Point(12, 40);
            this.especieLabel.Name = "especieLabel";
            this.especieLabel.Size = new System.Drawing.Size(48, 13);
            this.especieLabel.TabIndex = 0;
            this.especieLabel.Text = "Espécie:";
            // 
            // especieCombo
            // 
            this.especieCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.especieCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.especieCombo.FormattingEnabled = true;
            this.especieCombo.Location = new System.Drawing.Point(84, 38);
            this.especieCombo.Name = "especieCombo";
            this.especieCombo.Size = new System.Drawing.Size(143, 21);
            this.especieCombo.TabIndex = 2;
            this.especieCombo.SelectedIndexChanged += new System.EventHandler(this.especieCombo_SelectedIndexChanged);
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(12, 67);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(31, 13);
            this.tipoLabel.TabIndex = 2;
            this.tipoLabel.Text = "Tipo:";
            // 
            // tipoCombo
            // 
            this.tipoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tipoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipoCombo.FormattingEnabled = true;
            this.tipoCombo.Location = new System.Drawing.Point(84, 64);
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(143, 21);
            this.tipoCombo.TabIndex = 3;
            this.tipoCombo.SelectedIndexChanged += new System.EventHandler(this.tipoCombo_SelectedIndexChanged);
            // 
            // createDigimonButton
            // 
            this.createDigimonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDigimonButton.Location = new System.Drawing.Point(233, 12);
            this.createDigimonButton.Name = "createDigimonButton";
            this.createDigimonButton.Size = new System.Drawing.Size(90, 99);
            this.createDigimonButton.TabIndex = 5;
            this.createDigimonButton.Text = "Criar Digimon";
            this.createDigimonButton.UseVisualStyleBackColor = true;
            this.createDigimonButton.Click += new System.EventHandler(this.createDigimonButton_Click);
            // 
            // estagioLabel
            // 
            this.estagioLabel.AutoSize = true;
            this.estagioLabel.Location = new System.Drawing.Point(12, 93);
            this.estagioLabel.Name = "estagioLabel";
            this.estagioLabel.Size = new System.Drawing.Size(45, 13);
            this.estagioLabel.TabIndex = 5;
            this.estagioLabel.Text = "Estágio:";
            // 
            // estagioCombo
            // 
            this.estagioCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.estagioCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estagioCombo.FormattingEnabled = true;
            this.estagioCombo.Location = new System.Drawing.Point(84, 90);
            this.estagioCombo.Name = "estagioCombo";
            this.estagioCombo.Size = new System.Drawing.Size(143, 21);
            this.estagioCombo.TabIndex = 4;
            this.estagioCombo.SelectedIndexChanged += new System.EventHandler(this.estagioCombo_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(12, 15);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 7;
            this.nome.Text = "Nome:";
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(84, 12);
            this.nomeBox.MaxLength = 20;
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(143, 20);
            this.nomeBox.TabIndex = 1;
            // 
            // CriarDigimon
            // 
            this.AcceptButton = this.createDigimonButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 123);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.estagioCombo);
            this.Controls.Add(this.estagioLabel);
            this.Controls.Add(this.createDigimonButton);
            this.Controls.Add(this.tipoCombo);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.especieCombo);
            this.Controls.Add(this.especieLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarDigimon";
            this.Text = "Criar Digimon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label especieLabel;
        private System.Windows.Forms.ComboBox especieCombo;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.ComboBox tipoCombo;
        private System.Windows.Forms.Button createDigimonButton;
        private System.Windows.Forms.Label estagioLabel;
        private System.Windows.Forms.ComboBox estagioCombo;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox nomeBox;
    }
}

