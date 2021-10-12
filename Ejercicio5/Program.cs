using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int con = 0; int num1; int acum = 0;
            do
            {
                con = con + 1;
                Console.Write("Ingrese su número #" + con + ":");
                num1 = int.Parse(Console.ReadLine());
                acum = acum + num1;
            } while (con<5);
            Console.Write("El resultad de la suma es:" + acum);
        }
    }
}
