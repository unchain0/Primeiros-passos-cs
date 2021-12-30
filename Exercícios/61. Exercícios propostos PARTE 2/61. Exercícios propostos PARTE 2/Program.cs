using System;
using System.Globalization;

namespace _61._Exercícios_propostos_PARTE_2 {
    internal class Program {
        static void Main(string[] args) {
            ex001();
        }
        private static void ex001() {
            int n = int.Parse(Console.ReadLine());
            double[] num = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

            double maior = num[0];
            int pos = 0;

            for (int i = 1; i < num.Length; i++) {
                if (num[i] > maior) {
                    maior = num[i];
                    pos = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(pos);
        }
        private static void ex002() {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) num[i] = int.Parse(s[i]);

            int cont = 0;
            foreach (int pares in num) {
                if (pares % 2 == 0) {
                    Console.Write($"{pares} ");
                    cont++;
                }
            }
            Console.WriteLine($"\n{cont}");
        }
        private static void ex003() {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            string[] s;

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < s.Length; i++) a[i] = int.Parse(s[i]);

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < s.Length; i++) b[i] = int.Parse(s[i]);

            for (int i = 0; i < c.Length; i++) c[i] = a[i] + b[i];
            foreach (int x in c) Console.Write($"{x} ");
        }
        private static void ex004() {
            int n = int.Parse(Console.ReadLine());
            double[] num = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < num.Length; i++) num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

            double soma = 0;
            foreach (double x in num) soma += x;

            double media = soma / num.Length;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < num.Length; i++) if (media > num[i]) Console.WriteLine(num[i].ToString("F1", CultureInfo.InvariantCulture));
        }
        private static void ex005() {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < num.Length; i++) num[i] = int.Parse(s[i], CultureInfo.InvariantCulture);

            int soma = 0, cont = 0;
            foreach (int x in num) {
                if (x % 2 == 0) {
                    soma += x;
                    cont++;
                }
            }

            int media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
        private static void ex006() {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idade = new int[n];
            string[] s;

            for (int i = 0; i < n; i++) {
                s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            int maior = idade[0], pos = 0;
            for (int i = 1; i < idade.Length; i++) {
                if (idade[i] > maior) {
                    maior = idade[i];
                    pos = i;
                }
            }

            Console.WriteLine($"Pessoa mais velha: {nomes[pos]}");
        }
        private static void ex007() {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] notas = new double[n];
            string[] s;

            for (int i = 0; i < n; i++) {
                s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                notas[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                notas[i] += double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            double[] media = new double[notas.Length];
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < media.Length; i++) {
                media[i] = notas[i] / 2;
                if (media[i] >= 6.0) Console.WriteLine(nomes[i]);
            }
        }
        private static void ex008() {
            int n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            char[] sexo = new char[n];
            string[] s;

            for (int i = 0; i < n; i++) {
                s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1].ToUpper());
            }

            double menor = altura[0], maior = altura[0];
            for (int i = 1; i < altura.Length; i++) {
                if (menor > altura[i]) menor = altura[i];
                if (maior < altura[i]) maior = altura[i];
            }
            Console.WriteLine($"Menor altura = {menor.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior altura = {maior.ToString("F2", CultureInfo.InvariantCulture)}");

            double alturaF = 0.0, mediaF;
            int contF = 0, contM = 0;
            for (int i = 0; i < sexo.Length; i++) {
                if (sexo[i] == 'F') {
                    alturaF += altura[i];
                    contF++;
                }
                if (sexo[i] == 'M') contM++;
            }
            mediaF = alturaF / contF;

            Console.WriteLine($"Media das alturas das mulheres = {mediaF.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Numero de homens = {contM}");
        }
        private static void ex009() {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];

            double totalCompra = 0, totalVenda = 0;
            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                compra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

                totalCompra += compra[i];
                totalVenda += venda[i];
            }
            double lucroTotal = totalVenda - totalCompra;

            int contAbaixoDe10 = 0, contAcimaDe20 = 0, contEntre10E20 = 0;
            for (int i = 0; i < n; i++) {
                double lucro = venda[i] - compra[i];
                double porcentagemDeLucro = lucro / compra[i] * 100.0;

                if (porcentagemDeLucro < 10.0) contAbaixoDe10++;
                else if (porcentagemDeLucro <= 20.0) contEntre10E20++;
                else contAcimaDe20++;
            }

            Console.WriteLine($"Lucro abaixo de 10%: {contAbaixoDe10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {contEntre10E20}");
            Console.WriteLine($"Lucro acima de 20%: {contAcimaDe20}");
            Console.WriteLine($"Valor total de compra: {totalCompra.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total de venda: {totalVenda.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
