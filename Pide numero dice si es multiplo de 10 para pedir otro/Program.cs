using System;

namespace Pide_numero_dice_si_es_multiplo_de_10_para_pedir_otro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa que pida al usuario un número entero.
             Si es múltiplo de 10, se lo avisará al usuario y pedirá un segundo número,
             para decir a continuación si este segundo número también es múltiplo de 10.
            */


            string dato = "";
            int num1, num2 = 0;

            Console.Write("Introduzca el primer numero: ");
            dato = Console.ReadLine();

            num1 = Convert.ToInt32(dato);

            if (num1 % 10 == 0)
            {
                Console.WriteLine("El primer numero es multiplo de 10");

                Console.Write("Introduzca el segundo numero: ");
                dato = Console.ReadLine();

                num2 = Convert.ToInt32(dato);
                if (num2 % 10 == 0)
                    Console.WriteLine("El segundo numero tambien es multiplo de 10");
                else
                    Console.WriteLine("El segundo numero no es multiplo de 10");
            }
            else
            {
                Console.WriteLine("El primer numero no es multiplo de 10");
            }
        }
    }
}
