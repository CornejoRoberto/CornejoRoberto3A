using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int con = 0; double prom; int conta = 0; int conta2 = 0;
            Console.WriteLine("Ingrese sus números:");
            Console.WriteLine("Para finalizar el programa ingrese el número 0");
            do
            {
                num1 = int.Parse(Console.ReadLine());
                conta = conta + 1;
                con = con + num1;
            } while (num1 > 1);
            conta2 = (conta - 1);
            prom = con / conta2;
            Console.WriteLine("El promedio es:" + prom);
        }
    }
}