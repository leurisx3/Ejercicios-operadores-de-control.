using System;

namespace Dividir_2_numeros._si_el_segundo_tiene_0_avisar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un programa que pida al usuario dos números enteros. Si el segundo no es cero,
            mostrará el resultado de dividir entre el primero y el segundo. Por el contrario,
            si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".
            */

            string dato = "";
            int num1, num2 = 0;
            var division = 0;

            Console.Write("Introduzca el primer numero: ");
            dato = Console.ReadLine();

            num1 = Convert.ToInt32(dato);

            Console.Write("Introduzca el segundo numero: ");
            dato = Console.ReadLine();

            num2 = Convert.ToInt32(dato);

            while(num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");

                Console.Write("Introduzca el segundo numero: ");
                dato = Console.ReadLine();

                num2 = Convert.ToInt32(dato);
            }

            division = num1 / num2;
            Console.WriteLine("La division de los 2 numeros ingresados es: {0}", division);
        }
    }
}
