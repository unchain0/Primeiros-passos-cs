using System;
using System.Globalization;

namespace _52._Exercícios_propostos_PARTE_4
{
    internal class SegundoGrupo
    {
        private static void uri1099()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                int x = int.Parse(vect[0]);
                int y = int.Parse(vect[1]);

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;
                for (int j = x + 1; j < y; j++) if (j % 2 != 0) soma += j;

                Console.WriteLine(soma);
            }
        }

        private static void uri1101()
        {
            for (int i = 0; i < 3; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                int x = int.Parse(vect[0]);
                int y = int.Parse(vect[1]);

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int sum = 0;
                for (int j = x; j <= y; j++)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.Write("{0} ", j);
                        sum += j;
                    }
                }
                if (sum != 0) Console.WriteLine("Sum=" + sum);
            }
        }

        private static void uri1145()
        {
            string[] vect = Console.ReadLine().Split(' ');
            int x = int.Parse(vect[0]);
            int y = int.Parse(vect[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                if (i % x == 0) Console.WriteLine();
                else Console.Write(" ");
            }
        }

        private static void uri1149()
        {
            int A, N, i, soma;

            string[] vect = Console.ReadLine().Split(' ');

            A = int.Parse(vect[0]);

            i = 1;
            N = int.Parse(vect[i]);
            while (N <= 0)
            {
                i += 1;
                N = int.Parse(vect[i]);
            }

            soma = 0;
            for (i = 0; i < N; i++) soma += A + i;

            Console.WriteLine(soma);
        }

        private static void uri1150()
        {
            // versão própria

            int x, z, soma = 0;

            x = int.Parse(Console.ReadLine());

            do z = int.Parse(Console.ReadLine()); while (z <= x);
            for (int i = x; i < z; i += x + 1) soma++;

            Console.WriteLine(soma);
        }

        private static void uri1158()
        {
            int n, x, y;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                x = int.Parse(vect[0]);
                y = int.Parse(vect[1]);

                int soma = 0;
                int cont = 0;
                for (int j = x; cont < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                        cont++;
                    }
                }
                Console.WriteLine(soma);
            }
        }

        private static void uri1060()
        {

            int T, PA, PB, crescA, crescB, anos;
            double G1, G2;

            T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                PA = int.Parse(vect[0]);
                PB = int.Parse(vect[1]);
                G1 = double.Parse(vect[2], CultureInfo.InvariantCulture);
                G2 = double.Parse(vect[3], CultureInfo.InvariantCulture);

                crescA = PA;
                crescB = PB;

                anos = 0;
                while (crescA <= crescB)
                {
                    crescA += (int)(crescA * (G1 / 100));
                    crescB += (int)(crescB * (G2 / 100));
                    anos += 1;
                }

                if (anos > 100) Console.WriteLine("Mais de 1 seculo.");
                else Console.WriteLine($"{anos} anos.");
            }
        }

        private static void uri1165()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int resultado = 0;

                for (int j = 2; j <= x / 2; j++)
                {
                    if (x % j == 0)
                    {
                        Console.WriteLine($"{x} nao eh primo");
                        resultado++;
                        break;
                    }
                }
                if (resultado == 0) Console.WriteLine($"{x} eh primo");
            }
        }
    }
}
