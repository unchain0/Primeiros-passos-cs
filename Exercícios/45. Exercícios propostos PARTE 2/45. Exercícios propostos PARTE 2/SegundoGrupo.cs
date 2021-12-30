using System;
using System.Globalization;

namespace _45._Exercícios_propostos_PARTE_2
{
    internal class SegundoGrupo
    {
        private static void uri1118()
        {
            int novoCalculo = 1;

            while (novoCalculo == 1)
            {
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void uri1131()
        {
            int inter = 0, gremio = 0, empates = 0, grenais = 0, novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] vect = Console.ReadLine().Split(' ');
                int x = int.Parse(vect[0]);
                int y = int.Parse(vect[1]);

                if (x > y) inter++;
                if (x < y) gremio++;
                if (x == y) empates++;
                grenais++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
                while (novoGrenal != 1 && novoGrenal != 2) novoGrenal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empates);

            if (inter > gremio) Console.WriteLine("Inter venceu mais");
            else if (inter < gremio) Console.WriteLine("Gremio venceu mais");
            else Console.WriteLine("Nao houve vencedor");
        }
    }
}
