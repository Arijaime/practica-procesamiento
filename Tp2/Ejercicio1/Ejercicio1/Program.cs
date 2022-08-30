using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
             string ingresoDatos,salidaDatos;
             int longitud;
             string apellido, nombre;
                


        Console.WriteLine(" Por favor ingrese su nombre y apellido (separado por un espacio ) : ");
        ingresoDatos= Console.ReadLine();

            longitud = ingresoDatos.Length;
            Console.WriteLine(longitud);

            int posSpace;
           

            posSpace = ingresoDatos.IndexOf(" ");

            int ultimoChar = longitud - posSpace-1;

            Console.WriteLine("posicion espacio : "+ posSpace);


            nombre = ingresoDatos.Substring(0, posSpace);
            apellido = ingresoDatos.Substring((posSpace+1),ultimoChar);

            
            salidaDatos = String.Concat(apellido,String.Concat(" ",nombre)) ;
            //salidaDatos = salidaDatos.Remove(0, 1);

            Console.WriteLine(salidaDatos);



        }
    }
}
