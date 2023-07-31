namespace t17._06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Trabalhador trabalhador = new Trabalhador("João");
            Tarefa tarefa = new Tarefa("Limpeza");
            Hora pagamentoHora = new Hora(10);
            Mensal pagamentoMensal = new Mensal(2000);
            Contrato pagamentoContrato = new Contrato(5000);

            // Associando pagamentos à tarefa
            tarefa.AdicionarPagamento(pagamentoHora);
            tarefa.AdicionarPagamento(pagamentoMensal);
            tarefa.AdicionarPagamento(pagamentoContrato);

            // Exibindo informações
            Console.WriteLine($"Tarefa: {tarefa.Descricao}");
            Console.WriteLine($"Trabalhador: {trabalhador.Nome}");
            Console.WriteLine("Pagamentos:");
            foreach (Pagamento pagamento in tarefa.Pagamentos)
            {
                Console.WriteLine($"- {pagamento.GetType().Name}: {pagamento.Valor}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}