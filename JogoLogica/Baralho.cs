using System.Collections.Generic;

namespace JogoLogica
{
    public class Baralho
    {
        private List<Cartas> cartas = new List<Cartas>();

        public List<Cartas> Cartas
        {
            get { return cartas; }
            set { cartas = value; }
        }

        public Baralho()
        {
            cartas.Add(new Cartas { Carta = "2", Naipe = "ouros", Peso = 1 });
            cartas.Add(new Cartas { Carta = "3", Naipe = "ouros", Peso = 2 });
            cartas.Add(new Cartas { Carta = "4", Naipe = "ouros", Peso = 3 });
            cartas.Add(new Cartas { Carta = "5", Naipe = "ouros", Peso = 4 });
            cartas.Add(new Cartas { Carta = "6", Naipe = "ouros", Peso = 5 });
            cartas.Add(new Cartas { Carta = "7", Naipe = "ouros", Peso = 6 });
            cartas.Add(new Cartas { Carta = "8", Naipe = "ouros", Peso = 7 });
            cartas.Add(new Cartas { Carta = "9", Naipe = "ouros", Peso = 8 });
            cartas.Add(new Cartas { Carta = "10", Naipe = "ouros", Peso = 9 });
            cartas.Add(new Cartas { Carta = "valete", Naipe = "ouros", Peso = 10 });
            cartas.Add(new Cartas { Carta = "dama", Naipe = "ouros", Peso = 11 });
            cartas.Add(new Cartas { Carta = "rei", Naipe = "ouros", Peso = 12 });
            cartas.Add(new Cartas { Carta = "as", Naipe = "ouros", Peso = 13 });
            cartas.Add(new Cartas { Carta = "2", Naipe = "paus", Peso = 1 });
            cartas.Add(new Cartas { Carta = "3", Naipe = "paus", Peso = 2 });
            cartas.Add(new Cartas { Carta = "4", Naipe = "paus", Peso = 3 });
            cartas.Add(new Cartas { Carta = "5", Naipe = "paus", Peso = 4 });
            cartas.Add(new Cartas { Carta = "6", Naipe = "paus", Peso = 5 });
            cartas.Add(new Cartas { Carta = "7", Naipe = "paus", Peso = 6 });
            cartas.Add(new Cartas { Carta = "8", Naipe = "paus", Peso = 7 });
            cartas.Add(new Cartas { Carta = "9", Naipe = "paus", Peso = 8 });
            cartas.Add(new Cartas { Carta = "10", Naipe = "paus", Peso = 9 });
            cartas.Add(new Cartas { Carta = "valete", Naipe = "paus", Peso = 10 });
            cartas.Add(new Cartas { Carta = "dama", Naipe = "paus", Peso = 11 });
            cartas.Add(new Cartas { Carta = "rei", Naipe = "paus", Peso = 12 });
            cartas.Add(new Cartas { Carta = "as", Naipe = "paus", Peso = 13 });
            cartas.Add(new Cartas { Carta = "2", Naipe = "espadas", Peso = 1 });
            cartas.Add(new Cartas { Carta = "3", Naipe = "espadas", Peso = 2 });
            cartas.Add(new Cartas { Carta = "4", Naipe = "espadas", Peso = 3 });
            cartas.Add(new Cartas { Carta = "5", Naipe = "espadas", Peso = 4 });
            cartas.Add(new Cartas { Carta = "6", Naipe = "espadas", Peso = 5 });
            cartas.Add(new Cartas { Carta = "7", Naipe = "espadas", Peso = 6 });
            cartas.Add(new Cartas { Carta = "8", Naipe = "espadas", Peso = 7 });
            cartas.Add(new Cartas { Carta = "9", Naipe = "espadas", Peso = 8 });
            cartas.Add(new Cartas { Carta = "10", Naipe = "espadas", Peso = 9 });
            cartas.Add(new Cartas { Carta = "valete", Naipe = "espadas", Peso = 10 });
            cartas.Add(new Cartas { Carta = "dama", Naipe = "espadas", Peso = 11 });
            cartas.Add(new Cartas { Carta = "rei", Naipe = "espadas", Peso = 12 });
            cartas.Add(new Cartas { Carta = "as", Naipe = "espadas", Peso = 13 });
            cartas.Add(new Cartas { Carta = "2", Naipe = "copas", Peso = 1 });
            cartas.Add(new Cartas { Carta = "3", Naipe = "copas", Peso = 2 });
            cartas.Add(new Cartas { Carta = "4", Naipe = "copas", Peso = 3 });
            cartas.Add(new Cartas { Carta = "5", Naipe = "copas", Peso = 4 });
            cartas.Add(new Cartas { Carta = "6", Naipe = "copas", Peso = 5 });
            cartas.Add(new Cartas { Carta = "7", Naipe = "copas", Peso = 6 });
            cartas.Add(new Cartas { Carta = "8", Naipe = "copas", Peso = 7 });
            cartas.Add(new Cartas { Carta = "9", Naipe = "copas", Peso = 8 });
            cartas.Add(new Cartas { Carta = "10", Naipe = "copas", Peso = 9 });
            cartas.Add(new Cartas { Carta = "valete", Naipe = "copas", Peso = 10 });
            cartas.Add(new Cartas { Carta = "dama", Naipe = "copas", Peso = 11 });
            cartas.Add(new Cartas { Carta = "rei", Naipe = "copas", Peso = 12 });
            cartas.Add(new Cartas { Carta = "as", Naipe = "copas", Peso = 13 });
        }
    }
}
