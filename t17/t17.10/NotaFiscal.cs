namespace t17._10
{
    public class NotaFiscal
    {
        public List<ItemNotaFiscal> Itens { get; }

        public NotaFiscal()
        {
            Itens = new List<ItemNotaFiscal>();
        }

        public void AdicionarItem(Produto produto)
        {
            ItemNotaFiscal item = new ItemNotaFiscal(produto, produto.Quantidade);
            Itens.Add(item);
        }
    }
}