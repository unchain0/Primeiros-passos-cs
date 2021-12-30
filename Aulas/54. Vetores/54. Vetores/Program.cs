using System;
using System.Globalization;

namespace _54._Vetores {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double[] vs = new double[n];

            for (int i = 0; i < n; i++) {
                vs[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < vs.Length; i++) {
                Console.WriteLine(vs[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
