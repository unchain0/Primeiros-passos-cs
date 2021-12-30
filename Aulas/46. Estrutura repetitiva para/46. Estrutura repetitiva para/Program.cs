using System;

namespace _46._Estrutura_repetitiva_para
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }
            Console.WriteLine();
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Valor de i: " + i);
            }
        }
    }
}
