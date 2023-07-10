namespace T17._03
{
    public class Lanchonete
    {
        public List<Pedido> Pedidos { get; set; }

        public Lanchonete()
        {
            Pedidos = new List<Pedido>();
        }

        public void AdicionarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
