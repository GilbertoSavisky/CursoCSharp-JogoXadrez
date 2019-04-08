using System; 
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
                /*Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 7));

                Tela.ImprimirTabuleiro(tabuleiro);

                System.Console.WriteLine("\n\n");

    */
                PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);

                Console.WriteLine(posicaoXadrez);
                Console.WriteLine(posicaoXadrez.toPosicao());

            }
            catch(TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
