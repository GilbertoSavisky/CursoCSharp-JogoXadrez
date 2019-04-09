using System;
using tabuleiro;


namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int Turno;
        private Cor jogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            jogadorAtual = Cor.Branca;
            ColocarPecas();
            Terminada = false;
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tabuleiro.RetirarPeca(origem);
            p.IncrementarMovimento();
            Peca pecaCapturada = tabuleiro.RetirarPeca(destino);
            tabuleiro.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            tabuleiro.ColocarPeca(new Dama(tabuleiro, Cor.Branca), new PosicaoXadrez('c',1).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tabuleiro.ColocarPeca(new Dama(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());


        }
    }
}
