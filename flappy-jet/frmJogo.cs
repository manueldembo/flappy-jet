using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace flappy_jet
{
    public partial class frmJogo : Form
    {
        int gravidade = 10;
        int velociade = 5;
        int pontuacao = 0;
        long saldo = 0;
        int[] pontuacoes;
        operacoes ope = new operacoes();
        public frmJogo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            ope.CriarPastaFicheiro();
            pontuacoes = ope.LerPontuacoes();
            saldo = ope.LerSaldo();

            AtribuirDadosConfiguracao();
            tempo.Start();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravidade = 10;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravidade = -10;
        }
        Random rd = new Random();
        private void tempo_Tick(object sender, EventArgs e)
        {
            if (pic_jet.Top > -10)
                pic_jet.Top += gravidade;

            picCanoBaixo.Left -= velociade;
            picCanoCima.Left -= velociade;
            picNuvemSol.Left -= velociade;
            lblPontuacao.Text = $"Pontuação: {pontuacao}pt";
            //adicionar pontuação
            if (picCanoBaixo.Left < -170)
             {
                int topo = rd.Next(100, 600);
                picCanoBaixo.Left = topo;

                if (picNuvemSol.Left < -170)
                    picNuvemSol.Left = rd.Next(topo + 120, 800);

                pontuacao++; 
            }
            if (picCanoCima.Left < -170) {
                picCanoCima.Left = rd.Next(300, 700);
                pontuacao++;
            }
            if (pic_jet.Bounds.IntersectsWith(picCanoCima.Bounds) || pic_jet.Bounds.IntersectsWith(picCanoBaixo.Bounds) || pic_jet.Bounds.IntersectsWith(pic_chao.Bounds)) {
                tempo.Stop();
                lblPontuacao.Text = "Game Over!!!";
                saldo += pontuacao;
                ope.GravarPontuacoes(pontuacao, pontuacoes);
                ope.GravarSaldo(saldo);
                pontuacao = 0;
                Thread.Sleep(1000);
                this.Close();
            }
            if (pontuacao % 10 == 0 && pontuacao != 0)
                velociade += 2;
        }
        private void frmJogo_Resize(object sender, EventArgs e)
        {
            this.Width = 816;
            this.Height = 489;
        }
        private void AtribuirDadosConfiguracao() {
            int[] config = ope.LerConfiguracoes();

            //aplicar configuracoes

            #region atribuir nave configurada
            switch (config[1]) {
                case 0:
                    pic_jet.Image = Image.FromFile(vars.caminho + vars.padarao[4]);
                    break;
                case 1:
                    pic_jet.Image = Image.FromFile(vars.caminhoExtras + vars.natal[4]);
                    break;
                case 2:
                    pic_jet.Image = Image.FromFile(vars.caminhoExtras + vars.naves[0]);
                    velociade = 10;
                    break;
                case 3:
                    pic_jet.Image = Image.FromFile(vars.caminhoExtras + vars.naves[1]);
                    break;
            }
            #endregion

            #region mudar o meio
            switch (config[0])
            {
                case 1:
                    this.BackColor = Color.LightSkyBlue;
                    pic_chao.Image = Image.FromFile(vars.caminhoExtras + vars.natal[0]);
                    picCanoCima.Image = Image.FromFile(vars.caminhoExtras + vars.natal[1]);
                    picCanoBaixo.Image = Image.FromFile(vars.caminhoExtras + vars.natal[2]);
                    picNuvemSol.Image = Image.FromFile(vars.caminhoExtras + vars.natal[3]);
                    break;
                case 2:
                    this.BackColor = Color.DarkRed;
                    pic_chao.Image = Image.FromFile(vars.caminhoExtras + vars.destruicao[0]);
                    picCanoCima.Image = Image.FromFile(vars.caminhoExtras + vars.destruicao[1]);
                    picCanoBaixo.Image = Image.FromFile(vars.caminhoExtras + vars.destruicao[2]);
                    picNuvemSol.Image = Image.FromFile(vars.caminhoExtras + vars.destruicao[3]);
                    break;
                case 3:
                    this.BackColor = Color.DarkBlue;
                    pic_chao.Image = Image.FromFile(vars.caminhoExtras + vars.espaco[0]);
                    picCanoCima.Image = Image.FromFile(vars.caminhoExtras + vars.espaco[1]);
                    picCanoBaixo.Image = Image.FromFile(vars.caminhoExtras + vars.espaco[2]);
                    picNuvemSol.Image = null;
                    break;
                case 4:
                    this.BackColor = Color.Black;
                    pic_chao.Image = Image.FromFile(vars.caminho + vars.padarao[0]);
                    picCanoCima.Image = Image.FromFile(vars.caminho + vars.padarao[1]);
                    picCanoBaixo.Image = Image.FromFile(vars.caminho + vars.padarao[2]);
                    picNuvemSol.Image = Image.FromFile(vars.caminhoExtras + vars.noite);
                    break;
                default:
                    #region atribuir o meio padrão
                    this.BackColor = Color.LightSkyBlue;
                    pic_chao.Image = Image.FromFile(vars.caminho + vars.padarao[0]);
                    picCanoCima.Image = Image.FromFile(vars.caminho + vars.padarao[1]);
                    picCanoBaixo.Image = Image.FromFile(vars.caminho + vars.padarao[2]);
                    picNuvemSol.Image = Image.FromFile(vars.caminho + vars.padarao[3]);
                    #endregion
                    break;
            }
            #endregion
        }
    }
}
