using System;

namespace CobeñaRoberto3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2;
            Console.Write("Ingrese su número uno:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su número dos:");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.Write("El número mayor es:" + num1);
            else
                Console.Write("El número mayor es:" + num2);
        }
    }
}

