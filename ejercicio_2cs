using System;

namespace practica_2_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)


        {

            int opcion= 0;
            
            Console.WriteLine("Eliga la opcion deseada\n" +
               "\n1. o   Convertir grados a Celsius a Fahrenheit " +
               "\n2. o   Convertir dólar a pesos." +
               "\n3. o   Convertir metros a pies." +
               "\n4. o   Salir \n");

            string s1 = null;
            s1 = Console.ReadLine();
            
                switch (s1)
                {

                    case "1":
                        Console.WriteLine("Esta opcion es para convertir grados de celsius a fahrenheit." + "\n" +
                        "\nSeleccione una conversion");
                        Console.WriteLine("1. ºC  a  ºF");
                        Console.WriteLine("2. ºF  a  ºC");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("Ingresa grados centigrados");
                            double c = Convert.ToDouble(Console.ReadLine());
                            double f = (c * 9 / 5) + (32);
                            Console.WriteLine(c + "ºC equivale a " + f + "ºF");
                        }
                        else
                        {
                            Console.WriteLine("Ingresa grados fahrenheit");
                            double f = Convert.ToDouble(Console.ReadLine());
                            double c = (f - 32) * 5 / 9;
                            Console.WriteLine(f + "ºF equivale  a " + c + "ºC");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Esta opcion es para connvertir el dolar a peso.");
                        {
                            double dolares, pesos;
                            Console.Write("Ingrese la cantidad de dolares:");
                            dolares = double.Parse(Console.ReadLine());
                            pesos = dolares * 57.25;
                            Console.WriteLine("Dolares={0} equivale a {1} pesos", dolares, pesos);

                        }
                        break;

                    case "3":

                        Console.WriteLine("Opcion para convertir metros a pies.\n");
                        {
                            float Pie;
                            float Metro;
                            float Medida;
                            Medida = 3.280839F;
                            Console.WriteLine("Conversor de medidas:");
                            Metro = float.Parse(Console.ReadLine());
                            Pie = Metro * Medida;
                            Console.WriteLine("{0} Metros es igual a {1} pies", Metro, Pie);
                            Console.ReadLine();
                        }

                        break;

                    case "4":
                        Console.WriteLine("Saliendo.");
                    {
                       Environment.Exit(-1);
                        
                    }
                        break;

                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;

            }
            if( opcion != 4);
                Console.ReadKey();
        }


    }
}
