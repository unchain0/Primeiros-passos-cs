using System;

namespace _57._Exercício_resolvido_01 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] vs = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) vs[i] = int.Parse(s[i]);
            // mostrar apenas os números negativos
            for (int i = 0; i < vs.Length; i++) if (vs[i] < 0) Console.WriteLine(vs[i]);
        }
    }
}
