using System;

namespace _63._Matrizes {
    internal class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) matriz[i, j] = int.Parse(s[j]);
            }
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) Console.Write($"{matriz[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
