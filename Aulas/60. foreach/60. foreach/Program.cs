using System;

namespace _60._foreach {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];

            for (int i = 0; i < n; i++) nomes[i] = Console.ReadLine();

            Console.WriteLine("Nomes lidos:");
            foreach (string x in nomes) Console.WriteLine(x);
        }
    }
}
