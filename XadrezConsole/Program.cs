using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Tela.FormatarTela();
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tabuleiro.Peca(origem).MovimentosPossiveis();


                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
            }

            catch (TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
