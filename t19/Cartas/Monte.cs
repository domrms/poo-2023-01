namespace Cartas
{
    public class Monte
    {
        public List<Carta> CartasDisponiveis { get; set; }

        public Monte()
        {
            CartasDisponiveis = new List<Carta>();
        }

        public void AdicionarCarta(Carta carta)
        {
            CartasDisponiveis.Add(carta);
        }

        public Carta RetirarCarta()
        {
            if (CartasDisponiveis.Count == 0)
                return null;

            int index = new Random().Next(CartasDisponiveis.Count);
            Carta carta = CartasDisponiveis[index];
            CartasDisponiveis.RemoveAt(index);
            return carta;
        }
    }
}
