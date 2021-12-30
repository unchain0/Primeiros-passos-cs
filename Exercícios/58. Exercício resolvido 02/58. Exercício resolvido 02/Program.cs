using System;
using System.Globalization;

namespace _58._Exercício_resolvido_02 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double[] vs = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) vs[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            for (int i = 0; i < vs.Length; i++) {
                Console.Write(vs[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                if (i == vs.Length-1) Console.WriteLine();
            }

            double soma = 0;
            for (int i = 0; i < vs.Length; i++) soma += vs[i];
            double media = soma / vs.Length;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
