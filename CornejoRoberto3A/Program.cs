using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Ingrese su número:");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("Su número es par");
            else
                Console.WriteLine("Su número no es par");
        }
    }
}

