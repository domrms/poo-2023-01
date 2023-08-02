namespace t09._09
{
    public class MainMethod
    {
        private static void Main()
        {
            // Criando os pedidos
            Pedido pedido1 = new Pedido { Id = 1, Descricao = "Pedido 1" };
            Pedido pedido2 = new Pedido { Id = 2, Descricao = "Pedido 2" };
            Pedido pedido3 = new Pedido { Id = 3, Descricao = "Pedido 3" };

            // Criando os armazéns
            Armazem armazem1 = new Armazem { Id = 1, Nome = "Armazém 1", Pedidos = new List<Pedido> { pedido1 } };
            Armazem armazem2 = new Armazem { Id = 2, Nome = "Armazém 2", Pedidos = new List<Pedido> { pedido2, pedido3 } };

            // Criando as cidades e associando aos armazéns
            Cidade cidade1 = new Cidade { Id = 1, Nome = "Cidade 1", Armazem = armazem1 };
            Cidade cidade2 = new Cidade { Id = 2, Nome = "Cidade 2", Armazem = armazem2 };

            // Criando as viagens e associando as cidades
            Viagem viagem1 = new Viagem { Id = 1, Cidades = new List<Cidade> { cidade1, cidade2 } };
            Viagem viagem2 = new Viagem { Id = 2, Cidades = new List<Cidade> { cidade2, cidade1 } };

            // Criando o caixeiro-viajante e associando as viagens
            CaixeiroViajante caixeiro = new CaixeiroViajante { Viagens = new List<Viagem> { viagem1, viagem2 } };

            // Exibindo as informações
            foreach (Viagem viagem in caixeiro.Viagens)
            {
                Console.WriteLine("Viagem #" + viagem.Id);
                Console.WriteLine("Cidades:");
                foreach (Cidade cidade in viagem.Cidades)
                {
                    Console.WriteLine("- " + cidade.Nome);
                    Console.WriteLine("   Armazém: " + cidade.Armazem.Nome);
                    Console.WriteLine("   Pedidos:");
                    foreach (Pedido pedido in cidade.Armazem.Pedidos)
                    {
                        Console.WriteLine("   - " + pedido.Descricao);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}