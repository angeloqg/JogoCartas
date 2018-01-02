using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoLogica
{
    public class RankingJogador
    {
        public string classificarMaoJogador(List<Cartas> cartasJogador)
        {
            string ranking = String.Empty;

            int ouros = 0;
            int paus = 0;
            int espadas = 0;
            int copas = 0;
            int totalPesos = 0;

            // -- 1º) Analisar se existe jogador com mão do mesmo naipe
            foreach (var cartas in cartasJogador.OrderBy(i => i.Peso))
            {

                if (cartas.Naipe.Equals("ouros"))
                    ouros++;

                if (cartas.Naipe.Equals("copas"))
                    copas++;

                if (cartas.Naipe.Equals("espadas"))
                    espadas++;

                if (cartas.Naipe.Equals("paus"))
                    paus++;
            }


            // -- Analisa conjunto de cartas do mesmo Naipe
            if (ouros == 5 || copas == 5 || espadas == 5 || paus == 5)
            {
                int pesoAux = 0;

                bool sequencia = true;

                foreach (var cartas in cartasJogador.OrderBy(i => i.Peso))
                {
                    totalPesos += cartas.Peso;

                    if (sequencia)
                    {
                        if (pesoAux == 0)
                        {
                            pesoAux = cartas.Peso;
                        }
                        else
                        {
                            if ((cartas.Peso - pesoAux) == 1)
                                pesoAux = cartas.Peso;
                            else
                                sequencia = false;
                        }
                    }
                }

                totalPesos = totalPesos / 5;

                if (totalPesos >= 3 && totalPesos <= 6 && sequencia == true)
                    ranking = "Straight Flush";

                if (totalPesos == 11 && sequencia == true)
                    ranking = "Royal Flush";

                if (sequencia == false)
                    ranking = "Flush";
            }
            else
            {
                string[] cartas = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei", "As" };
                int conjuntos = 0;
                int totalCartasConjunto = 0;

                int pesoAux = 0;
                bool sequencia = true;


                // -- 2º)Analisa conjunto de cartas do Naipes diferentes
                for (int c = 0; c < 13; c++)
                {
                    if (cartasJogador.OrderBy(i => i.Carta).Count(i => i.Carta.Equals(cartas[c])) > 1)
                    {
                        conjuntos++;
                        totalCartasConjunto += cartasJogador.OrderBy(i => i.Carta).Count(i => i.Carta.Equals(cartas[c]));
                    }
                }

                if (conjuntos == 0)
                {
                    foreach (var nSequencia in cartasJogador)
                    {
                        if (sequencia)
                        {
                            if (pesoAux == 0)
                            {
                                pesoAux = nSequencia.Peso;
                            }
                            else
                            {
                                if ((nSequencia.Peso - pesoAux) == 1 || (nSequencia.Peso - pesoAux) == -1)
                                    pesoAux = nSequencia.Peso;
                                else
                                    sequencia = false;
                            }
                        }
                    }
                }

                if (conjuntos == 0 && sequencia)
                    ranking = "Straight";
                else if (conjuntos == 0 && sequencia == false)
                    ranking = "High Card";

                if (conjuntos == 1 && totalCartasConjunto == 2)
                    ranking = "One Par";

                if (conjuntos == 1 && totalCartasConjunto == 3)
                    ranking = "Three of a Kind";

                if (conjuntos == 1 && totalCartasConjunto == 4)
                    ranking = "Four of Kind";

                if (conjuntos == 2 && totalCartasConjunto == 5)
                    ranking = "Full House";

                if (conjuntos == 2 && totalCartasConjunto == 4)
                    ranking = "Two Pair";
            }
            return ranking;

        }
    }
}
