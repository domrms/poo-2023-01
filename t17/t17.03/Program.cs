namespace t17._03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Lanchonete lanchonete = new Lanchonete();
            Sanduiche sanduiche1 = new Sanduiche("Sanduíche 1");
            Sanduiche sanduiche2 = new Sanduiche("Sanduíche 2");
            Acompanhamento acompanhamento1 = new Acompanhamento("Ovo");
            Acompanhamento acompanhamento2 = new Acompanhamento("Salada");
            Acompanhamento acompanhamento3 = new Acompanhamento("Queijo");
            Pedido pedido1 = new Pedido();
            Pedido pedido2 = new Pedido();
            Bebida bebida1 = new Bebida("Refrigerante");
            Bebida bebida2 = new Bebida("Suco");

            // Relacionando os objetos
            lanchonete.AdicionarPedido(pedido1);
            lanchonete.AdicionarPedido(pedido2);
            pedido1.AdicionarDetalhe(new Detalhe("Detalhe 1", acompanhamento1));
            pedido1.AdicionarDetalhe(new Detalhe("Detalhe 2", acompanhamento2));
            pedido2.AdicionarDetalhe(new Detalhe("Detalhe 3", acompanhamento3));
            pedido1.AdicionarBebida(bebida1);
            pedido2.AdicionarBebida(bebida2);

            // Exibindo informações
            Console.WriteLine("Lanchonete:");
            Console.WriteLine("- Pedidos:");
            foreach (Pedido pedido in lanchonete.Pedidos)
            {
                Console.WriteLine($"  - Pedido {pedido.Numero}");
                Console.WriteLine("    - Detalhes:");
                foreach (Detalhe detalhe in pedido.Detalhes)
                {
                    Console.WriteLine($"      - {detalhe.Descricao}");
                    Console.WriteLine($"        - Acompanhamento: {detalhe.Acompanhamento?.Nome ?? "Nenhum"}");
                }
                Console.WriteLine("    - Bebida:");
                Console.WriteLine($"      - {pedido.Bebida.Nome}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}