namespace restaurante
{
    public class Entrega
    {
        public Pedido Pedido { get; set; }
        public DateTime HorarioEntrega { get; set; }
        public Domicilio Domicilio { get; set; }
        public Entregador Entregador { get; set; }
    }
}