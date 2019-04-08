using System;
using System.IO;
using xadrez;
using tabuleiro;

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


                Tela.ImprimirTabuleiro(partida.tabuleiro);

                System.Console.WriteLine("\n\n");
            }
            catch(TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
