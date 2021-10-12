using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2; int num3;
            Console.Write("Ingrese su número uno:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su número dos:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su número tres:");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("El mayor es: " + num1);
                }
                else
                {
                    Console.Write("el mayor es: " + num3);
                }
            }
            else 
            if (num2 > num3)
            {
                Console.Write("el mayor es: " + num2);
            }
            else
            {
                Console.Write("el mayor es: " + num3);
            }
    }
}
}
