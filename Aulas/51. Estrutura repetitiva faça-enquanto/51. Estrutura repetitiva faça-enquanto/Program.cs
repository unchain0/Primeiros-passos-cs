using System;
using System.Globalization;

namespace _51._Estrutura_repetitiva_faça_enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char v;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = 9 * c / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                v = char.Parse(Console.ReadLine());
            } while (v == 's');
        }
    }
}
