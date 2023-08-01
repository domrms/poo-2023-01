namespace Cartas
{
    public class Jogador
    {
        public string Nome { get; set; }
        public MaoJogador MaoAtual { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
            MaoAtual = new MaoJogador();
        }

        public Rodada RealizarJogada(Monte monte)
        {
            Carta cartaRetirada = monte.RetirarCarta();
            Carta cartaSubstituida = MaoAtual.Cartas.Count > 0 ? MaoAtual.Cartas[0] : null;

            if (cartaRetirada != null)
            {
                MaoAtual.SubstituirCarta(cartaSubstituida, cartaRetirada, monte);
            }

            return new Rodada(this, cartaRetirada, cartaSubstituida);
        }
    }
}
