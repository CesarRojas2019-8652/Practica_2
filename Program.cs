﻿using System;

namespace practica_2_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n;
                string linea;
                Console.Write("Ingrese un numero y se mostrará la tabla de multiplicar: ");
                linea = Console.ReadLine();
                n = int.Parse(linea);
                for (int i = 1; i <= 500; i++)
                {
                    Console.Write(n + " x " + i + " = " + n * i + "\n");
                }
                Console.ReadKey();

            }
        }
    }
}
    