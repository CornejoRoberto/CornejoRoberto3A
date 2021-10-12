using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int con = 0; int num1; int acum = 0; int num2;
            Console.Write("Ingrese la cantidad de números límite:");
            num2 = int.Parse(Console.ReadLine());
            do
            {
                con = con + 1;
                Console.Write("Ingrese su número #" + con + ":");
                num1 = int.Parse(Console.ReadLine());
                acum = acum + num1;
            } while (con < num2);
            Console.Write("El resultad de la suma es:" + acum);
        }
    }
}

