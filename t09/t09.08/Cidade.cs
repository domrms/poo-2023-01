namespace t09._10
{
    public class Cidade
    {
        public string Nome { get; private set; }
        public List<Armazem> Pedidos { get; private set; }

        public Cidade(string nome)
        {
            Nome = nome;
            Pedidos = new List<Armazem>();
        }

        public void AdicionarPedido(Armazem pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
