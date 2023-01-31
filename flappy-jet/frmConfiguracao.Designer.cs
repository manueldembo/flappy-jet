namespace flappy_jet
{
    partial class frmConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
            this.label1 = new System.Windows.Forms.Label();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.rdPadrao = new System.Windows.Forms.RadioButton();
            this.rdPacotes = new System.Windows.Forms.RadioButton();
            this.cmbPacotes = new System.Windows.Forms.ComboBox();
            this.cmbNave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMusica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça aqui as suas configuraçõs de jogo";
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.Image = global::flappy_jet.Properties.Resources.voltar;
            this.picVoltar.Location = new System.Drawing.Point(688, 338);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(100, 100);
            this.picVoltar.TabIndex = 5;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            this.picVoltar.MouseEnter += new System.EventHandler(this.picVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.picVoltar_MouseLeave);
            // 
            // rdPadrao
            // 
            this.rdPadrao.AutoSize = true;
            this.rdPadrao.Checked = true;
            this.rdPadrao.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPadrao.ForeColor = System.Drawing.Color.White;
            this.rdPadrao.Location = new System.Drawing.Point(55, 88);
            this.rdPadrao.Name = "rdPadrao";
            this.rdPadrao.Size = new System.Drawing.Size(228, 30);
            this.rdPadrao.TabIndex = 6;
            this.rdPadrao.TabStop = true;
            this.rdPadrao.Text = "Usar configurações padorões";
            this.rdPadrao.UseVisualStyleBackColor = true;
            // 
            // rdPacotes
            // 
            this.rdPacotes.AutoSize = true;
            this.rdPacotes.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPacotes.ForeColor = System.Drawing.Color.White;
            this.rdPacotes.Location = new System.Drawing.Point(55, 149);
            this.rdPacotes.Name = "rdPacotes";
            this.rdPacotes.Size = new System.Drawing.Size(119, 30);
            this.rdPacotes.TabIndex = 6;
            this.rdPacotes.Text = "Usar pacotes";
            this.rdPacotes.UseVisualStyleBackColor = true;
            this.rdPacotes.CheckedChanged += new System.EventHandler(this.rdPacotes_CheckedChanged);
            // 
            // cmbPacotes
            // 
            this.cmbPacotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacotes.Enabled = false;
            this.cmbPacotes.FormattingEnabled = true;
            this.cmbPacotes.Location = new System.Drawing.Point(76, 185);
            this.cmbPacotes.Name = "cmbPacotes";
            this.cmbPacotes.Size = new System.Drawing.Size(207, 21);
            this.cmbPacotes.TabIndex = 7;
            // 
            // cmbNave
            // 
            this.cmbNave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNave.FormattingEnabled = true;
            this.cmbNave.Location = new System.Drawing.Point(76, 273);
            this.cmbNave.Name = "cmbNave";
            this.cmbNave.Size = new System.Drawing.Size(207, 21);
            this.cmbNave.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecionar nave";
            // 
            // cmbMusica
            // 
            this.cmbMusica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusica.FormattingEnabled = true;
            this.cmbMusica.Items.AddRange(new object[] {
            "---Desligada---",
            "---Ligada---"});
            this.cmbMusica.Location = new System.Drawing.Point(76, 354);
            this.cmbMusica.Name = "cmbMusica";
            this.cmbMusica.Size = new System.Drawing.Size(207, 21);
            this.cmbMusica.TabIndex = 9;
            this.cmbMusica.TextChanged += new System.EventHandler(this.cmbMusica_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Música";
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMusica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNave);
            this.Controls.Add(this.cmbPacotes);
            this.Controls.Add(this.rdPacotes);
            this.Controls.Add(this.rdPadrao);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.Resize += new System.EventHandler(this.frmConfiguracao_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.RadioButton rdPadrao;
        private System.Windows.Forms.RadioButton rdPacotes;
        private System.Windows.Forms.ComboBox cmbPacotes;
        private System.Windows.Forms.ComboBox cmbNave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMusica;
        private System.Windows.Forms.Label label3;
    }
}