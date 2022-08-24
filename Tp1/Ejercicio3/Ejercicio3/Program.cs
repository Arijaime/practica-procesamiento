using System;

internal class Program
{


    enum figuras { Piedras = 0, Papel = 1, Tijeras = 2 };



    static void Main()
    {
        int figuraEmilia;
        int figuraPedro;
        
        int ganadorJuego =0;
        int rounds =0;
        int puntajeEmilia=0;
        int puntajePedro=0;


        do
        {
            mostrarRounds(rounds);
            figuraEmilia = sacarFigura();
            figuraPedro = sacarFigura();
            ganadorJuego = juego(figuraEmilia, figuraPedro);
         
            definirGanador(ganadorJuego);

            rounds++;
        } while (rounds < 3);


        mostrarGanador();

        

       


        // metodo para sacar figura aleatoria
        int sacarFigura()
        {
            Random rnd = new();
            int figuraRandom = rnd.Next(3);

            return figuraRandom;
        }

        // logica del juego base
        int juego(int f1, int f2)
        {
            //figuras fig = new();

            int ganador = 0;
            // 0 para empate ,ganador 1 para emilia , ganador 2 para pedro


            if (f1 == f2) 
            {
                Console.WriteLine("Emilia Ha sacado   {0}", Convert.ToString((figuras)f1));
                Console.WriteLine("Pedro  ha sacado : {0}", Convert.ToString((figuras)f2));
                Console.WriteLine("EMPATE");
                ganador = 0;
            }

            // emilia

            if (f1 ==0 && f2 ==1 ) 
            {
                Console.WriteLine("Emilia ha sacado : {0}",figuras.Piedras );
                Console.WriteLine("Pedro  ha sacado : {0}",figuras.Papel);
                Console.WriteLine("Ha ganado Pedro.");
                ganador = 2; 
            }

            if (f1 == 0 && f2 == 2)
            {
                Console.WriteLine("Emilia ha sacado : {0}", figuras.Piedras);
                Console.WriteLine("Pedro  ha sacado : {0}", figuras.Tijeras);
                Console.WriteLine("Ha ganado Emilia.");
                ganador = 1;
            }

            if (f1 == 1 && f2 == 2)
            {
                Console.WriteLine("Emilia ha sacado : {0}", figuras.Papel);
                Console.WriteLine("Pedro  ha sacado : {0}", figuras.Tijeras);
                Console.WriteLine("Ha ganado Pedro.");
                ganador = 2;
            }

            // pedro
            if (f1 == 1 && f2 == 0)
            {
                Console.WriteLine("Emilia ha sacado : {0}", figuras.Papel);
                Console.WriteLine("Pedro  ha sacado : {0}", figuras.Piedras);
                Console.WriteLine("Ha ganado Emilia.");
                ganador = 1;
            }

            if (f1 == 2 && f2 == 0)
            {
                Console.WriteLine("Emilia ha sacado : {0}", figuras.Tijeras);
                Console.WriteLine("Pedro  ha sacado : {0}", figuras.Piedras);
                Console.WriteLine("Ha ganado Pedro.");
                ganador = 2;
            }

            if (f1 == 2 && f2 == 1)
            {
                Console.WriteLine("Emilia ha sacado : {0}", figuras.Tijeras);
                Console.WriteLine("Pedro  ha sacado : {0}", figuras.Papel);
                Console.WriteLine("Ha ganado Emilia.");
                ganador = 1;
            }



            return ganador;
        }

        //metodo para contabilizar los rounds ganados
        void definirGanador(int ganador){

            if (ganador == 0)
            {
            }
            else {
                if (ganador == 1)
                {
                    puntajeEmilia++;
                }
                else {
                    if (ganador == 2) {
                        puntajePedro++;
                    }
                }
            }
            
        }
       
        //Metodo para mostrar el ganador
        void mostrarGanador() {
            if (puntajeEmilia > puntajePedro)
            {
                Console.WriteLine("Emilia Ha ganado el juego.");
            }
            else {
                if (puntajePedro > puntajeEmilia)
                {
                    Console.WriteLine("Pedro ha ganado el juego.");
                }
                else {
                   Console.WriteLine( "El juego Ha terminado en EMPATE");
                } 
            }
        }
        
        //muestro los rounds
        void mostrarRounds(int r) {
            Console.WriteLine("round {0}", r + 1);
        }



    }
}
   
  
