using System;
using System.Globalization;

namespace _68._Exercícios_propostos_PARTE_2 {
    internal class Program {
        private static void Main(string[] args) {

        }

        private static void ex001() {
            string[] s = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s[0]);
            int colunas = int.Parse(s[1]);

            int[,] matriz = new int[linhas, colunas];
            for (int i = 0; i < linhas; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }

        private static void ex002() {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int[] soma = new int[n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                    soma[i] += matriz[i, j];
                }
            }

            foreach (int x in soma) {
                Console.WriteLine(x);
            }
        }

        private static void ex003() {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int[] maior = new int[n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                    maior[i] = matriz[i, j];
                }
            }

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (maior[i] < matriz[i, j]) {
                        maior[i] = matriz[i, j];
                    }
                }
                Console.WriteLine(maior[i]);
            }
        }

        private static void ex004() {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 1 + i; j < n; j++) {
                    soma += matriz[i, j];
                }
            }
            Console.WriteLine(soma);
        }

        private static void ex005() {
            string[] s = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s[0]);
            int colunas = int.Parse(s[1]);

            int[,] a = new int[linhas, colunas];
            int[,] b = new int[linhas, colunas];
            int[,] c = new int[linhas, colunas];

            // leitura da matriz a
            for (int i = 0; i < linhas; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            // leitura da matriz b
            for (int i = 0; i < linhas; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    b[i, j] = int.Parse(s[j]);
                }
            }

            // geração da matriz c
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            // impressão da matriz c
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write($"{c[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void ex006() {
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];
            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            // soma dos positivos
            double soma = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] > 0) {
                        soma += matriz[i, j];
                    }
                }
            }

            // linha escolhida e coluna escolhida
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSOMA DOS POSITIVOS: {soma.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++) {
                Console.Write($"{matriz[linha, i].ToString("F1", CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine();

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++) {
                Console.Write($"{matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine();

            // diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++) {
                Console.Write($"{matriz[i, i].ToString("F1", CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine();

            // matriz alterada
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    double pow = Math.Pow(matriz[i, j], 2);

                    if (matriz[i, j] < 0 && j == 0) {
                        Console.Write($"{pow.ToString("F1", CultureInfo.InvariantCulture)} ");
                    }
                    else if (matriz[i, j] < 0 && j > 0) {
                        Console.Write($" {pow.ToString("F1", CultureInfo.InvariantCulture)} ");
                    }
                    else if (j == 0) {
                        Console.Write($"{matriz[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
                    }
                    else if (j > 0) {
                        Console.Write($" {matriz[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
                    }

                    if (j == n - 1) {
                        Console.WriteLine();
                    }
                }
            }
        }

        private static void ex007() {
            int linhas = int.Parse(Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            // girar fila
            int fila = int.Parse(Console.ReadLine());
            fila--;

            int ultimoDaFila = matriz[fila, colunas - 1];

            for (int j = colunas - 1; j > 0; j--) {
                matriz[fila, j] = matriz[fila, j - 1];
            }

            matriz[fila, 0] = ultimoDaFila;

            // exibir na tela
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
