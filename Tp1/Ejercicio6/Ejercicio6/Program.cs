namespace Ejercicio6
{
    internal class Program
    {
        static void Main()
        {
            int numeroIngresado = 0;
            int dig;
            int prodDigPar = 0;
            int prodDigImpar = 0;
            int contDigpar = 0;
            int contDigImpar = 0;
            Boolean unicaVezPar =false;
            Boolean unicaVezImpar =false;

            do
            {
                Console.WriteLine("Ingrese un numero Positivo : ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                if (numeroIngresado<=0) { Console.WriteLine("El numero ingresado no es valido"); };
            }    
            while (numeroIngresado<=0 );

            for (int i = 0;  numeroIngresado> 0; i++)
            {
                dig = numeroIngresado % 10;
                numeroIngresado /= 10;

                if (dig%2==0) {

                    contDigpar++;

                    if (contDigpar>0) {
                        if (unicaVezPar==false) {
                            prodDigPar = 1;
                        }
                                                                                        
                        prodDigPar = prodDigPar * dig;                       
                        unicaVezPar = true;
                     
                    }
 
                }else
                
                {
                    if (dig%2==1)
                    {

                        contDigImpar++;
                        if (contDigImpar > 0)
                        {
                            if (unicaVezImpar == false)
                            {
                                prodDigImpar = 1;
                            }

                            prodDigImpar = prodDigImpar * dig;
                            unicaVezImpar = true;
                        
                        }

                    }

                }
           
            }

           Console.WriteLine(" Producto dig pares : {0}  - Producto dig impares : {1}", prodDigPar,prodDigImpar);

        }
    }
}