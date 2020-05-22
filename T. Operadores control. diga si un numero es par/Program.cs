using System;

namespace T._Operadores_control._diga_si_un_numero_es_par
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un numero entero y diga si es par.

            string dato = "";
            int num = 0;

            Console.Write("Introduzca un numero entero: ");
            dato = Console.ReadLine();

            num = Convert.ToInt32(dato);

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par.");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
