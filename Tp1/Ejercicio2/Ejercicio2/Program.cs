
using System;

internal class Program
{
    static void Main()
    {
        Console.Write("Ingrese la edad del individuo : ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad <= 12) { Console.WriteLine(value: "MENOR"); }
        else
        {
            if (edad >= 13 && edad <= 18) { Console.WriteLine(value: "MENOR");}
            else {
               
                if (edad > 18 && edad <= 29) { Console.WriteLine(value: "JUVEN");}
                else { Console.WriteLine(value: "ADULTO");}
            }
        }
    }
}