namespace Xadrez
{
    public class Lance
    {
        public Posicao Origem { get; }
        public Posicao Destino { get; }
        public string Jogador { get; }

        public Lance(Posicao origem, Posicao destino, string jogador)
        {
            Origem = origem;
            Destino = destino;
            Jogador = jogador;
        }
    }
}
