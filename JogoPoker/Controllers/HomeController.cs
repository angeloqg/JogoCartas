using JogoLogica;
using JogoPoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JogoPoker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult RetornaMaoJogadores(string numJogadores)
        {
            Resultado resultado = new Resultado();
            DefinirVencedor vencedor = new DefinirVencedor();

            List<CartaJogador> cartaJogador = new List<CartaJogador>();
            List<Jogo> mao = new List<Jogo>();
            
            if (!String.IsNullOrEmpty(numJogadores))
            {
                int totalJogadores = Convert.ToInt32(numJogadores);
                var jogadores = new DistribuirCartas().distribuirCartasJogadores(totalJogadores);

                for (int i = 1; i <= totalJogadores; i++)
                {

                    foreach(var jogo in jogadores[i - 1])
                    {
                        // -- Armazena as cartas do jogador
                        var carta = new CartaJogador();
                        carta.Carta = jogo.Carta;
                        carta.Naipe = jogo.Naipe;
                        cartaJogador.Add(carta);
                    }

                    var jogoCarta = new Jogo();

                    string rancking = new RankingJogador().classificarMaoJogador(jogadores[i - 1]);

                    // -- Cria o registro da mão de cartas do jogador
                    jogoCarta.Jogador = "Jogador " + i;
                    jogoCarta.Carta1 = cartaJogador[0].Carta + cartaJogador[0].Naipe;
                    jogoCarta.Carta2 = cartaJogador[1].Carta + cartaJogador[1].Naipe;
                    jogoCarta.Carta3 = cartaJogador[2].Carta + cartaJogador[2].Naipe;
                    jogoCarta.Carta4 = cartaJogador[3].Carta + cartaJogador[3].Naipe;
                    jogoCarta.Carta5 = cartaJogador[4].Carta + cartaJogador[4].Naipe;
                    jogoCarta.Ranking = rancking + " [" + jogadores[i - 1].Sum(p => p.Peso) + " pontos]";

                    mao.Add(jogoCarta);

                    vencedor.Jogador = i;
                    vencedor.PesoRanking = jogadores[i - 1].Sum(p => p.Peso);
                    vencedor.RankingJogador = rancking;
                    vencedor.armazenarRankingJogador(new DefinirVencedor(vencedor));

                    cartaJogador.Clear();
                }

                // Armazena o registro de todas as mãos dos jogadores e o resultado final
                resultado.jogadores = mao;
                resultado.resultado = "JOGADOR " + vencedor.definirJogadorVencedor();
            }

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
    }
}