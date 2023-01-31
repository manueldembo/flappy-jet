using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_jet
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            picComecar.Image = Image.FromFile(vars.comecar);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            operacoes ope = new operacoes();
            ope.CriarPastaFicheiro();
        }

        private void picLoja_Click(object sender, EventArgs e)
        {
            frmLoja f = new frmLoja();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void picComecar_Click(object sender, EventArgs e)
        {
            frmJogo f = new frmJogo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void picPontuacao_Click(object sender, EventArgs e)
        {
            frmPontuacoes f = new frmPontuacoes();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void picPontuacao_MouseEnter(object sender, EventArgs e)
        {
            picPontuacao.Image = Image.FromFile(vars.pontuacaoLuz);
        }

        private void picPontuacao_MouseLeave(object sender, EventArgs e)
        {
            picPontuacao.Image = Image.FromFile(vars.pontuacao);
        }

        private void picComecar_MouseEnter(object sender, EventArgs e)
        {
            picComecar.Image = Image.FromFile(vars.comecarLuz);
        }

        private void picComecar_MouseLeave(object sender, EventArgs e)
        {
            picComecar.Image = Image.FromFile(vars.comecar);
        }

        private void picLoja_MouseEnter(object sender, EventArgs e)
        {
            picLoja.Image = Image.FromFile(vars.lojaLuz);
        }

        private void picLoja_MouseLeave(object sender, EventArgs e)
        {
            picLoja.Image = Image.FromFile(vars.loja);
        }

        private void picOpcoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do jogo?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmConfiguracao f = new frmConfiguracao();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            picConfigucao.Image = Image.FromFile(vars.opcoesLuz);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picConfigucao.Image = Image.FromFile(vars.opcoes);
        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            this.Width = 816;
            this.Height = 489;
        }
    }
}
