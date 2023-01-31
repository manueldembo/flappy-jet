namespace flappy_jet
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picComecar = new System.Windows.Forms.PictureBox();
            this.picLoja = new System.Windows.Forms.PictureBox();
            this.picPontuacao = new System.Windows.Forms.PictureBox();
            this.picConfigucao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPontuacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigucao)).BeginInit();
            this.SuspendLayout();
            // 
            // picComecar
            // 
            this.picComecar.BackColor = System.Drawing.Color.Transparent;
            this.picComecar.Image = global::flappy_jet.Properties.Resources.comecar;
            this.picComecar.Location = new System.Drawing.Point(333, 130);
            this.picComecar.Name = "picComecar";
            this.picComecar.Size = new System.Drawing.Size(133, 133);
            this.picComecar.TabIndex = 0;
            this.picComecar.TabStop = false;
            this.picComecar.Click += new System.EventHandler(this.picComecar_Click);
            this.picComecar.MouseEnter += new System.EventHandler(this.picComecar_MouseEnter);
            this.picComecar.MouseLeave += new System.EventHandler(this.picComecar_MouseLeave);
            // 
            // picLoja
            // 
            this.picLoja.BackColor = System.Drawing.Color.Transparent;
            this.picLoja.Image = global::flappy_jet.Properties.Resources.loja;
            this.picLoja.Location = new System.Drawing.Point(465, 269);
            this.picLoja.Name = "picLoja";
            this.picLoja.Size = new System.Drawing.Size(115, 115);
            this.picLoja.TabIndex = 0;
            this.picLoja.TabStop = false;
            this.picLoja.Click += new System.EventHandler(this.picLoja_Click);
            this.picLoja.MouseEnter += new System.EventHandler(this.picLoja_MouseEnter);
            this.picLoja.MouseLeave += new System.EventHandler(this.picLoja_MouseLeave);
            // 
            // picPontuacao
            // 
            this.picPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.picPontuacao.Image = global::flappy_jet.Properties.Resources.pontuacao;
            this.picPontuacao.Location = new System.Drawing.Point(219, 269);
            this.picPontuacao.Name = "picPontuacao";
            this.picPontuacao.Size = new System.Drawing.Size(115, 115);
            this.picPontuacao.TabIndex = 0;
            this.picPontuacao.TabStop = false;
            this.picPontuacao.Click += new System.EventHandler(this.picPontuacao_Click);
            this.picPontuacao.MouseEnter += new System.EventHandler(this.picPontuacao_MouseEnter);
            this.picPontuacao.MouseLeave += new System.EventHandler(this.picPontuacao_MouseLeave);
            // 
            // picConfigucao
            // 
            this.picConfigucao.BackColor = System.Drawing.Color.Transparent;
            this.picConfigucao.Image = global::flappy_jet.Properties.Resources.opcoes;
            this.picConfigucao.Location = new System.Drawing.Point(343, 269);
            this.picConfigucao.Name = "picConfigucao";
            this.picConfigucao.Size = new System.Drawing.Size(115, 115);
            this.picConfigucao.TabIndex = 1;
            this.picConfigucao.TabStop = false;
            this.picConfigucao.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picConfigucao.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.picConfigucao.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappy_jet.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picConfigucao);
            this.Controls.Add(this.picPontuacao);
            this.Controls.Add(this.picLoja);
            this.Controls.Add(this.picComecar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLAPPY-JET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.picOpcoes_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Resize += new System.EventHandler(this.frmMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picComecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPontuacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picComecar;
        private System.Windows.Forms.PictureBox picLoja;
        private System.Windows.Forms.PictureBox picPontuacao;
        private System.Windows.Forms.PictureBox picConfigucao;
    }
}