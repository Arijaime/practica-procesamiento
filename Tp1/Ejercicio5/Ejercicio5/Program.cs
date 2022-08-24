using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main()
        {
            int numeroIngresado = 0;
            int numeroIngresadoSinProcesar = 0;
            int digito = 0;
            int sumatoriaDigitos =0;
            
            do {
                Console.WriteLine("Ingrese un numero Entero POSITIVO :");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
            }
            while (numeroIngresado<=0);

            numeroIngresadoSinProcesar = numeroIngresado;

            Console.WriteLine("En numero ingresado es {0}",numeroIngresado);

            for (int i = 0;  numeroIngresado> 0; i++)
             {
                 digito = numeroIngresado % 10;
            sumatoriaDigitos = sumatoriaDigitos + digito;
            numeroIngresado = numeroIngresado / 10;

           
             }

                mostrarVeredicto();

            











            Boolean esPrimo(int sumatoria)
            {
                Boolean nro = false;
                int contador = 0;

                for (int i = 1; i <= sumatoria; i++)
                {
                    if (sumatoria % i == 0)
                    {
                        contador++;
                    }

                }

                if (contador == 2)
                {
                    nro = true;
                }

                return nro;
            }


            void mostrarVeredicto()
            {
                Boolean result;

                 result = esPrimo(sumatoriaDigitos);

                 if (result)
                {
                    Console.WriteLine("La suma de los dígitos de {0} es {1} que es un numero PRIMO",numeroIngresadoSinProcesar,sumatoriaDigitos);
                }
                else
                {
                    Console.WriteLine("La suma de los dígitos de {0} es {1} que NO es un numero PRIMO", numeroIngresadoSinProcesar, sumatoriaDigitos);
                }

            }


        }

      


    }
}