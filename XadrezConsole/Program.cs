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
                    
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab);
                        Console.WriteLine($"\nTurno: {partida.Turno}");
                        Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoOrigem(origem);
                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                        Console.WriteLine($"\nTurno: {partida.Turno}");
                        Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException erro)
                    {
                        Console.WriteLine($"Erro: {erro.Message}");
                        Console.Read();
                    }

                }
            }

            catch (TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
