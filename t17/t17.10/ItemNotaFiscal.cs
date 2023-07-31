namespace t17._10
{
    public class ItemNotaFiscal
    {
        public Produto Produto { get; }
        public int Quantidade { get; }

        public ItemNotaFiscal(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}
