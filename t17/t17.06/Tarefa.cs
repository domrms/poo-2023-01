namespace t17._06
{
    public class Tarefa
    {
        public string Descricao { get; set; }
        public List<Pagamento> Pagamentos { get; set; }

        public Tarefa(string descricao)
        {
            Descricao = descricao;
            Pagamentos = new List<Pagamento>();
        }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            Pagamentos.Add(pagamento);
        }
    }
}
