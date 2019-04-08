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
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 9));

                Tela.ImprimirTabuleiro(tabuleiro);

                System.Console.WriteLine("\n\n");
            }
            catch(TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
