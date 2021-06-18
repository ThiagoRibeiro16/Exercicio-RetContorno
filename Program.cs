using System;

namespace Exercicio_RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = "";

            do
            {
                Console.Clear();

                Console.WriteLine("-- Retângulos --\n");

                Console.WriteLine("1 - Preenchido | 2 - Contorno | 0 - Sair\n");

                Console.Write("Escolha sua opção.....: ");
                opcaoUsuario = Console.ReadLine();




                if (opcaoUsuario == "1")
                {
                    ExibiRetanguloPreencido();
                }

                if (opcaoUsuario == "2")
                {
                    ExibiRetanguloContorno();
                }

            }

            while (opcaoUsuario != "0");
            Console.WriteLine("\n\nObrigado por utilizar nosso programa.");









        }

        static void ExibiRetanguloPreencido()
        {
            Console.WriteLine("\n-- Retângulo Preenchido --\n");

            int linhas = 0;
            int colunas = 0;

            Console.Write("Quantidade de linhas.....: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade de colunas....: ");
            colunas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (colunas <= 0 || colunas > 10 || linhas <= 0 || linhas > 10)

            {
                Console.WriteLine("Digite a quantidade de colunas e linhas entre 1 e 10");
            }

            else
            {


                int linhaAtual = 0;
                while (linhaAtual < linhas)
                {
                    linhaAtual += 1;

                    int colunaAtual = 0;
                    while (colunaAtual < colunas)
                    {
                        colunaAtual += 1;
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                Console.Write("\nPressione uma tecla para continuar...");
                Console.ReadKey();

            }

        }

        static void ExibiRetanguloContorno()
        {
            Console.WriteLine("\n-- Retângulo Contorno --\n");

            int qtdLinhas = 0;
            int colunas = 0;

            Console.Write("Quantidade de linhas.....: ");
            qtdLinhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade de colunas....: ");
            colunas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (colunas <= 0 || colunas > 10 || qtdLinhas <= 0 || qtdLinhas > 10)

            {
                Console.WriteLine("Digite a quantidade de colunas e linhas entre 1 e 10");
            }

            else
            {


                int linhaAtual = 0;
                while (linhaAtual < qtdLinhas)
                {
                    linhaAtual += 1;

                    int colunaAtual = 0;
                    while (colunaAtual < colunas)
                    {
                        colunaAtual += 1;

                        if (linhaAtual == 1 || linhaAtual == qtdLinhas)

                        {
                            Console.Write("*");
                        }

                        else

                        {
                            if (colunaAtual == 1 || colunaAtual == colunas)
                            {
                                Console.Write("*");
                            }

                            else
                            {
                                Console.Write(" ");
                            }

                        }




                    }

                    Console.WriteLine();
                }

                Console.Write("\nPressione uma tecla para continuar...");
                Console.ReadKey();

            }

        }
    }
}




