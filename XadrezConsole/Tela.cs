using System;
using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            /*Console.Write("     ");
            for (int i = 0; i < tabuleiro.Linhas; i++)
                Console.Write($"{i}  ");

            Console.WriteLine();
            Console.Write("  ╔═");
            for (int i = 0; i < tabuleiro.Linhas; i++)

                Console.Write($"═╦═");
            Console.WriteLine();
            Console.WriteLine("  ║");
            */
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                //Console.Write($"{i} ╠ ");
                Console.Write("╔═╗");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if(j == 0)
                    Console.Write("═╣");
                    for (int k = 0; k < tabuleiro.Colunas; k++)
                    {

                    }

                    /*

                    if (tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("═╗ ");//╔═╗");

                    }
                    else
                    {
                        Console.Write($"   ═╣{tabuleiro.Peca(i, j)}╠═   ");

                        //

                    }
                    Console.Write("╚═╝");

                }

                Console.WriteLine();
                */
                }
            }
        }
    }
}
