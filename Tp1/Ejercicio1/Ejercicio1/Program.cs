/*Escribir un programa que ingrese 3 (tres) números enteros distintos, y mostrar cuál
valor intermedio. (el número que NO es el mayor, NI el menor)*/
using System;


class Ejercicio1
{
    static void Main()
    {

        // -- arreglo con el que voy a almacenar valores
        int[] numeros = new int[3];

        // -- entero donde voy a almacenar el intermedio
        int intermedio = new();

        //-- utilizo arreglo para cargar los 3 valores
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("por favor ingrese el valor del numero de la posicion {0}", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }


        //-- arreglo para visualizar los numeros que cargue
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("los numeros ingresados son {0}", numeros[i]);
        }

     
     
        //-- estructura logica para definir que numero es el intermedio
        if ((numeros[0] <= numeros[1]) && (numeros[2] >= numeros[1]))
        {
            intermedio = numeros[1];
        }
        else {
            if ((numeros[1]<= numeros[0])&&(numeros[2]>=numeros[0]))
            {
                intermedio = numeros[0];
            }
            else
            {
                intermedio = numeros[2];
            }
        }       

        //-- imprimo el valor del intermedio
        Console.WriteLine("el valor intermedio es {0}", intermedio);
    
    }

    

}





       
        
    
    
