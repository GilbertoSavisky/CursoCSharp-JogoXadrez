using System;
using System.Text;
using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            int zColuna = tabuleiro.Colunas;
            Console.Write("   ");
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"  {(char)(i+65)}  ");
            }
            Console.WriteLine();
            Console.Write("   ");
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"══╦══");
            }
            Console.WriteLine();


            for (int i = 0; i < tabuleiro.Linhas; i++)
            {

                for (int k = 0; k < tabuleiro.Colunas; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("   ╔═══╗");

                    }
                    else
                    {
                        Console.Write("╔═══╗");
                    }


                }
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"\n{zColuna--} ");
                        if (tabuleiro.Peca(i, j) != null)
                            Console.Write($"═╣ {tabuleiro.Peca(i, j)} ");
                        else
                            Console.Write($"═╣   ");
                    }
                    else if (j == tabuleiro.Colunas - 1)
                    {
                        if (tabuleiro.Peca(i, j) != null)
                            Console.Write($"╠╣ {tabuleiro.Peca(i, j)} ║");
                        else
                        {
                            Console.Write("╠╣   ");
                            Console.Write($"║");
                        }
                    }
                    else
                    {
                        if(tabuleiro.Peca(i,j) != null)
                            Console.Write($"╠╣ {tabuleiro.Peca(i, j)} ");
                        else
                            Console.Write("╠╣   ");
                    }
                }
                Console.WriteLine();
                for (int y = 0; y < tabuleiro.Colunas; y++)
                {
                    if (y == 0)
                    {
                        Console.Write("   ╚═══╝");

                    }
                    else
                    {
                        Console.Write("╚═══╝");
                    }

                    
                }
                Console.WriteLine();
            }
        }
    }
}
