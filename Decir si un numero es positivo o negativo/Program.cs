using System;

namespace Decir_si_un_numero_es_positivo_o_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa que pida al usuario dos números enteros y diga
             "Uno de los números es positivo", "Los dos números son positivos" 
              o bien "Ninguno de los números es positivo", según corresponda.
            */

            string dato = "";
            int num1, num2 = 0;

            Console.Write("Introduzca el primer numero: ");
            dato = Console.ReadLine();

            num1 = Convert.ToInt32(dato);

            Console.Write("Introduzca el segundo numero: ");
            dato = Console.ReadLine();

            num2 = Convert.ToInt32(dato);

            if (num1 >= 0 && num2 >= 0)
            {
                Console.WriteLine("Los dos numeros son positivos");
            }
            else if (num1 >= 0 || num2 >= 0)
            {
                Console.WriteLine("Uno de los números es positivo");
            }
            else
            {
                Console.WriteLine("Ninguno de los números es positivo");
            }
        }
    }
}
