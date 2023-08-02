namespace t09._10
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Transacao> Transacoes { get; set; }
    }
}