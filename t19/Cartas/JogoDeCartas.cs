namespace Cartas
{
    public class JogoDeCartas
    {
        private List<Jogador> jogadores;
        private Monte monte;
        private ConfiguracaoCartas configuracao;

        public JogoDeCartas(List<string> nomesJogadores)
        {
            jogadores = new List<Jogador>();
            foreach (var nome in nomesJogadores)
            {
                jogadores.Add(new Jogador(nome));
            }

            monte = new Monte();
            configuracao = new ConfiguracaoCartas();
            IniciarJogo();
        }

        private void IniciarJogo()
        {
        }

        public List<Rodada> Jogar()
        {
            var rodadas = new List<Rodada>();
            foreach (var jogador in jogadores)
            {
                var rodada = jogador.RealizarJogada(monte);
                rodadas.Add(rodada);
            }

            return rodadas;
        }
    }
}