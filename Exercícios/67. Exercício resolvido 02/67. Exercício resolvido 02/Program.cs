using System;

namespace _67._Exercício_resolvido_02 {
    internal class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s[0]);
            int colunas = int.Parse(s[1]);

            int[,] matriz = new int[linhas, colunas];
            int[] soma = new int[linhas];

            for (int i = 0; i < linhas; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                    soma[i] += matriz[i, j];
                }
            }

            foreach (int n in soma) Console.WriteLine(n);
        }
    }
}
