using System;
using xadrez;
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
                Console.Write($"  {(char)(i + 65)}  ");
            }
            Console.WriteLine();
            Console.Write("   ");
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"  ╦  ");
            }
            Console.WriteLine();


            for (int i = 0; i < tabuleiro.Linhas; i++)
            {

                for (int k = 0; k < tabuleiro.Colunas; k++)
                {
                    if (k == 0)
                        Console.Write("   ╔═╩═╗");
                    else
                        Console.Write("╔═╩═╗");

                }
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"\n{zColuna--} ");
                        if (tabuleiro.Peca(i, j) != null)
                        {
                            Console.Write($"═╣ ");
                            Tela.ImprimirPeca(tabuleiro.Peca(i, j));
                            Console.Write(" ");
                        }
                        else
                            Console.Write($"═╣   ");
                    }
                    else if (j == tabuleiro.Colunas - 1)
                    {
                        if (tabuleiro.Peca(i, j) != null)
                        {
                            Console.Write($"╠╣ ");
                            Tela.ImprimirPeca(tabuleiro.Peca(i, j));
                            Console.Write(" ║");
                        }
                        else
                        {
                            Console.Write("╠╣   ");
                            Console.Write($"║");
                        }
                    }
                    else
                    {
                        if (tabuleiro.Peca(i, j) != null)
                        {
                            Console.Write($"╠╣ ");
                            Tela.ImprimirPeca(tabuleiro.Peca(i, j));
                            Console.Write(" ");
                        }
                        else
                            Console.Write("╠╣   ");
                    }
                }
                Console.WriteLine();
                for (int y = 0; y < tabuleiro.Colunas; y++)
                {
                    if (y == 0)
                    {
                        Console.Write("   ╚═╦═╝");

                    }
                    else
                    {
                        Console.Write("╚═╦═╝");
                    }


                }
                Console.WriteLine();
            }
            Console.Write("   ");

            for (int h = 0; h < tabuleiro.Linhas; h++)
            {
                Console.Write($"  ╩  ");
            }
            Console.WriteLine();
            Console.Write("   ");

            for (int h = 0; h < tabuleiro.Linhas; h++)
            {
                Console.Write($"  {(char)(h + 65)}  ");
            }
            Console.WriteLine();
        }

        public static void ImprimirPeca(Peca peca)
        {

            if (peca.Cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else if (peca.Cor == Cor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static void FormatarTela()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Title = "Xadrez";
            Console.Clear();
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
