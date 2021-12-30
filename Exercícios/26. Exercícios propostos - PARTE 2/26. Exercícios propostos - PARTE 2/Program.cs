using System;
using System.Globalization;

namespace _26._Exercícios_propostos___PARTE_2 {

    internal class Program {

        private static void Main(string[] args) {

            // Coloque a função aqui!
            uri1015();
        }

        private static void uri1009() {
            Console.ReadLine(); // Nome do vendedor
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tdv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Total de vendas
            double total = tdv * 0.15 + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void uri1011() {
            const double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = 4.0 / 3 * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }

        private static void uri1012() {
            string[] vect = Console.ReadLine().Split(' ');

            double A = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vect[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2.0;
            double circulo = 3.14159 * Math.Pow(C, 2.0);
            double trapezio = (A + B) * C / 2.0;
            double quadrado = Math.Pow(B, 2.0);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }

        private static void uri1013() {
            string[] vect = Console.ReadLine().Split(' ');
            int A = int.Parse(vect[0]);
            int B = int.Parse(vect[1]);
            int C = int.Parse(vect[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            if (maiorAB > C) Console.WriteLine("{0} eh o maior", maiorAB);
            else if (maiorAB < C) Console.WriteLine("{0} eh o maior", C);
        }

        private static void uri1015() {
            string[] xy = Console.ReadLine().Split(' ');
            double x1 = double.Parse(xy[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(xy[1], CultureInfo.InvariantCulture);

            string[] yx = Console.ReadLine().Split(' ');
            double x2 = double.Parse(yx[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(yx[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
