using System;

namespace _3_numeros_reales_y_diga_cual_es_el_mayor_de_los_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario tres números reales y muestre cuál es el mayor de los tres.

            Console.Write("Introduzca el primer numero real: ");
            double num1 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Introduzca el primer numero real: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca el primer numero real: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El numero mayor es: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El numero mayor es: {0}", num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El numero mayor es: {0}", num3);
            }
            else
            {
                Console.WriteLine("Los 3 numeros son iguales");
            }
        }
    }
}