using System;
using System.Globalization;

namespace _59._Exercício_resolvido_03 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            double alturaCont = 0, menoresCont = 0;
            for (int i = 0; i < n; i++) {
                string[] vect = Console.ReadLine().Split(' ');
                nome[i] = vect[0];
                idade[i] = int.Parse(vect[1]);
                altura[i] = double.Parse(vect[2], CultureInfo.InvariantCulture);

                alturaCont += altura[i];
                if (idade[i] < 16) menoresCont++;
            }
            double alturaMedia = alturaCont / n;
            double menores16 = menoresCont * 100.0 / n;

            Console.WriteLine($"\nAltura média: {alturaMedia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {menores16.ToString("F1", CultureInfo.InvariantCulture)}%");
        }
    }
}
