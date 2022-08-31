using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main()
        {
            string ingresoDatos;
            int longitud,ultimoChar;
            string nombre, apellido;

            Console.WriteLine("ingrese datos : ");
            ingresoDatos = Console.ReadLine();

            longitud = ingresoDatos.Length;
            

            int posSpace = ingresoDatos.IndexOf(" ");

            ultimoChar = longitud - posSpace -1 ;

            nombre = ingresoDatos.Substring(0, posSpace);
            apellido = ingresoDatos.Substring((posSpace+1),ultimoChar);

            nombre = toUpperMethod(nombre);
            apellido = toUpperMethod(apellido);



            Console.WriteLine("datos : {1} {0}", nombre, apellido);


            string toUpperMethod(string str) {

                
                    string character;
                    character = str.Substring(0,1);

                    character = character.ToUpper();

                str = str.Remove(0,1);

                str = String.Concat(character,str);

                return str;
            }


        }
    }
}
