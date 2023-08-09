namespace restaurante
{
    public class Pedido
    {
        public DiaDaSemana Dia { get; set; }
        public DateTime Horario { get; set; }
        public DateTime HoraEntrega { get; set; }
        public Cliente Cliente { get; set; }
        public Garcom Garcom { get; set; }
        public List<ItemPedido> Itens { get; set; }
    }
}