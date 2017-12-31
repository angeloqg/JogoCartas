using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoLogica
{
    public class DistribuirCartas
    {
        public List<List<Cartas>> distribuirCartasJogadores(int numJogador)
        {
            Baralho baralho = new Baralho();
            int tamanho = baralho.Cartas.Count();
            Random aleatorio = new Random();

            var jogadores = new Jogador();
            List<Cartas> naipe = new List<Cartas>();

            if (numJogador >= 2 && numJogador <= 10)
            {

                // -- Representa o total de jogadores na partida (Mínimo de 2 jogadores)
                for (int i = 1; i <= numJogador; i++)
                {

                    // -- Representa o total de cartas selecionadas para cada jogador (5 cartas)
                    for (int c = 1; c <= 5; c++)
                    {
                        // -- Seleciona um índice aleatório
                        int indice = aleatorio.Next(0,tamanho-1);

                        // -- Seleciona carta
                        Cartas item = new Cartas();
                        item.Carta = baralho.Cartas[indice].Carta;
                        item.Naipe = baralho.Cartas[indice].Naipe;
                        item.Peso = baralho.Cartas[indice].Peso;

                        // -- Adiciona a carta ao conjunto de cartas do jogador
                        naipe.Add(item);

                        // -- Remove a carta do baralho principal
                        baralho.Cartas.RemoveAt(indice);

                        // -- Atualiza o total de cartas disponíveis para escolha
                        tamanho = baralho.Cartas.Count();
                    }

                    // -- Adiciona a carta ao jogador
                    jogadores.setJogador(new List<Cartas>(naipe));

                    // -- Libera o objeto para receber novas cartas para o próximo jogador
                    naipe.Clear();
                }
            }

            return jogadores.Cartas;
        }
    }
}
