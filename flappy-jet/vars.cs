using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flappy_jet
{
    internal static class vars
    {
        public static string caminho = Environment.CurrentDirectory + @"\_imagens\";
        public static string caminhoExtras = caminho + @"_extras\";

        //caminho dos botãos
        public static string comecar = caminho + "comecar.png";
        public static string comecarLuz = caminho + "comecar-luz.png";
        public static string loja = caminho + "loja.png";
        public static string lojaLuz = caminho + "loja-luz.png";
        public static string pontuacao = caminho + "pontuacao.png";
        public static string pontuacaoLuz = caminho + "pontuacao-luz.png";
        public static string voltar = caminho + "voltar.png";
        public static string voltarLuz = caminho + "voltar-luz.png";
        public static string opcoes = caminho + "opcoes.png";
        public static string opcoesLuz = caminho + "opcoes-luz.png";

        //caminhos padrão
        public static string[] padarao = { "chao.png", "cano-baixo.png", "cano-cima.png", "sol-nuvem.png", "nave.png" };

        //caminhos extras
        //destruicao
        public static string[] destruicao =  { @"_destruicao\chao-pico.png", @"\_destruicao\cano-destruicao-baixo.png", @"_destruicao\cano-destruicao-cima.png", @"_destruicao\nuvem.png" };
        //espaco
        public static string[] espaco = {@"_espaco\chao-meteoro.png", @"_espaco\cano-espaco-baixo.png", @"_espaco\cano-espaco-cima.png" };
        //natal
        public static string[] natal = { @"_natal\chao-natal-baixo.png", @"_natal\cano-neve-baixo.png", @"_natal\cano-neve-cima.png", @"_natal\nuvem.png", @"_natal\nave-natal.png" };
        //noite
        public static string noite = @"_noite\lua.png"; 
        //naves
        public static string[] naves = { @"_navez\nave-veloz.png", @"_navez\nave-cinza.png" };  
    }
}
