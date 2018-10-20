using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAlejandroLopezGarcia16210545
{
    class Proceso
    {
        // Inicio del juego e pidiendo un nombre de usuario 
        public void IncioJuego()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("BlackJackDEMO");
            Console.WriteLine();
            Console.WriteLine("Usuario:\n ");

            Console.WriteLine("--------------");
            string Usuari = Console.ReadLine();
            Console.WriteLine("--------------");
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bienvenido{0} ", Usuari, "Incio del Juego");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Favor de Presionar una tecla a lazar  ");
            Console.WriteLine("------------------------------------------");
            Console.ReadKey();
            Console.WriteLine();
        }
        // Llenando las cartas 
        public void CartasEnLlenado(ArrayList Num)
        {
            for (int i = 0; i < 11; i++)
            {
                if (i == 1)
                {
                    Num.Add("Picas" + "A");
                }
                else
                {
                    Num.Add("Picas" + i);
                }
                if (i == 10)
                {
                    Num.Add("Picas" + "J");
                    Num.Add("Picas" + "Q");
                    Num.Add("Picas" + "K");

                }                
            }
            for (int i = 0; i < 11; i++)
            {
                if (i == 1)
                {
                    Num.Add("Corazones" + "A");
                }
                else
                {
                    Num.Add("Corazones" + i);
                }
                if (i == 10)
                {
                    Num.Add("Corazones" + "J");
                    Num.Add("Corazones" + "Q");
                    Num.Add("Corazones" + "K");

                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (i == 1)
                {
                    Num.Add("Trebol" + "A");
                }
                else
                {
                    Num.Add("Trebol" + i);
                }
                if (i == 10)
                {
                    Num.Add("Trebol" + "J");
                    Num.Add("Trebol" + "Q");
                    Num.Add("Trebol" + "K");

                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (i == 1)
                {
                    Num.Add("Rombo" + "A");
                }
                else
                {
                    Num.Add("Rombo" + i);
                }
                if (i == 10)
                {
                    Num.Add("Rombo" + "J");
                    Num.Add("Rombo" + "Q");
                    Num.Add("Rombo" + "K");

                }
            }
        }
        // Pasando DE Lista a Plias para llenarse la pila 
        public void DeListasAPilas(ArrayList Num, Stack BarajaCom)
        {
            for (int i = 0; i < Num.Count; i++)
            {
                object Cartita = Num[i];
                BarajaCom.Push(Cartita);
            }

        }
        // Se Barajean las cartas 
        public void Barajear(ArrayList Num, Stack MazoDeCartas,Random Aleatorio)
        {
            for (int i = 0; i < 52; i++)
			{
                int Variable = Aleatorio.Next(0, Num.Count);
                MazoDeCartas.Push(Num[Variable]);
                Num.RemoveAt(Variable);
			}
        }
        // Se Reparten las cartas 
        public void RepartirLasCartas(ArrayList Num, Random Aleatorio)
        {
            Console.WriteLine("Se le entregan sus dos cartas \n");
            int Variable = Aleatorio.Next(0, Num.Count);
            Console.WriteLine(Num[Variable]);
            Num.RemoveAt(Variable);
            Console.WriteLine("(?)\n");
        }
        // Se Entregan las cartas al usuario 
        public void EntregarCartas(ArrayList Num, Random Aleatorio)
        {

            int Variable = Aleatorio.Next(0, Num.Count);
            Console.WriteLine(Num[Variable]);
            Num.RemoveAt(Variable);
        }
        // Se Suman las dos cartas del usuario 
        public void SumaDeCartas(Stack Jugador,ArrayList Num)
        {
            int Result = 0;
            List<int> Suma = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                object Carta = Num[i];
                Jugador.Push(Carta);
            }
            for (int i = 0; i < 2; i++)
            {
                
                Suma.Add(Convert.ToInt32(Jugador.Pop()));
                Jugador.Pop();
            }
            foreach (var item in Suma)
            {
                Result = item + Result;
            }
            Console.WriteLine("La Suma de sus cartas es: {0}", Result);

        }

        // Se Pregunta al usuario si quiere mas cartas 
        public void Preguntas(Proceso Baraja, ArrayList Num, Random Aleatorio)
        {
        inicio:
            Console.WriteLine("-------------------");
            Console.WriteLine("¿Quiere otra carta?");
            Console.WriteLine(" 1.si \n 2.no ");
            Console.WriteLine("-------------------");
            string Eso = Console.ReadLine().ToUpper();
            if (Eso == "si"|| Eso == "1")
            {
                Baraja.EntregarCartas(Num, Aleatorio);
                goto inicio;
            }
            else
                if (Eso == "no"|| Eso == "2")
                {
                    Console.WriteLine("Sus cartas sumadas son: ");
                }
                else
                {
                    Console.WriteLine("El valor que se ingreso no es correcto\n");
                    goto inicio;
                }

        }


    }
}
