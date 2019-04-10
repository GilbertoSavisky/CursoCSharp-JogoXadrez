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
                    ImprimirPeca(tabuleiro.Peca(i,j), tabuleiro, numeroColuna, i, j);
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
                    if (posPossiveis[i, j])
                        ImprimirPeca(tabuleiro.Peca(i, j), tabuleiro, numeroColuna, i, j, posPossiveis);
                    else
                        ImprimirPeca(tabuleiro.Peca(i, j), tabuleiro, numeroColuna, i, j);
                }
                numeroColuna--;
                Console.WriteLine();
                ImprimirParteBaixo(tabuleiro, i);
                Console.WriteLine();
                
            }
        }

        public static void ImprimirPeca(Peca peca, Tabuleiro tabuleiro, int numCol, int i, int j, bool[,] posPossiveis)
        {
            ConsoleColor corOriginal = Console.BackgroundColor;
            ConsoleColor corAlterada = ConsoleColor.Magenta;

            if (j == 0)
                Console.Write($" {numCol} ╣");
            Console.BackgroundColor = corAlterada;
            if (peca == null)
            {
                Console.Write("   ");
                Console.BackgroundColor = corOriginal;
                if (j == tabuleiro.Colunas - 1)
                    Console.Write($"╠═  { numCol}");
                else
                    Console.Write("╠╣");
            }

            else if (peca.Cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {peca} ");
                Console.ForegroundColor = aux;
                Console.BackgroundColor = corOriginal;
                if (j == tabuleiro.Colunas - 1)
                    Console.Write($"╠═  { numCol}");
                else
                    Console.Write("╠╣");
            }
            else if (peca.Cor == Cor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($" {peca} ");
                Console.ForegroundColor = aux;
                Console.BackgroundColor = corOriginal;
                if (j == tabuleiro.Colunas - 1)
                    Console.Write($"╠═  { numCol}");
                else
                    Console.Write("╠╣");
            }
        }

        public static void ImprimirPeca(Peca peca, Tabuleiro tabuleiro, int numCol, int i, int j)
        {
            if (j == 0)
                Console.Write($" {numCol}  ═╣");
            if (peca == null)
            {
                if (j == tabuleiro.Colunas - 1)
                    Console.Write($"   ╠═  { numCol}");
                else
                    Console.Write("   ╠╣");
            }

            else if (peca.Cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {peca} ");
                Console.ForegroundColor = aux;
                if (j == tabuleiro.Colunas - 1)
                    Console.Write($"╠═  { numCol}");
                else
                    Console.Write("╠╣");
            }
            else if (peca.Cor == Cor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($" {peca} ");
                Console.ForegroundColor = aux;
                if (j == tabuleiro.Colunas - 1)
                    Console.Write($"╠═  { numCol}");
                else
                    Console.Write("╠╣");
            }
        }

        public static void FormatarTela()
        {
            Console.ForegroundColor = ConsoleColor.Green ;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Title = "Xadrez";
            Console.Clear();
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirParteCima(Tabuleiro tab)
        {
            Console.Write("     ");
            for (int i = 0; i < tab.Linhas; i++)
                Console.Write($"  {(char)(i + 65)}  ");
            Console.WriteLine("\n");
        }

        public static void ImprimirMatrizCima(Tabuleiro tabuleiro)
        {
            for (int k = 0; k < tabuleiro.Colunas; k++)
            {
                if (k == 0)
                    Console.Write("     ╔═╩═╗");
                else
                    Console.Write("╔═╩═╗");
            }
            Console.WriteLine();
        }

        public static void ImprimirParteBaixo(Tabuleiro tabuleiro, int fim)
        {
            for (int y = 0; y < tabuleiro.Colunas; y++)
            {
                if (y == 0)
                    Console.Write("     ╚═╦═╝");
                else
                    Console.Write("╚═╦═╝");
            }
            if (fim == 7)
            {
                Console.WriteLine("\n");
                Console.Write("     ");

                for (int h = 0; h < tabuleiro.Linhas; h++)
                {
                    Console.Write($"  {(char)(h + 65)}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
