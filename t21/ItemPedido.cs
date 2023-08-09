namespace restaurante
{
    public class ItemPedido
    {
        public Prato Prato { get; set; }
        public int Quantidade { get; set; }
        public bool Devolvido { get; set; }
        public string Observacao { get; set; }
    }
}