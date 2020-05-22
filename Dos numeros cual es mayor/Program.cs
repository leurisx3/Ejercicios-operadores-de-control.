using System;

namespace Dos_numeros_cual_es_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario dos numeros enteriso y diga cual  es mayor de ellos.

            string dato = "";
            int num1 = 0;
            int num2 = 0;

            Console.Write("Introduzca el primer numero: ");
            dato = Console.ReadLine();

            num1 = Convert.ToInt32(dato);

            Console.Write("Introduzca el segundo numero: ");
            dato = Console.ReadLine();

            num2 = Convert.ToInt32(dato);

            if (num1 > num2)
            {
                Console.WriteLine("El {0} es mayor", num1);
            }
            if (num2 > num1)
            {
                Console.WriteLine("El {0} es mayor", num2);
            }
            
        }
    }
}
