using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogica
{
    public class DefinirVencedor
    {
        public int Jogador { get; set; }
        public string RankingJogador { get; set; }
        public int PesoClassificacaoRanking { get; set; }
        public int PesoRanking { get; set; }

        private List<DefinirVencedor> posicaoJogador = new List<DefinirVencedor>();

        public List<DefinirVencedor> PosicaoJogador
        {
            get { return posicaoJogador; }
        }

        public DefinirVencedor() { }

        public DefinirVencedor(DefinirVencedor item)
        {
            Jogador = item.Jogador;
            RankingJogador = item.RankingJogador;
            PesoRanking = item.PesoRanking;
        }

        public void armazenarRankingJogador(DefinirVencedor classificaoJogador)
        {
            if (classificaoJogador.RankingJogador.Equals("High Card")) classificaoJogador.PesoClassificacaoRanking = 1;
            if (classificaoJogador.RankingJogador.Equals("One Pair")) classificaoJogador.PesoClassificacaoRanking = 2;
            if (classificaoJogador.RankingJogador.Equals("Two Pair")) classificaoJogador.PesoClassificacaoRanking = 3;
            if (classificaoJogador.RankingJogador.Equals("Three of a Kind")) classificaoJogador.PesoClassificacaoRanking = 4;
            if (classificaoJogador.RankingJogador.Equals("Straight")) classificaoJogador.PesoClassificacaoRanking = 5;
            if (classificaoJogador.RankingJogador.Equals("Flush")) classificaoJogador.PesoClassificacaoRanking = 6;
            if (classificaoJogador.RankingJogador.Equals("Full House")) classificaoJogador.PesoClassificacaoRanking = 7;
            if (classificaoJogador.RankingJogador.Equals("Four of Kind")) classificaoJogador.PesoClassificacaoRanking = 8;
            if (classificaoJogador.RankingJogador.Equals("Straight Flush")) classificaoJogador.PesoClassificacaoRanking = 9;
            if (classificaoJogador.RankingJogador.Equals("Royal Flush")) classificaoJogador.PesoClassificacaoRanking = 10;

            posicaoJogador.Add(classificaoJogador);
        }

        public string definirJogadorVencedor()
        {
            string resultado = String.Empty;
            int jogadorVencedor = 0;
            foreach (var classificacao in PosicaoJogador.OrderBy(i => i.PesoClassificacaoRanking).OrderBy(i => i.PesoRanking))
            {
                if (PosicaoJogador.Max(i => i.PesoClassificacaoRanking) == classificacao.PesoClassificacaoRanking)
                {
                    //Console.WriteLine("Jogador:" + classificacao.Jogador + " | Ranking: " + classificacao.RankingJogador + " | Peso Hanking: " + classificacao.PesoRanking);
                    jogadorVencedor = classificacao.Jogador;
                }
            }
            resultado = jogadorVencedor.ToString();

            return resultado;
        }
    }
}
