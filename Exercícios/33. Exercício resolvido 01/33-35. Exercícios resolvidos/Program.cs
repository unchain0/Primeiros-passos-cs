using System;
using System.Globalization;

namespace _33_35_Exercícios_resolvidos {

    internal class Program {

        private static void Main(string[] args) {
            int n1, n2, n3;

            string[] vect = Console.ReadLine().Split(' ');
            n1 = int.Parse(vect[0]);
            n2 = int.Parse(vect[1]);
            n3 = int.Parse(vect[2]);

            if (n1 < n2 && n1 < n3) {
                Console.WriteLine("MENOR = " + n1);
            } else if (n2 < n3) {
                Console.WriteLine("MENOR = " + n2);
            } else {
                Console.WriteLine("MENOR = " + n3);
            }
        }

        private static void ex01() {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = n1 + n2;

            Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media < 60.0) {
                Console.WriteLine("REPROVADO");
            }
        }

        private static void ex02() {
            double a, b, c, delta, r1, r2;
            string[] vect = Console.ReadLine().Split(' ');
            a = double.Parse(vect[0], CultureInfo.InvariantCulture);
            b = double.Parse(vect[1], CultureInfo.InvariantCulture);
            c = double.Parse(vect[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (delta < 0.0 || a == 0.0) {
                Console.WriteLine("Impossivel calcular");
            } else {
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }

        private static void ex03() {
        }
    }
}