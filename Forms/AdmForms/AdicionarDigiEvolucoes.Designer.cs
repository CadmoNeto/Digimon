namespace CadmoTeste.Forms
{
    partial class AdicionarDigiEvolucoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarDigiEvolucoes));
            this.especie = new System.Windows.Forms.Label();
            this.evolucao = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.especieBox = new System.Windows.Forms.ComboBox();
            this.evoBox = new System.Windows.Forms.ComboBox();
            this.nivelBox = new System.Windows.Forms.TextBox();
            this.addDigiEvoBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // especie
            // 
            this.especie.AutoSize = true;
            this.especie.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.Location = new System.Drawing.Point(12, 9);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(53, 12);
            this.especie.TabIndex = 0;
            this.especie.Text = "Espécie:";
            // 
            // evolucao
            // 
            this.evolucao.AutoSize = true;
            this.evolucao.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evolucao.Location = new System.Drawing.Point(12, 44);
            this.evolucao.Name = "evolucao";
            this.evolucao.Size = new System.Drawing.Size(89, 12);
            this.evolucao.TabIndex = 1;
            this.evolucao.Text = "Digi-Evolução:";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.Location = new System.Drawing.Point(12, 79);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(107, 12);
            this.nivel.TabIndex = 2;
            this.nivel.Text = "Nível Necessário:";
            // 
            // especieBox
            // 
            this.especieBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieBox.FormattingEnabled = true;
            this.especieBox.Location = new System.Drawing.Point(125, 6);
            this.especieBox.Name = "especieBox";
            this.especieBox.Size = new System.Drawing.Size(121, 20);
            this.especieBox.TabIndex = 3;
            this.especieBox.SelectedIndexChanged += new System.EventHandler(this.especieBox_SelectedIndexChanged);
            // 
            // evoBox
            // 
            this.evoBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evoBox.FormattingEnabled = true;
            this.evoBox.Location = new System.Drawing.Point(125, 41);
            this.evoBox.Name = "evoBox";
            this.evoBox.Size = new System.Drawing.Size(121, 20);
            this.evoBox.TabIndex = 4;
            this.evoBox.SelectedIndexChanged += new System.EventHandler(this.evoBox_SelectedIndexChanged);
            // 
            // nivelBox
            // 
            this.nivelBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelBox.Location = new System.Drawing.Point(125, 76);
            this.nivelBox.Name = "nivelBox";
            this.nivelBox.Size = new System.Drawing.Size(121, 21);
            this.nivelBox.TabIndex = 5;
            // 
            // addDigiEvoBt
            // 
            this.addDigiEvoBt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDigiEvoBt.Location = new System.Drawing.Point(260, 6);
            this.addDigiEvoBt.Name = "addDigiEvoBt";
            this.addDigiEvoBt.Size = new System.Drawing.Size(92, 90);
            this.addDigiEvoBt.TabIndex = 6;
            this.addDigiEvoBt.Text = "Adicionar Digi-Evolução";
            this.addDigiEvoBt.UseVisualStyleBackColor = true;
            this.addDigiEvoBt.Click += new System.EventHandler(this.addDigiEvoBt_Click);
            // 
            // AdicionarDigiEvolucoes
            // 
            this.AcceptButton = this.addDigiEvoBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 114);
            this.Controls.Add(this.addDigiEvoBt);
            this.Controls.Add(this.nivelBox);
            this.Controls.Add(this.evoBox);
            this.Controls.Add(this.especieBox);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.evolucao);
            this.Controls.Add(this.especie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarDigiEvolucoes";
            this.Text = "Adicionar Digi-Evolucoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label evolucao;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.ComboBox especieBox;
        private System.Windows.Forms.ComboBox evoBox;
        private System.Windows.Forms.TextBox nivelBox;
        private System.Windows.Forms.Button addDigiEvoBt;
    }
}