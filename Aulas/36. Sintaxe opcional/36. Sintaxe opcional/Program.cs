using System;
using System.Globalization;

namespace _36._Sintaxe_opcional {

    internal class Program {

        private static void Main(string[] args) {
            int minutos, limite = 100, total = 50;
            minutos = int.Parse(Console.ReadLine());

            if (minutos <= 100) {
                Console.WriteLine("Valor a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                total += (minutos - limite) * 2;
                Console.WriteLine("Valor a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}