namespace flappy_jet
{
    partial class frmLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoja));
            this.label1 = new System.Windows.Forms.Label();
            this.picNatal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.tabelaLoja = new System.Windows.Forms.TableLayoutPanel();
            this.picDestruicao = new System.Windows.Forms.PictureBox();
            this.picEspaco = new System.Windows.Forms.PictureBox();
            this.picNoite = new System.Windows.Forms.PictureBox();
            this.picSonica = new System.Windows.Forms.PictureBox();
            this.pic1900 = new System.Windows.Forms.PictureBox();
            this.lblNatal = new System.Windows.Forms.Label();
            this.lblDestruicao = new System.Windows.Forms.Label();
            this.lblEspaco = new System.Windows.Forms.Label();
            this.lblNoite = new System.Windows.Forms.Label();
            this.lblSonica = new System.Windows.Forms.Label();
            this.lbl1900 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.tabelaLoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDestruicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEspaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1900)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seja bem-vindo a loja!";
            // 
            // picNatal
            // 
            this.picNatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNatal.Image = global::flappy_jet.Properties.Resources.loja_img;
            this.picNatal.Location = new System.Drawing.Point(3, 3);
            this.picNatal.Name = "picNatal";
            this.picNatal.Size = new System.Drawing.Size(97, 49);
            this.picNatal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNatal.TabIndex = 2;
            this.picNatal.TabStop = false;
            this.picNatal.Click += new System.EventHandler(this.picNatal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::flappy_jet.Properties.Resources.estrelas;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picVoltar
            // 
            this.picVoltar.Image = global::flappy_jet.Properties.Resources.voltar;
            this.picVoltar.Location = new System.Drawing.Point(688, 338);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(100, 100);
            this.picVoltar.TabIndex = 3;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.pictureBox3_Click);
            this.picVoltar.MouseEnter += new System.EventHandler(this.picVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.picVoltar_MouseLeave);
            // 
            // tabelaLoja
            // 
            this.tabelaLoja.ColumnCount = 2;
            this.tabelaLoja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.54812F));
            this.tabelaLoja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.45188F));
            this.tabelaLoja.Controls.Add(this.picNatal, 0, 0);
            this.tabelaLoja.Controls.Add(this.picDestruicao, 0, 1);
            this.tabelaLoja.Controls.Add(this.picEspaco, 0, 2);
            this.tabelaLoja.Controls.Add(this.picNoite, 0, 3);
            this.tabelaLoja.Controls.Add(this.picSonica, 0, 4);
            this.tabelaLoja.Controls.Add(this.pic1900, 0, 5);
            this.tabelaLoja.Controls.Add(this.lblNatal, 1, 0);
            this.tabelaLoja.Controls.Add(this.lblDestruicao, 1, 1);
            this.tabelaLoja.Controls.Add(this.lblEspaco, 1, 2);
            this.tabelaLoja.Controls.Add(this.lblNoite, 1, 3);
            this.tabelaLoja.Controls.Add(this.lblSonica, 1, 4);
            this.tabelaLoja.Controls.Add(this.lbl1900, 1, 5);
            this.tabelaLoja.Location = new System.Drawing.Point(193, 107);
            this.tabelaLoja.Name = "tabelaLoja";
            this.tabelaLoja.RowCount = 6;
            this.tabelaLoja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaLoja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaLoja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaLoja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaLoja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaLoja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaLoja.Size = new System.Drawing.Size(478, 331);
            this.tabelaLoja.TabIndex = 4;
            // 
            // picDestruicao
            // 
            this.picDestruicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDestruicao.Image = global::flappy_jet.Properties.Resources.loja_img;
            this.picDestruicao.Location = new System.Drawing.Point(3, 58);
            this.picDestruicao.Name = "picDestruicao";
            this.picDestruicao.Size = new System.Drawing.Size(96, 49);
            this.picDestruicao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDestruicao.TabIndex = 3;
            this.picDestruicao.TabStop = false;
            this.picDestruicao.Click += new System.EventHandler(this.picDestruicao_Click);
            // 
            // picEspaco
            // 
            this.picEspaco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEspaco.Image = global::flappy_jet.Properties.Resources.loja_img;
            this.picEspaco.Location = new System.Drawing.Point(3, 113);
            this.picEspaco.Name = "picEspaco";
            this.picEspaco.Size = new System.Drawing.Size(96, 49);
            this.picEspaco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEspaco.TabIndex = 3;
            this.picEspaco.TabStop = false;
            this.picEspaco.Click += new System.EventHandler(this.picEspaco_Click);
            // 
            // picNoite
            // 
            this.picNoite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNoite.Image = global::flappy_jet.Properties.Resources.loja_img;
            this.picNoite.Location = new System.Drawing.Point(3, 168);
            this.picNoite.Name = "picNoite";
            this.picNoite.Size = new System.Drawing.Size(96, 49);
            this.picNoite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoite.TabIndex = 3;
            this.picNoite.TabStop = false;
            this.picNoite.Click += new System.EventHandler(this.picNoite_Click);
            // 
            // picSonica
            // 
            this.picSonica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSonica.Image = global::flappy_jet.Properties.Resources.loja_img;
            this.picSonica.Location = new System.Drawing.Point(3, 223);
            this.picSonica.Name = "picSonica";
            this.picSonica.Size = new System.Drawing.Size(96, 49);
            this.picSonica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSonica.TabIndex = 3;
            this.picSonica.TabStop = false;
            this.picSonica.Click += new System.EventHandler(this.picSonica_Click);
            // 
            // pic1900
            // 
            this.pic1900.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1900.Image = global::flappy_jet.Properties.Resources.loja_img;
            this.pic1900.Location = new System.Drawing.Point(3, 278);
            this.pic1900.Name = "pic1900";
            this.pic1900.Size = new System.Drawing.Size(96, 50);
            this.pic1900.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1900.TabIndex = 3;
            this.pic1900.TabStop = false;
            this.pic1900.Click += new System.EventHandler(this.pic1900_Click);
            // 
            // lblNatal
            // 
            this.lblNatal.BackColor = System.Drawing.Color.Transparent;
            this.lblNatal.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatal.ForeColor = System.Drawing.Color.White;
            this.lblNatal.Location = new System.Drawing.Point(106, 0);
            this.lblNatal.Name = "lblNatal";
            this.lblNatal.Size = new System.Drawing.Size(369, 52);
            this.lblNatal.TabIndex = 5;
            this.lblNatal.Text = "----------Pacote de natal 500$----------";
            this.lblNatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestruicao
            // 
            this.lblDestruicao.BackColor = System.Drawing.Color.Transparent;
            this.lblDestruicao.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestruicao.ForeColor = System.Drawing.Color.White;
            this.lblDestruicao.Location = new System.Drawing.Point(106, 55);
            this.lblDestruicao.Name = "lblDestruicao";
            this.lblDestruicao.Size = new System.Drawing.Size(369, 52);
            this.lblDestruicao.TabIndex = 5;
            this.lblDestruicao.Text = "----------Pacote destruição 200$----------";
            this.lblDestruicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspaco
            // 
            this.lblEspaco.BackColor = System.Drawing.Color.Transparent;
            this.lblEspaco.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaco.ForeColor = System.Drawing.Color.White;
            this.lblEspaco.Location = new System.Drawing.Point(106, 110);
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Size = new System.Drawing.Size(369, 52);
            this.lblEspaco.TabIndex = 5;
            this.lblEspaco.Text = "----------Pacote do espaço 250$----------";
            this.lblEspaco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoite
            // 
            this.lblNoite.BackColor = System.Drawing.Color.Transparent;
            this.lblNoite.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoite.ForeColor = System.Drawing.Color.White;
            this.lblNoite.Location = new System.Drawing.Point(106, 165);
            this.lblNoite.Name = "lblNoite";
            this.lblNoite.Size = new System.Drawing.Size(369, 52);
            this.lblNoite.TabIndex = 5;
            this.lblNoite.Text = "----------Pacote da noite 200$----------";
            this.lblNoite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSonica
            // 
            this.lblSonica.BackColor = System.Drawing.Color.Transparent;
            this.lblSonica.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonica.ForeColor = System.Drawing.Color.White;
            this.lblSonica.Location = new System.Drawing.Point(106, 220);
            this.lblSonica.Name = "lblSonica";
            this.lblSonica.Size = new System.Drawing.Size(369, 52);
            this.lblSonica.TabIndex = 5;
            this.lblSonica.Text = "----------Nave sónica 300$----------";
            this.lblSonica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1900
            // 
            this.lbl1900.BackColor = System.Drawing.Color.Transparent;
            this.lbl1900.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1900.ForeColor = System.Drawing.Color.White;
            this.lbl1900.Location = new System.Drawing.Point(106, 275);
            this.lbl1900.Name = "lbl1900";
            this.lbl1900.Size = new System.Drawing.Size(369, 52);
            this.lbl1900.TabIndex = 5;
            this.lbl1900.Text = "----------Nave Ano 250 1000$----------";
            this.lbl1900.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(8, 409);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(118, 26);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo atual: 0$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compre alguma coisa e melhore sua experiência neste jogo!";
            // 
            // frmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabelaLoja);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.frmLoja_Load);
            this.Resize += new System.EventHandler(this.frmLoja_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picNatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.tabelaLoja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDestruicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEspaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1900)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picNatal;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.TableLayoutPanel tabelaLoja;
        private System.Windows.Forms.PictureBox picDestruicao;
        private System.Windows.Forms.PictureBox picEspaco;
        private System.Windows.Forms.PictureBox picNoite;
        private System.Windows.Forms.PictureBox picSonica;
        private System.Windows.Forms.PictureBox pic1900;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNatal;
        private System.Windows.Forms.Label lblDestruicao;
        private System.Windows.Forms.Label lblEspaco;
        private System.Windows.Forms.Label lblNoite;
        private System.Windows.Forms.Label lblSonica;
        private System.Windows.Forms.Label lbl1900;
    }
}