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
    public partial class frmLoja : Form
    {
        long saldo = 0;
        int[] compras;
        operacoes ope = new operacoes();
        public frmLoja()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            saldo = ope.LerSaldo();
            lblSaldo.Text = $"Saldo atual: {saldo}$";
            compras = ope.LerCompras();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void picNatal_Click(object sender, EventArgs e)
        {
            int preco = 500;
            int pos = 1;

            if (saldo < preco)
                MessageBox.Show("Saldo insuficiente.");
            else
            {
                saldo -= preco;
                ope.GravarSaldo(saldo);
                lblNatal.Text = "---------Comprado!!!---------";
                ope.GravarCompras(pos);
                MessageBox.Show("Compra efectuada com sucesso!");
            }
        }

        private void picDestruicao_Click(object sender, EventArgs e)
        {
            int preco = 200;
            int pos = 2;

            if (saldo < preco)
                MessageBox.Show("Saldo insuficiente.");
            else
            {
                saldo -= preco;
                ope.GravarSaldo(saldo);
                ope.GravarCompras(pos);
                lblDestruicao.Text = "---------Comprado!!!---------";
                MessageBox.Show("Compra efectuada com sucesso!");
            }
        }

        private void picEspaco_Click(object sender, EventArgs e)
        {
            int preco = 250;
            int pos = 3;

            if (saldo < preco)
                MessageBox.Show("Saldo insuficiente.");
            else
            {
                saldo -= preco;
                ope.GravarSaldo(saldo);
                ope.GravarCompras(pos);
                lblEspaco.Text = "---------Comprado!!!---------";
                MessageBox.Show("Compra efectuada com sucesso!");
            }
        }

        private void picNoite_Click(object sender, EventArgs e)
        {
            int preco = 200;
            int pos = 4;

            if (saldo < preco)
                MessageBox.Show("Saldo insuficiente.");
            else
            {
                saldo -= preco;
                ope.GravarSaldo(saldo);
                ope.GravarCompras(pos);
                lblNoite.Text = "---------Comprado!!!---------";
                MessageBox.Show("Compra efectuada com sucesso!");
            }
        }

        private void picSonica_Click(object sender, EventArgs e)
        {
            int preco = 300;
            int pos = 5;

            if (saldo < preco)
                MessageBox.Show("Saldo insuficiente.");
            else
            {
                saldo -= preco;
                ope.GravarSaldo(saldo);
                ope.GravarCompras(pos);
                lblSonica.Text = "---------Comprado!!!---------";
                MessageBox.Show("Compra efectuada com sucesso!");
            }
        }

        private void pic1900_Click(object sender, EventArgs e)
        {
            int preco = 250;
            int pos = 6;

            if (saldo < preco)
                MessageBox.Show("Saldo insuficiente.");
            else
            {
                saldo -= preco;
                ope.GravarSaldo(saldo);
                ope.GravarCompras(pos);   
                lbl1900.Text = "---------Comprado!!!---------";
                MessageBox.Show("Compra efectuada com sucesso!");
            }
        }

        private void frmLoja_Load(object sender, EventArgs e)
        {
            MarcarComprados();
        }

        private void MarcarComprados() {
            for (int i = 0; i < compras.GetLength(0); i++)
            {
                switch (compras[i]) {
                    case 1:
                        lblNatal.Text = "---------Comprado!!!---------";
                        break;
                    case 2:
                        lblDestruicao.Text = "---------Comprado!!!---------";
                        break;
                    case 3:
                        lblEspaco.Text = "---------Comprado!!!---------";
                        break;
                    case 4:
                        lblNoite.Text = "---------Comprado!!!---------";
                        break;
                    case 5:
                        lblSonica.Text = "---------Comprado!!!---------";
                        break;
                    case 6:
                        lbl1900.Text = "---------Comprado!!!---------";
                        break;
                }
            }
        }

        private void frmLoja_Resize(object sender, EventArgs e)
        {
            this.Width = 816;
            this.Height = 489;
        }
    }
}
