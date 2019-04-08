using tabuleiro;
namespace xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + linha;
        }
    }
}
