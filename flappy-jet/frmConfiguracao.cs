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
    public partial class frmConfiguracao : Form
    {
        int[] compras;
        int[] config;
        operacoes ope = new operacoes();
        public frmConfiguracao()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            compras = ope.LerCompras();
            config = ope.LerConfiguracoes();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            #region Atribuir dados as combobox
            cmbMusica.Text = cmbMusica.Items[0].ToString();
            cmbNave.Items.Add("---Nave padrão---");
            cmbNave.Text = "---Nave padrão---";
            foreach (int compra in compras)
            {
                if (compra != 5 && compra != 6)
                {
                    switch (compra)
                    {
                        case 1:
                            cmbPacotes.Items.Add("---Pacote de natal---");
                            cmbNave.Items.Add("---Nave de Natal---");
                            break;
                        case 2:
                            cmbPacotes.Items.Add("---Pacote destruição---");
                            break;
                        case 3:
                            cmbPacotes.Items.Add("---Pacote do espaço---");
                            break;
                        case 4:
                            cmbPacotes.Items.Add("---Pacote da naite---");
                            break;
                    }
                    cmbPacotes.Text = cmbPacotes.Items[0].ToString();
                }
                else
                    if (compra == 5)
                    cmbNave.Items.Add("---Nave sónica---");
                else
                    cmbNave.Items.Add("---Nave 1900---");
            }
            #endregion

            ApresentarConfiguracoesSalvas();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            int indexPacote = 0;
            int indexNave = 0;

            #region selecionar daos a serem gravados
            if (rdPacotes.Checked)
            {
                switch (cmbPacotes.Text)
                {
                    case "---Pacote de natal---":
                        indexPacote = 1;
                        break;
                    case "---Pacote destruição---":
                        indexPacote = 2;
                        break;
                    case "---Pacote do espaço---":
                        indexPacote = 3;
                        break;
                    case "---Pacote da naite---":
                        indexPacote = 4;
                        break;
                }
            }

            switch (cmbNave.Text)
            {
                case "---Nave de Natal---":
                    indexNave = 1;
                    break;
                case "---Nave sónica---":
                    indexNave = 2;
                    break;
                case "---Nave 1900---":
                    indexNave = 3;
                    break;
            }
            #endregion

            //gravar dados de configuracao
            ope.GravarConfiguracoes(indexPacote, indexNave);

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

        private void frmConfiguracao_Resize(object sender, EventArgs e)
        {
            this.Width = 816;
            this.Height = 489;
        }

        private void rdPacotes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPacotes.Checked)
                cmbPacotes.Enabled = true;
            else
                cmbPacotes.Enabled = false;
        }

        private void ApresentarConfiguracoesSalvas() {
            if (config[0] == 0)
                rdPadrao.Checked = true;
            else
            {
                rdPacotes.Checked = true;
                cmbPacotes.Text = cmbPacotes.Items[config[0]-1].ToString();
            }
            cmbNave.Text = cmbNave.Items[config[1]].ToString();
        }

        private void cmbMusica_TextChanged(object sender, EventArgs e)
        {
            if (cmbMusica.Text == cmbMusica.Items[1].ToString())
                ope.Tocar(true);
            else
                ope.Tocar(false);
        }
    }
}
