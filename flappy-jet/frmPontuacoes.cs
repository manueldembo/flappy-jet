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
    public partial class frmPontuacoes : Form
    {
        int[] pontuacoes;
        public frmPontuacoes()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            operacoes ope = new operacoes();
            pontuacoes = ope.LerPontuacoes();
        }

        private void frmPontuacoes_Load(object sender, EventArgs e)
        {
            lblPrimeiro.Text = $"---------{pontuacoes[2]}pt---------";
            lblSegundo.Text = $"---------{pontuacoes[1]}pt---------";
            lblTerceiro.Text = $"---------{pontuacoes[0]}pt---------";
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picVoltar_MouseEnter(object sender, EventArgs e)
        {
            picVoltar.Image = Image.FromFile(vars.voltarLuz);
        }

        private void picVoltar_MouseLeave(object sender, EventArgs e)
        {
            picVoltar.Image = Image.FromFile(vars.voltar);
        }

        private void frmPontuacoes_Resize(object sender, EventArgs e)
        {
            this.Width = 816;
            this.Height = 489;
        }
    }
}
