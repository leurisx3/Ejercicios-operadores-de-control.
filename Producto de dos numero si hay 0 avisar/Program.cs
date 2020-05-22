using System;

namespace Producto_de_dos_numero_si_es_0_avisar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un programa que multiplique dos números enteros de la siguiente forma:
            pedirá al usuario un primer número entero.
            Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0".
            Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos. 
            */

            string dato = "";
            int num1, num2 = 0;
            int producto = 0;

            Console.Write("Introduzca el primer numero: ");
            dato = Console.ReadLine();

            num1 = Convert.ToInt32(dato);

            while (num1 == 0)
            {
                Console.WriteLine("Todo numero multliplicado por 0 es 0");

                Console.Write("Introduzca el primer numero: ");
                dato = Console.ReadLine();

                num1 = Convert.ToInt32(dato);
            }

            Console.Write("Introduzca el segundo numero: ");
            dato = Console.ReadLine();

            num2 = Convert.ToInt32(dato);

            while (num2 == 0)
            {
                Console.WriteLine("Todo numero multliplicado por 0 es 0");

                Console.Write("Introduzca el segundo numero: ");
                dato = Console.ReadLine();

                num2 = Convert.ToInt32(dato);
            }

            producto = num1 * num2;
            Console.WriteLine("El producto de los 2 numeros ingresados es: {0}", producto);
        }
    }
}
