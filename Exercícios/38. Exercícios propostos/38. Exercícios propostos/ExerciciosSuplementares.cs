using System;
using System.Globalization;

namespace _38._Exercícios_propostos
{
    internal class ExerciciosSuplementares
    {
        private static void uri1042()
        {
            int a, b, c;

            string[] vect = Console.ReadLine().Split(' ');
            a = int.Parse(vect[0]);
            b = int.Parse(vect[1]);
            c = int.Parse(vect[2]);

            if (a < b && a < c)
            {
                Console.WriteLine(a);
                if (b < c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
                if (a < c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(c);
                if (a < b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine("\n{0}\n{1}\n{2}", a, b, c);
        }

        private static void uri1043()
        {
            double a, b, c, perimetro, area;

            string[] vect = Console.ReadLine().Split(' ');
            a = double.Parse(vect[0], CultureInfo.InvariantCulture);
            b = double.Parse(vect[1], CultureInfo.InvariantCulture);
            c = double.Parse(vect[2], CultureInfo.InvariantCulture);

            if (b - c < a && a < b + c)
            {
                if (a - c < b && b < a + c)
                {
                    if (a - b < c && c < a + b)
                    {
                        // Perimetro
                        perimetro = a + b + c;
                        Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }
            else
            {
                // Area
                area = (a + b) * c / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        private static void uri1050()
        {
            int ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }
        }

        private static void uri1052()
        {
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }
        }

        private static void uri1060()
        {
            int n = 6, pos = 0;

            for (int i = 0; n > i; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num != 0 && num > 0.0) pos++;
            }

            Console.WriteLine("{0} valores positivos", pos);
        }

        private static void uri1064()
        {
            int n = 6, pos = 0;
            double media = 0;

            for (int i = 0; n > i; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num != 0 && num > 0.0)
                {
                    pos++;
                    media += num;
                }
            }
            media /= pos;

            Console.WriteLine("{0} valores positivos", pos);
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }

        private static void uri1065()
        {
            int n = 5, par = 0;

            for (int i = 0; n > i; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) par++;
            }

            Console.WriteLine("{0} valores pares", par);
        }

        private static void uri1066()
        {
            int n = 5, par = 0, impar = 0, pos = 0, neg = 0;

            for (int i = 0; n > i; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) par++;
                if (num % 2 != 0) impar++;
                if (num > 0) pos++;
                if (num < 0) neg++;
            }

            Console.WriteLine("{0} valor(es) par(es)", par);
            Console.WriteLine("{0} valor(es) impar(es)", impar);
            Console.WriteLine("{0} valor(es) positivo(s)", pos);
            Console.WriteLine("{0} valor(es) negativo(s)", neg);
        }

        private static void uri1070()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 6;)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                    i++;
                    n++;
                }
                else n++;
            }
        }
    }
}
