namespace Cartas
{
    public class Rodada
    {
        public Jogador Jogador { get; set; }
        public Carta CartaRetirada { get; set; }
        public Carta CartaSubstituida { get; set; }

        public Rodada(Jogador jogador, Carta cartaRetirada, Carta cartaSubstituida)
        {
            Jogador = jogador;
            CartaRetirada = cartaRetirada;
            CartaSubstituida = cartaSubstituida;
        }

        public override string ToString()
        {
            string retirada = CartaRetirada != null ? $"({CartaRetirada})" : "";
            string substituida = CartaSubstituida != null ? $" por ({CartaSubstituida})" : "";
            return $"{Jogador.Nome} jogou{retirada}{substituida}";
        }
    }
}