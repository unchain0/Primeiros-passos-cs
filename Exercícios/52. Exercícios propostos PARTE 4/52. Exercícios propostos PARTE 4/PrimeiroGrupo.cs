using System;
using System.Globalization;

namespace _52._Exercícios_propostos_PARTE_4
{
    internal class PrimeiroGrupo
    {

        private static void uri1067()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }

        private static void uri1071()
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = 0;

            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }

        private static void uri1072()
        {
            int n, x, dentro = 0, fora = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) dentro++;
                else fora++;
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }

        private static void uri1073()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                int quad = i * i;
                if (i % 2 == 0) Console.WriteLine("{0}^2 = {1}", i, quad);
            }
        }

        private static void uri1074()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    if (x == 0) Console.WriteLine("NULL");
                    else Console.Write("EVEN ");

                    if (x > 0) Console.WriteLine("POSITIVE");
                    else if (x < 0) Console.WriteLine("NEGATIVE");
                }
                else if (x % 2 != 0)
                {
                    if (x == 0) Console.WriteLine("NULL");
                    else Console.Write("ODD ");

                    if (x > 0) Console.WriteLine("POSITIVE");
                    else if (x < 0) Console.WriteLine("NEGATIVE");
                }
            }
        }

        private static void uri1075()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % n == 2) Console.WriteLine(i);
            }
        }

        private static void uri1079()
        {
            double a, b, c, media;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                a = double.Parse(vect[0], CultureInfo.InvariantCulture);
                b = double.Parse(vect[1], CultureInfo.InvariantCulture);
                c = double.Parse(vect[2], CultureInfo.InvariantCulture);
                media = (2 * a + 3 * b + 5 * c) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        private static void uri1080()
        {
            int maior = int.Parse(Console.ReadLine());
            int pos = 1;

            for (int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    pos = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }

        private static void uri1094()
        {
            int tc = 0, tr = 0, ts = 0, total = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                int quantia = int.Parse(vect[0]);
                char tipo = char.Parse(vect[1].ToUpper());
                total += quantia;

                if (tipo == 'C') tc += quantia;
                else if (tipo == 'R') tr += quantia;
                else if (tipo == 'S') ts += quantia;
            }
            double pc = tc * 100.0 / total;
            double pr = tr * 100.0 / total;
            double ps = ts * 100.0 / total;

            Console.WriteLine("Total: {0} cobaias", total);
            Console.WriteLine("Total de coelhos: " + tc);
            Console.WriteLine("Total de ratos: " + tr);
            Console.WriteLine("Total de sapos: " + ts);
            Console.WriteLine("Percentual de coelhos: {0} %", pc.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Percentual de ratos: {0} %", pr.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Percentual de sapos: {0} %", ps.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void uri1096()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
            }
        }

        private static void uri1097()
        {
            int j = 7;
            for (int i = 1; i <= 9; i += 2)
            {
                Console.WriteLine("I={0} J={1}", i, j);
                Console.WriteLine("I={0} J={1}", i, j - 1);
                Console.WriteLine("I={0} J={1}", i, j - 2);
                j += 2;
            }
        }

        private static void uri1116()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                double a = double.Parse(vect[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vect[1], CultureInfo.InvariantCulture);

                if (b == 0) Console.WriteLine("divisao impossivel");
                else
                {
                    double div = a / b;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }

        private static void uri1132()
        {
            int soma = 0;

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int menor = x;
            int maior = y;

            if (x > y)
            {
                maior = x;
                menor = y;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0) soma += i;
            }

            Console.WriteLine(soma);
        }

        private static void uri1133()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                int aux = x;
                x = y;
                y = aux;
            }

            for (int i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3) Console.WriteLine(i);
            }
        }

        private static void uri1142()
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                int segundo = inicio + 1;
                int terceiro = inicio + 2;
                Console.WriteLine("{0} {1} {2} PUM", inicio, segundo, terceiro);

                inicio += 4;
            }
        }

        private static void uri1143()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
            }
        }

        private static void uri1144()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2) + 1, Math.Pow(i, 3) + 1);
            }
        }

        private static void uri1151()
        {
            int a = 0, b = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i += 1)
            {
                if (i == n - 1) Console.WriteLine(a);
                else Console.Write("{0} ", a);

                int aux = b;
                b = a;
                a = aux + b;
            }
        }

        private static void uri1153()
        {
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n; i++) fatorial *= i;
            Console.WriteLine(fatorial);
        }

        private static void uri1156()
        {
            int num;
            double den = 1.0, soma = 0.0;

            for (num = 1; num <= 39; num += 2)
            {
                soma += num / den;
                den *= 2.0;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void uri1157()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) if (n % i == 0) Console.WriteLine(i);
        }
    }
}
