using System;
using System.Globalization;

namespace _45._Exercícios_propostos_PARTE_2
{
    internal class PrimeiroGrupo
    {
        private static void uri1114()
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }

        private static void uri1115()
        {
            string[] vect = Console.ReadLine().Split(' ');
            int x = int.Parse(vect[0]);
            int y = int.Parse(vect[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) Console.WriteLine("primeiro");
                else if (x > 0 && y < 0) Console.WriteLine("quarto");
                else if (x < 0 && y < 0) Console.WriteLine("terceiro");
                else if (x < 0 && y > 0) Console.WriteLine("segundo");

                vect = Console.ReadLine().Split(' ');
                x = int.Parse(vect[0]);
                y = int.Parse(vect[1]);
            }
        }

        private static void uri1117()
        {
            double nota, media = 0, i = 0;

            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota >= 0 && nota <= 10)
            {
                i++;
                media = nota;
            }
            else
            {
                Console.WriteLine("nota invalida");
                while (i < 2)
                {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota < 0 || nota > 10) Console.WriteLine("nota invalida");
                    else
                    {
                        i++;
                        media += nota;
                    }
                }
                media /= 2.0;
            }
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void uri1134()
        {
            int num, alcool = 0, gasolina = 0, diesel = 0;
            // 1.Álcool 2.Gasolina 3.Diesel 4.Fim
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    alcool++;
                    num = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    gasolina++;
                    num = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    diesel++;
                    num = int.Parse(Console.ReadLine());
                    break;
                default:
                    num = int.Parse(Console.ReadLine());
                    break;
            }

            while (num != 4)
            {
                switch (num)
                {
                    case 1:
                        alcool++;
                        num = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        gasolina++;
                        num = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        diesel++;
                        num = int.Parse(Console.ReadLine());
                        break;
                    default:
                        num = int.Parse(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }

        private static void uri1154()
        {
            double idade, media, i = 1;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = idade;

            while (idade > 0)
            {
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (idade > 0)
                {
                    media += idade;
                    i++;
                }
            }
            media /= i;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void uri1059()
        {
            int x, total;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    total = x + x + 2 + x + 4 + x + 6 + x + 8;
                    Console.WriteLine(total);
                    x = int.Parse(Console.ReadLine());
                }
                else
                {
                    x++;
                    total = x + x + 2 + x + 4 + x + 6 + x + 8;
                    Console.WriteLine(total);
                    x = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
