using System;

namespace Decir_si_es_multiplo_de_4_o_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un número entero y diga si es múltiplo de 4 o de 5.

            string dato = "";
            int num = 0;

            Console.Write("Introduzca un numero: ");
            dato = Console.ReadLine();

            num = Convert.ToInt32(dato);


            if (num % 4 == 0 && num % 5 == 0)
            {
                Console.WriteLine("El numero es multiplo de 4 y 5");
            }
            else if (num % 4 == 0)
            {
                Console.WriteLine("El numero es multiplo de 4");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("El numero es multiplo de 5");
            }           
        }
    }
}
