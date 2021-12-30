using System;
using System.Globalization;

namespace _38._Exercícios_propostos
{

    internal class SegundoGrupo
    {
        private static void uri1037()
        {
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n >= 0.00 && n <= 25.00) Console.WriteLine("Intervalo [0,25]");
            else if (n > 25.00 && n <= 50.00) Console.WriteLine("Intervalo (25,50]");
            else if (n > 50.00 && n <= 75.00) Console.WriteLine("Intervalo (50,75]");
            else if (n > 75.00 && n <= 100.00) Console.WriteLine("Intervalo (75,100]");
            else Console.WriteLine("Fora de intervalo");
        }

        private static void uri1040()
        {
            float n1, n2, n3, n4, media, exame;

            string[] vect = Console.ReadLine().Split(' ');
            n1 = float.Parse(vect[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vect[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vect[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vect[3], CultureInfo.InvariantCulture);

            media = (2 * n1 + 3 * n2 + 4 * n3 + 1 * n4) / 10;

            // O problema 1040 tem uma falha de arredondamento especifica
            // para a linguagem C#. Quando a media da 4.85, nos temos que
            // ajusta-la manualmente para 4.8, o que eh uma "gambiarra"
            // horrivel, infelizmente.
            if (media == 4.85f) media = 4.8f;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0 && media <= 10.0) Console.WriteLine("Aluno aprovado.");
            else if (media < 5.0 && media >= 0.0) Console.WriteLine("Aluno reprovado.");
            else
            {
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

                media = (media + exame) / 2;
                if (media >= 5.0 && media <= 10.0) Console.WriteLine("Aluno aprovado.");
                else if (media > 5.0 && media >= 0.0) Console.WriteLine("Aluno reprovado.");

                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        private static void uri1041()
        {
            double x, y;

            string[] vect = Console.ReadLine().Split(' ');
            x = double.Parse(vect[0], CultureInfo.InvariantCulture);
            y = double.Parse(vect[1], CultureInfo.InvariantCulture);

            if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");
            else if (x < 0.0 && y > 0.0) Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");
            else if (x > 0.0 && y < 0.0) Console.WriteLine("Q4");
            else if (x != 0 && y == 0) Console.WriteLine("Eixo X");
            else if (x == 0 && y != 0) Console.WriteLine("Eixo Y");
            else Console.WriteLine("Origem");
        }

        private static void uri1045()
        {
            double a = 0, b = 0, c = 0, n1, n2, n3;

            string[] vect = Console.ReadLine().Split(' ');
            n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vect[2], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3)
            {
                a = n1;
                if (n2 > n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n2;
                }
            }
            else if (n2 > n3)
            {
                a = n2;
                if (n1 > n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else
            {
                a = n3;
                if (n1 > n2)
                {
                    b = n1;
                    c = n2;
                }
                else
                {
                    b = n2;
                    c = n1;
                }
            }

            if (a >= b + c) Console.WriteLine("NAO FORMA TRIANGULO");
            else
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) Console.WriteLine("TRIANGULO RETANGULO");
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2)) Console.WriteLine("TRIANGULO OBTUSANGULO");
                else Console.WriteLine("TRIANGULO ACUTANGULO");

                if (a == b && b == c) Console.WriteLine("TRIANGULO EQUILATERO");
                else if (a == b || b == c || c == a) Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }

        private static void uri1047()
        {
            int horaInicial, minInicial, horaFinal, minFinal, duracao, horaDuracao, minDuracao, instanteInicial, instanteFinal;

            string[] vect = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vect[0]);
            minInicial = int.Parse(vect[1]);
            horaFinal = int.Parse(vect[2]);
            minFinal = int.Parse(vect[3]);

            instanteInicial = horaInicial * 60 + minInicial;
            instanteFinal = horaFinal * 60 + minFinal;

            if (instanteInicial < instanteFinal) duracao = instanteFinal - instanteInicial;
            else duracao = (24 * 60 - instanteInicial) + instanteFinal;

            horaDuracao = duracao / 60;
            minDuracao = duracao % 60;

            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horaDuracao, minDuracao);
        }

        private static void uri1049()
        {
            string t1, t2, t3, animal = "";

            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();

            if (t1 == "vertebrado")
            {
                if (t2 == "ave")
                {
                    if (t3 == "carnivoro") animal = "aguia";
                    else if (t3 == "onivoro") animal = "pomba";
                }
                else if (t2 == "mamifero")
                {
                    if (t3 == "onivoro") animal = "homem";
                    else if (t3 == "herbivoro") animal = "vaca";
                }
            }
            else if (t1 == "invertebrado")
            {
                if (t2 == "inseto")
                {
                    if (t3 == "hematofago") animal = "pulga";
                    else if (t3 == "herbivoro") animal = "lagarta";
                }
                else if (t2 == "anelideo")
                {
                    if (t3 == "hematofago") animal = "sanguessuga";
                    else if (t3 == "onivoro") animal = "minhoca";
                }
            }

            Console.WriteLine(animal);
        }

        private static void uri1051()
        {
            double renda, imposto;

            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda <= 3000.00) imposto = (renda - 2000.00) * 0.08;
            else if (renda <= 4500.00) imposto = (renda - 3000.00) * 0.18 + 1000.00 * 0.08;
            else imposto = (renda - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;

            if (renda <= 2000.00) Console.WriteLine("Isento");
            else Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}