using System.Collections.Generic;

namespace JogoLogica
{
    public class Jogador
    {
        private List<List<Cartas>> cartas = new List<List<Cartas>>();
        public List<List<Cartas>> Cartas
        {
            get { return cartas; }
        }

        public void setJogador(List<Cartas> baralho)
        {
            cartas.Add(baralho);
        }
    }
}
