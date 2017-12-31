namespace JogoLogica
{
    public class Cartas
    {
        public string Naipe { get; set; }
        public string Carta { get; set; }
        public int Peso { get; set; }

        public Cartas() { }

        public Cartas(Cartas carta)
        {
            Naipe = carta.Naipe;
            Carta = carta.Carta;
            Peso = carta.Peso;
        }
    }
}
