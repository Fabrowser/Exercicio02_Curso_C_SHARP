using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = -1;

            while (opcao != 0)
            {

                Console.WriteLine("Seleciona a opção Desejada: \n \n [1] Número NEGATIVO ? " +
                    "\n [2] PAR OU ÍMPAR \n [3] MULTIPLOS \n [4] HORAS DE JOGO");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            CalculaNegativo();
                            break;
                        }

                    case 2:
                        {

                            ParImpar();
                            break;
                        }
                    case 3:
                        {

                            Multiplos();
                            break;
                        }

                    case 4:
                        {
                            HorasJogo();
                            break;
                        }

                }




            }


        }

        public static void CalculaNegativo()

        {

            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Número NEGATIVO");

            }
            else
            {
                Console.WriteLine("Número NÃO NEGATIVO");
            }

        }


        public static void ParImpar()

        {

            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Número PAR");

            }
            else
            {
                Console.WriteLine("Número ÍMPAR");
            }

        }

        public static void Multiplos()

        {

            Console.WriteLine("Digite O PRIMEIRO NUMERO inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite O SEGUNDO NUMERO inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");

            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }

        }

        public static void HorasJogo()

        {
            Console.WriteLine("Digite O HORÁRIO INICIAL DO JOGO: ");
            int h1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite O HORÁRIO FINAL DO JOGO: ");
            int h2 = int.Parse(Console.ReadLine());

            int horasTotal = 0;

            if (h1 < h2)
            {

                horasTotal = h2 - h1;
                Console.WriteLine("TOTAL HORAS: " + horasTotal);

            }
            else
            {

                horasTotal = (h2 + (24 - h1));
                Console.WriteLine("TOTAL HORAS: " + horasTotal);
            }


        }





    }


}
