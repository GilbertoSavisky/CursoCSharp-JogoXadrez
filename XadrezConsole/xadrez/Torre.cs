using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca p = Tab.Peca(posicao);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao posicao = new Posicao(0, 0);
            // acima
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            while (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tab.Peca(posicao) != null && Tab.Peca(posicao).Cor != Cor)
                    break;
                posicao.Linha = posicao.Linha - 1;
            }

            // abaixo
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            while (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tab.Peca(posicao) != null && Tab.Peca(posicao).Cor != Cor)
                    break;
                posicao.Linha = posicao.Linha + 1;
            }

            // direita
            posicao.DefinirValores(posicao.Linha, posicao.Coluna+1);
            while (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tab.Peca(posicao) != null && Tab.Peca(posicao).Cor != Cor)
                    break;
                posicao.Coluna = posicao.Coluna + 1;
            }

            // esq
            posicao.DefinirValores(posicao.Linha , posicao.Coluna-1);
            while (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tab.Peca(posicao) != null && Tab.Peca(posicao).Cor != Cor)
                    break;
                posicao.Coluna = posicao.Coluna - 1;
            }


            return mat;
        }
    }
}
