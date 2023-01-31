using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace flappy_jet
{
    internal class operacoes
    {
        string caminhoPasta = Environment.CurrentDirectory + @"\_arquivos\";
        string caminhoFicheiroPontucao = "pontucao.txt";
        string caminhoFicheiroSaldo = "saldo.txt";
        string caminhoFicheiroCompra = "compra.txt";
        string caminhoFicheiroConfiguracao = "configuracao.txt";
        string caminhoMusica = Environment.CurrentDirectory + @"\_musicas\";
        static SoundPlayer player = new SoundPlayer();

        public void CriarPastaFicheiro() {
            if (!Directory.Exists(caminhoPasta)) {
                Directory.CreateDirectory(caminhoPasta);
                File.CreateText(caminhoPasta + caminhoFicheiroPontucao).Close();
                File.CreateText(caminhoPasta + caminhoFicheiroSaldo).Close();
                File.CreateText(caminhoPasta + caminhoFicheiroCompra).Close();
                File.CreateText(caminhoPasta + caminhoFicheiroConfiguracao).Close();
            }
        }
        public int[] LerPontuacoes() {
            int[] pontuacoes = new int[3];
            int index = 0;
            try {
                StreamReader sr = new StreamReader(caminhoPasta + caminhoFicheiroPontucao);

                while (!sr.EndOfStream)
                    pontuacoes[index++] = int.Parse(sr.ReadLine());

                sr.Close();
                Array.Sort(pontuacoes);
            }
            catch { }

            return pontuacoes;

        }
        public void GravarPontuacoes(int pontuacao, int[] pontuacoes) {
            int[] pontuacoesR = OrdenarPontuacoes(pontuacao, pontuacoes);

            try
            {
                StreamWriter sw = new StreamWriter(caminhoPasta + caminhoFicheiroPontucao, false);

                for (int i = 0; i < pontuacoes.GetLength(0); i++)
                    sw.WriteLine(pontuacoes[i]);

                sw.Close();
            }
            catch {
                CriarPastaFicheiro();
            }
        }
        private int[] OrdenarPontuacoes(int pontuacao, int[] pontuacoes) {
            if (pontuacao > pontuacoes[0])
                pontuacoes[0] = pontuacao;
            Array.Sort(pontuacoes);
            return pontuacoes;
        }
        public void GravarSaldo(long saldo) {
            try
            {
                StreamWriter sw = new StreamWriter(caminhoPasta + caminhoFicheiroSaldo, false);
                sw.WriteLine(saldo);
                sw.Close();
            }
            catch {
                CriarPastaFicheiro();
            }
        }
        public long LerSaldo() {
            long saldo = 0;
            try {
                StreamReader sr = new StreamReader(caminhoPasta + caminhoFicheiroSaldo);
                saldo = long.Parse(sr.ReadLine());
                sr.Close();
            } catch { }

            return saldo;
        }
        public void GravarCompras(int numCompra) {
            try
            {
                StreamWriter sw = new StreamWriter(caminhoPasta + caminhoFicheiroCompra, true);
                sw.WriteLine(numCompra);
                sw.Close();
            }
            catch {
                CriarPastaFicheiro();
                MessageBox.Show("Os dados da compra não foram gravados.");
            }
        }
        public int[] LerCompras() {
            int[] compras = new int[ContarElementos()];
            int index = 0;

            try
            {
                StreamReader sr = new StreamReader(caminhoPasta + caminhoFicheiroCompra);

                while (!sr.EndOfStream)
                    compras[index++] = int.Parse(sr.ReadLine());

                sr.Close();
            }
            catch {
            }

            return compras;
        }
        private int ContarElementos() {
            int elementos = 0;

            try
            {
                StreamReader sr = new StreamReader(caminhoPasta + caminhoFicheiroCompra);

                while (!sr.EndOfStream) {
                    sr.ReadLine();
                    elementos++;
                }
                sr.Close();
            }
            catch {
            }

            return elementos;
        }
        public void GravarConfiguracoes(int indexPacote, int indexNave) {
            try {
                StreamWriter sw = new StreamWriter(caminhoPasta + caminhoFicheiroConfiguracao, false);

                sw.WriteLine(indexPacote);
                sw.WriteLine(indexNave);

                sw.Close();
            }
            catch {
                CriarPastaFicheiro();
            }
        }
        public int[] LerConfiguracoes() {
            int[] config = new int[2];

            try {
                StreamReader sr = new StreamReader(caminhoPasta + caminhoFicheiroConfiguracao);

                while (!sr.EndOfStream) {
                    config[0] = int.Parse(sr.ReadLine());
                    config[1] = int.Parse(sr.ReadLine());
                }

                sr.Close();
            }
            catch { }

            return config;
        }
        public void Tocar(bool estado) {
            if (!estado) {
                player.Stop();
                return;
            }

            player.SoundLocation = caminhoMusica + "Toque4.wav";
            player.PlayLooping();
        }
    }
}
