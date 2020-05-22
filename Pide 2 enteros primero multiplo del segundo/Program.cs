using System;

namespace Pide_2_enteros_primero_multiplo_del_segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo.

            string dato = "";
            int num1, num2 = 0;

            Console.Write("Introduzca el primer numero: ");
            dato = Console.ReadLine();

            num1 = Convert.ToInt32(dato);

            Console.Write("Introduzca el segundo numero: ");
            dato = Console.ReadLine();

            num2 = Convert.ToInt32(dato);

            if (num1 % num2 == 0) 
            {
                Console.WriteLine("El segundo es multiplo del primero.");
            }
            else
            {
                Console.WriteLine("No es multiplo");
            }
        }
    }
}
