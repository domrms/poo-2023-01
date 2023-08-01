namespace Cartas
{
    public class MaoJogador
    {
        public List<Carta> Cartas { get; set; }

        public MaoJogador()
        {
            Cartas = new List<Carta>();
        }

        public void AdicionarCarta(Carta carta)
        {
            Cartas.Add(carta);
        }

        public void SubstituirCarta(Carta cartaAntiga, Carta cartaNova, Monte monte)
        {
            Cartas.Remove(cartaAntiga);
            Cartas.Add(cartaNova);

            if (monte != null && monte.CartasDisponiveis.Contains(cartaNova))
            {
                monte.CartasDisponiveis.Remove(cartaNova);
                monte.CartasDisponiveis.Add(cartaAntiga);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", Cartas);
        }
    }
}
