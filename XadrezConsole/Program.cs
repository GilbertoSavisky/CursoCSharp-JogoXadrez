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

                    Console.WriteLine($"\nTurno: {partida.Turno}");
                    Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tabuleiro.Peca(origem).MovimentosPossiveis();


                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);
                    Console.WriteLine($"\nTurno: {partida.Turno}");
                    Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.RealizaJogada(origem, destino);
                }
            }

            catch (TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
