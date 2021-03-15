using System;

namespace practica_2_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double suma = 0;
            
            Console.WriteLine("este programa captura los numeros los muestra y tira la suma de todos ellos.");

            for (int c = 0; c < 10; c++)
            {
                Console.Write("Introduzca el valor {0}: ", c + 1);
                numeros[c] = Convert.ToDouble(Console.ReadLine());
                suma += numeros[c];
            }
            suma = suma / 10;
            Console.Write("\nLos numeros introducidos fueron:\n ");
            for (int c = 0; c < 10; c++)
            
            { 
                Console.Write(" ({0}) ", numeros[c]);
            }
            Console.ReadKey();
        }
    }
    
}

