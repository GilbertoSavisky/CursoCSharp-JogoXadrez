namespace tabuleiro
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

        public abstract bool[,] MovimentosPossiveis();
    }
}
