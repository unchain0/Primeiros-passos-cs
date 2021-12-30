using System;

namespace _50._Exercício_resolvido_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = 0;

            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            for (int i = min+1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
