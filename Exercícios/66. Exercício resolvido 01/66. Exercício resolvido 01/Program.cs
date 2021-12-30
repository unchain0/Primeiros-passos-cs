using System;

namespace _66._Exercício_resolvido_01 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) matriz[i, j] = int.Parse(s[j]);
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++) {
                Console.Write($"{matriz[i, i]} ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) cont++;
                }
            }
            Console.WriteLine($"QUANTIDADE DE NEGATIVOS = {cont}");
        }
    }
}
