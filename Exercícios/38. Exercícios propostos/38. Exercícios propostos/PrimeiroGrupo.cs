using System;
using System.Globalization;

namespace _38._Exercícios_propostos {

    internal class PrimeiroGrupo {

        private static void uri1035() {
            int a, b, c, d;

            string[] vect = Console.ReadLine().Split(' ');
            a = int.Parse(vect[0]);
            b = int.Parse(vect[1]);
            c = int.Parse(vect[2]);
            d = int.Parse(vect[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0) {
                Console.WriteLine("Valores aceitos");
            } else {
                Console.WriteLine("Valores nao aceitos");
            }
        }

        private static void uri1038() {
            double[] preco = { 4.00, 4.50, 5.00, 2.00, 1.50 };

            string[] vect = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vect[0]);
            int quantidade = int.Parse(vect[1]);
            double total = 0;

            switch (codigo) {
                case 1:
                    total = preco[0] * quantidade;
                    break;

                case 2:
                    total = preco[1] * quantidade;
                    break;

                case 3:
                    total = preco[2] * quantidade;
                    break;

                case 4:
                    total = preco[3] * quantidade;
                    break;

                case 5:
                    total = preco[4] * quantidade;
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void uri1044() {
            string[] vect = Console.ReadLine().Split(' ');
            int a = int.Parse(vect[0]);
            int b = int.Parse(vect[1]);

            if (b % a == 0 || a % b == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

        private static void uri1046() {
            int i, f, total, dia = 24;

            string[] vect = Console.ReadLine().Split(' ');
            i = int.Parse(vect[0]);
            f = int.Parse(vect[1]);

            total = dia - i + f;

            if (total > dia) {
                total -= dia;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", total);
            } else {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", total);
            }
        }

        private static void uri1048() {
            double salario, novoSalario, reajuste = 0, porcentagem = 0;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novoSalario = salario;

            if (salario >= 0.00 && salario <= 400.00) {
                novoSalario += salario * 0.15;
                reajuste = salario * 0.15;
                porcentagem = 15;
            } else if (salario >= 400.01 && salario <= 800.00) {
                novoSalario += salario * 0.12;
                reajuste = salario * 0.12;
                porcentagem = 12;
            } else if (salario >= 800.01 && salario <= 1200.00) {
                novoSalario += salario * 0.10;
                reajuste = salario * 0.10;
                porcentagem = 10;
            } else if (salario >= 1200.01 && salario <= 2000.00) {
                novoSalario += salario * 0.07;
                reajuste = salario * 0.07;
                porcentagem = 7;
            } else if (salario > 2000.00) {
                novoSalario += salario * 0.04;
                reajuste = salario * 0.04;
                porcentagem = 4;
            }

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", porcentagem);
        }
    }
}