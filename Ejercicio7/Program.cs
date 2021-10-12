using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2; int num3; string data;
            do
            {
            Console.Write("Ingrese su número uno:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su número dos:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su número tres:");
            num3 = int.Parse(Console.ReadLine());
                {
                if (num1 == num2 && num1 == num3)
                {
                Console.WriteLine("El triangulo es equilatero");
                }
                if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                Console.WriteLine("El triangulo es isosceles");
                }
                if (num1 != num2 && num1 != num2 && num2 != num3)
                {
                Console.WriteLine("El triangulo es escaleno");  
                }
                    Console.WriteLine("Si quiere continuar escriba S y si quiere terminar el proceso escriba N");
                    data = Console.ReadLine();
                }
            } while (data=="S");
        }
}
}
