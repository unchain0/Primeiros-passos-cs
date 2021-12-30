using System;

namespace _37._Sintaxe_opcional {

    internal class Program {

        private static void Main(string[] args) {
            string s;
            int dia = int.Parse(Console.ReadLine());

            switch (dia) {
                case 1:
                    s = "domingo";
                    break;

                case 2:
                    s = "segunda";
                    break;

                case 3:
                    s = "terça";
                    break;

                case 4:
                    s = "quarta";
                    break;

                case 5:
                    s = "quinta";
                    break;

                case 6:
                    s = "sexta";
                    break;

                case 7:
                    s = "sábado";
                    break;

                default:
                    s = "valor inválido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + s);
        }
    }
}