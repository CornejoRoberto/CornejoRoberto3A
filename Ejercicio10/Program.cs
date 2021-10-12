using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial=1; int con1 = 0; int k;
            Console.Write("ingrese un número para aplicar el factorial:");
            k = int.Parse(Console.ReadLine());
            Console.Write(k + "!=");
            for (int i = 1; i <= k; i++)
            {
                con1 = con1 + 1;
                factorial = factorial * con1;
                Console.Write(i+"*");
            }
            Console.Write("="+factorial);
        }
    }
}
