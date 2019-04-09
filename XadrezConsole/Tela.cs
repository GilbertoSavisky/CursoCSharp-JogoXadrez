using System;
using xadrez;
using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            int numeroColuna = tabuleiro.Colunas;
            ImprimirParteCima(tabuleiro);
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                ImprimirMatrizCima(tabuleiro);
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    ImprimirMatriz(tabuleiro, numeroColuna, i, j);
                }
                numeroColuna--;
                Console.WriteLine();
                ImprimirParteBaixo(tabuleiro, i);
                Console.WriteLine();
            }
            
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posPossiveis)
        {
            int numeroColuna = tabuleiro.Colunas;
            ImprimirParteCima(tabuleiro);
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                ImprimirMatrizCima(tabuleiro);
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    //ImprimirPeca(tabuleiro.Peca, tabuleiro, i, j);
                }
                numeroColuna--;
                Console.WriteLine();
                ImprimirParteBaixo(tabuleiro, i);
                Console.WriteLine();
            }
        }

        public static void ImprimirPeca(Peca peca, Tabuleiro tabuleiro, int numCol, int i, int j)
        {
            if (peca == null)
            {
                ImprimirMatriz(tabuleiro, numCol, i, j);

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

        public static void ImprimirParteCima(Tabuleiro tab)
        {
            Console.Write("   ");
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"  {(char)(i + 65)}  ");
            }
            Console.WriteLine();
            Console.Write("   ");
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"     ");
            }
            Console.WriteLine();
        }

        public static void ImprimirMatrizCima(Tabuleiro tabuleiro)
        {
            for (int k = 0; k < tabuleiro.Colunas; k++)
            {
                if (k == 0)
                    Console.Write("   ╔═╩═╗");
                else
                    Console.Write("╔═╩═╗");

            }
        }

        public static void ImprimirMatriz(Tabuleiro tabuleiro, int numeroColuna, int i, int j)
        {
            if (j == 0)
            {

                Console.Write($"\n{numeroColuna} ");
                if (tabuleiro.Peca(i, j) != null)
                {
                    Console.Write($"═╣ ");
                    //Tela.ImprimirPeca(tabuleiro.Peca(i, j));
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
                    //Tela.ImprimirPeca(tabuleiro.Peca(i, j));
                    Console.Write(" ╠═");
                }
                else
                {
                    Console.Write("╠╣   ");
                    Console.Write($"╠═  { numeroColuna}");
                }
            }
            else
            {
                if (tabuleiro.Peca(i, j) != null)
                {
                    Console.Write($"╠╣ ");
                    //Tela.ImprimirPeca(tabuleiro.Peca(i, j));
                    Console.Write(" ");
                }
                else
                    Console.Write("╠╣   ");
            }
            
        }
        public static void ImprimirParteBaixo(Tabuleiro tabuleiro, int fim)
        {
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
            if (fim == 7)
            {
                Console.WriteLine();
                Console.Write("   ");
                for (int h = 0; h < tabuleiro.Linhas; h++)
                {
                    Console.Write("     ");
                }
                Console.WriteLine();
                Console.Write("   ");

                for (int h = 0; h < tabuleiro.Linhas; h++)
                {
                    Console.Write($"  {(char)(h + 65)}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
