using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int con = 0; int num1 = 7; int multi;
            Console.WriteLine("Los múltiplos de 7 son:");
            do
            {
                con = con + 1;
                multi = num1 * con;
                Console.WriteLine(+num1 + "*" + con + "=" + multi);
            } while (multi<999);
        }
    }
}
