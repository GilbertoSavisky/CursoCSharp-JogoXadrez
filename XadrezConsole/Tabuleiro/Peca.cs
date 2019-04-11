﻿namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            Cor = cor;
            Tab = tab;
            qtdeMovimentos = 0;
        }

        public void IncrementarMovimento()
        {
            qtdeMovimentos++;
        }

        public void DecrementarMovimento()
        {
            qtdeMovimentos--;
        }


        public bool ExisteMiviemntosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linhas; i ++)
                for(int j =0; j < Tab.Colunas; j++)
                    if (mat[i, j])
                        return true;
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
