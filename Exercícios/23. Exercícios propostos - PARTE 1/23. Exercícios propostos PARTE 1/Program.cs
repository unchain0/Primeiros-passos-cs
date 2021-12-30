using System;
using System.Globalization;

namespace _23._Exercícios_propostos_PARTE_1 {

    internal class Program {

        private static void Main(string[] args) {

            // Coloque a função do exercício aqui!
            uri1006();
        }

        public static void uri1002() {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void uri1003() {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = " + (A + B));
        }

        public static void uri1004() {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("PROD = " + (A * B));
        }

        public static void uri1005() {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (3.5 * a + 7.5 * b) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }

        public static void uri1006() {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (2 * a + 3 * b + 5 * c) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static void uri1007() {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + diferenca);
        }

        public static void uri1008() {
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double dinheiroPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = dinheiroPorHora * hours;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void uri1010() {
            string[] p1 = Console.ReadLine().Split(' ');
            int np1 = int.Parse(p1[1]);
            double vup1 = double.Parse(p1[2], CultureInfo.InvariantCulture);
            double tp1 = np1 * vup1;

            string[] p2 = Console.ReadLine().Split(' ');
            int np2 = int.Parse(p2[1]);
            double vup2 = double.Parse(p2[2], CultureInfo.InvariantCulture);
            double tp2 = np2 * vup2;

            double total = tp1 + tp2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void uri1014() {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = x / y;

            Console.WriteLine("{0} km/l", total.ToString("F3", CultureInfo.InvariantCulture));
        }

        public static void uri1016() {
            int x = int.Parse(Console.ReadLine());
            double m = x * 2;

            Console.WriteLine("{0} minutos", m);
        }

        public static void uri1017() {
            int tgv = int.Parse(Console.ReadLine()); // Tempo gasto na viagem
            int vm = int.Parse(Console.ReadLine()); // Velocidade média
            double qlg = tgv * vm / 12.0; // Quantidade de litros gastos

            Console.WriteLine(qlg.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
