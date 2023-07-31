namespace t11._06
{
    public class Carne
    {
        public List<ItemCompra> ItensCompra { get; set; }
        public List<Prestacao> Prestacoes { get; set; }

        public Carne()
        {
            ItensCompra = new List<ItemCompra>();
            Prestacoes = new List<Prestacao>();
        }
    }
}
