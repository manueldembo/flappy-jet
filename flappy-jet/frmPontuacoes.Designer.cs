namespace flappy_jet
{
    partial class frmPontuacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPontuacoes));
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblTerceiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimeiro.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiro.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiro.Location = new System.Drawing.Point(351, 138);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(58, 32);
            this.lblPrimeiro.TabIndex = 0;
            this.lblPrimeiro.Text = "label1";
            // 
            // lblTerceiro
            // 
            this.lblTerceiro.AutoSize = true;
            this.lblTerceiro.BackColor = System.Drawing.Color.Transparent;
            this.lblTerceiro.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceiro.ForeColor = System.Drawing.Color.White;
            this.lblTerceiro.Location = new System.Drawing.Point(351, 310);
            this.lblTerceiro.Name = "lblTerceiro";
            this.lblTerceiro.Size = new System.Drawing.Size(64, 32);
            this.lblTerceiro.TabIndex = 1;
            this.lblTerceiro.Text = "label2";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.White;
            this.lblSegundo.Location = new System.Drawing.Point(351, 222);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(64, 32);
            this.lblSegundo.TabIndex = 2;
            this.lblSegundo.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Melhores pontuações";
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.Image = global::flappy_jet.Properties.Resources.voltar;
            this.picVoltar.Location = new System.Drawing.Point(688, 338);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(100, 100);
            this.picVoltar.TabIndex = 4;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            this.picVoltar.MouseEnter += new System.EventHandler(this.picVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.picVoltar_MouseLeave);
            // 
            // frmPontuacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappy_jet.Properties.Resources.pontuacao_fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblTerceiro);
            this.Controls.Add(this.lblPrimeiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPontuacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pontuações";
            this.Load += new System.EventHandler(this.frmPontuacoes_Load);
            this.Resize += new System.EventHandler(this.frmPontuacoes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblTerceiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}