namespace t09._10
{
    public class MainMethod
    {
        private static void Main()
        {
            // Criando os clientes
            Cliente cliente1 = new Cliente { Id = 1, Nome = "Cliente 1" };
            Cliente cliente2 = new Cliente { Id = 2, Nome = "Cliente 2" };

            // Criando os fornecedores
            Fornecedor fornecedor1 = new Fornecedor { Id = 1, Nome = "Fornecedor 1" };
            Fornecedor fornecedor2 = new Fornecedor { Id = 2, Nome = "Fornecedor 2" };

            // Criando as transações
            Transacao transacao1 = new Transacao { Id = 1, Cliente = cliente1, Fornecedor = fornecedor1 };
            Transacao transacao2 = new Transacao { Id = 2, Cliente = cliente1, Fornecedor = fornecedor2 };
            Transacao transacao3 = new Transacao { Id = 3, Cliente = cliente2, Fornecedor = fornecedor2 };

            // Associando as transações aos clientes
            cliente1.Transacoes = new List<Transacao> { transacao1, transacao2 };
            cliente2.Transacoes = new List<Transacao> { transacao3 };

            // Associando as transações aos fornecedores
            fornecedor1.Transacoes = new List<Transacao> { transacao1 };
            fornecedor2.Transacoes = new List<Transacao> { transacao2, transacao3 };

            // Exibindo as informações
            Console.WriteLine("Transações do Cliente 1:");
            foreach (Transacao transacao in cliente1.Transacoes)
            {
                Console.WriteLine("ID da transação: " + transacao.Id);
                Console.WriteLine("Fornecedor: " + transacao.Fornecedor.Nome);
                Console.WriteLine();
            }

            Console.WriteLine("Transações do Cliente 2:");
            foreach (Transacao transacao in cliente2.Transacoes)
            {
                Console.WriteLine("ID da transação: " + transacao.Id);
                Console.WriteLine("Fornecedor: " + transacao.Fornecedor.Nome);
                Console.WriteLine();
            }

            Console.WriteLine("Transações do Fornecedor 1:");
            foreach (Transacao transacao in fornecedor1.Transacoes)
            {
                Console.WriteLine("ID da transação: " + transacao.Id);
                Console.WriteLine("Cliente: " + transacao.Cliente.Nome);
                Console.WriteLine();
            }

            Console.WriteLine("Transações do Fornecedor 2:");
            foreach (Transacao transacao in fornecedor2.Transacoes)
            {
                Console.WriteLine("ID da transação: " + transacao.Id);
                Console.WriteLine("Cliente: " + transacao.Cliente.Nome);
                Console.WriteLine();
            }
        }
    }
}