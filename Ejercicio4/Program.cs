using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.WriteLine("Ingrese sus números:");
            Console.WriteLine("Para finalizar el programa ingrese el número 0");
            do
            {
                num1 = double.Parse(Console.ReadLine());
            } while (num1>1);
        }
    }
}
