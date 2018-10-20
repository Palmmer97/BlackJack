using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAlejandroLopezGarcia16210545
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso CartitaCom = new Proceso();
            Stack MazoDeCartas = new Stack();
            Stack Jugador = new Stack();
            ArrayList Num = new ArrayList();
            Random Aleatorio = new Random();
            CartitaCom.CartasEnLlenado(Num);
            CartitaCom.IncioJuego();
            CartitaCom.Barajear(Num, MazoDeCartas, Aleatorio);
            CartitaCom.EntregarCartas(Num, Aleatorio);
            CartitaCom.Preguntas(CartitaCom, Num, Aleatorio);
            CartitaCom.SumaDeCartas(Jugador, Num);
            Console.ReadKey();
        }
    }
}
