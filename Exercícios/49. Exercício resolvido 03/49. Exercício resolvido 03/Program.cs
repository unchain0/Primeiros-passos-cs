using System;

namespace _49._Exercício_resolvido_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int mult = n * i;
                Console.WriteLine("{0} x {1} = {2}", i, n, mult);
            }
        }
    }
}
