using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JogoPoker.Models
{
    public class Jogo
    {
        public string Jogador { get; set; }
        public string Carta1 { get; set; }
        public string Carta2 { get; set; }
        public string Carta3 { get; set; }
        public string Carta4 { get; set; }
        public string Carta5 { get; set; }
        public string Ranking { get; set; }
    }
}