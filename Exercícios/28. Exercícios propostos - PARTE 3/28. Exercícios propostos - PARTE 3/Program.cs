using System;
using System.Globalization;

namespace _28._Exercícios_propostos___PARTE_3 {

    internal class Program {

        private static void Main(string[] args) {

            // Coloque a função aqui!
        }

        private static void uri1018() {
            int n, quociente, resto, nota;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            resto = n;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine("{0} nota(s) de R$ {1},00", quociente, nota);
            resto %= nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine("{0} nota(s) de R$ {1},00", quociente, nota);
            resto %= nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine("{0} nota(s) de R$ {1},00", quociente, nota);
            resto %= nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine("{0} nota(s) de R$ {1},00", quociente, nota);
            resto %= nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine("{0} nota(s) de R$ {1},00", quociente, nota);
            resto %= nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine("{0} nota(s) de R$ {1},00", quociente, nota);
            resto %= nota;

            Console.WriteLine("{0} nota(s) de R$ {1},00", resto, nota);
        }

        private static void uri1020() {
            int idade, ano = 365, mes = 30, resto, quociente;

            idade = int.Parse(Console.ReadLine());
            resto = idade;

            quociente = resto / ano; // Pega o número inteiro
            Console.WriteLine(quociente + " ano(s)");
            resto %= ano;

            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto %= mes;

            Console.WriteLine(resto + " dia(s)");
        }

        private static void uri1021() {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Vamos multiplicar N por 100 e forçar a conversão para int. Desse modo, por exemplo,
            // 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar que o numero seja
            // devidamente arredondado, pois o tipo double as vezes da problema de arredondamento
            // (por exemplo: se digitarmos 576.81 e multiplicarmos por 100, o resultado sera
            // 57680.99999999, dai o casting resultaria em 57680 e nao 57681 como desejado)

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            // como multiplicamos o valor por 100 acima, o valor de cada nota também deverá ser
            // multiplicado por 100 a seguir

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            Console.WriteLine("MOEDAS:");

            // o valor de cada moeda deverá ser representado em centavos

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto %= moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto %= moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto %= moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto %= moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto %= moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }

        private static void uri1061() {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, inicio, fim, duracao, resto;

            // Ler a primeira linha, armazenando o valor de W (dia)
            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            // Ler a terceira linha, armazenando o valor de W (dia)
            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            // Calculando o valor do inicio e fim, convertendo tudo para segundos
            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            // Calculando a duracao em segundos
            duracao = fim - inicio;

            // Agora vamos desmembrar a duracao em segundos para dia (W), hora (X), minutos (Y) e
            // segundos (Z) restantes
            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}
