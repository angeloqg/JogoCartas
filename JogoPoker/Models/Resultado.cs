using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JogoPoker.Models
{
    public class Resultado
    {
        public List<Jogo> jogadores { get; set; }
        public string resultado { get; set; }
    }
}