namespace flappy_jet
{
    partial class frmJogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.picCanoBaixo = new System.Windows.Forms.PictureBox();
            this.picCanoCima = new System.Windows.Forms.PictureBox();
            this.pic_chao = new System.Windows.Forms.PictureBox();
            this.pic_jet = new System.Windows.Forms.PictureBox();
            this.picNuvemSol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoBaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoCima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuvemSol)).BeginInit();
            this.SuspendLayout();
            // 
            // tempo
            // 
            this.tempo.Interval = 50;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblPontuacao.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(12, 416);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(91, 25);
            this.lblPontuacao.TabIndex = 1;
            this.lblPontuacao.Text = "Pontuação: 0";
            // 
            // picCanoBaixo
            // 
            this.picCanoBaixo.BackColor = System.Drawing.Color.Transparent;
            this.picCanoBaixo.Image = global::flappy_jet.Properties.Resources.cano_cima;
            this.picCanoBaixo.Location = new System.Drawing.Point(391, 269);
            this.picCanoBaixo.Name = "picCanoBaixo";
            this.picCanoBaixo.Size = new System.Drawing.Size(100, 120);
            this.picCanoBaixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanoBaixo.TabIndex = 2;
            this.picCanoBaixo.TabStop = false;
            // 
            // picCanoCima
            // 
            this.picCanoCima.BackColor = System.Drawing.Color.Transparent;
            this.picCanoCima.Image = global::flappy_jet.Properties.Resources.cano_baixo;
            this.picCanoCima.Location = new System.Drawing.Point(512, 0);
            this.picCanoCima.Name = "picCanoCima";
            this.picCanoCima.Size = new System.Drawing.Size(100, 145);
            this.picCanoCima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanoCima.TabIndex = 2;
            this.picCanoCima.TabStop = false;
            // 
            // pic_chao
            // 
            this.pic_chao.Image = global::flappy_jet.Properties.Resources.chao;
            this.pic_chao.Location = new System.Drawing.Point(-1, 388);
            this.pic_chao.Name = "pic_chao";
            this.pic_chao.Size = new System.Drawing.Size(805, 61);
            this.pic_chao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_chao.TabIndex = 0;
            this.pic_chao.TabStop = false;
            // 
            // pic_jet
            // 
            this.pic_jet.BackColor = System.Drawing.Color.Transparent;
            this.pic_jet.Image = global::flappy_jet.Properties.Resources.nave;
            this.pic_jet.Location = new System.Drawing.Point(265, 162);
            this.pic_jet.Name = "pic_jet";
            this.pic_jet.Size = new System.Drawing.Size(100, 50);
            this.pic_jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_jet.TabIndex = 0;
            this.pic_jet.TabStop = false;
            // 
            // picNuvemSol
            // 
            this.picNuvemSol.BackColor = System.Drawing.Color.Transparent;
            this.picNuvemSol.Image = global::flappy_jet.Properties.Resources.sol_nuvem;
            this.picNuvemSol.Location = new System.Drawing.Point(169, 26);
            this.picNuvemSol.Name = "picNuvemSol";
            this.picNuvemSol.Size = new System.Drawing.Size(163, 72);
            this.picNuvemSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNuvemSol.TabIndex = 3;
            this.picNuvemSol.TabStop = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCanoBaixo);
            this.Controls.Add(this.picCanoCima);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.pic_chao);
            this.Controls.Add(this.pic_jet);
            this.Controls.Add(this.picNuvemSol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Flappy Jet";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.frmJogo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picCanoBaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoCima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuvemSol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_jet;
        private System.Windows.Forms.PictureBox pic_chao;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.PictureBox picCanoCima;
        private System.Windows.Forms.PictureBox picCanoBaixo;
        private System.Windows.Forms.PictureBox picNuvemSol;
    }
}

