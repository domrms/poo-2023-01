namespace T09._10
{
    public class CaixeiroViajante
    {
        public List<Viagem> Viagens { get; private set; }

        public CaixeiroViajante()
        {
            Viagens = new List<Viagem>();
        }

        public void AdicionarViagem(Viagem viagem)
        {
            Viagens.Add(viagem);
        }

        public void ListarViagens()
        {
            Console.WriteLine("Lista de viagens do caixeiro-viajante:");
            foreach (Viagem viagem in Viagens)
            {
                Console.WriteLine("Viagem:");
                foreach (Cidade cidade in viagem.Cidades)
                {
                    Console.WriteLine($"Cidade: {cidade.Nome}");
                    Console.WriteLine("Pedidos de Armazéns:");
                    foreach (Armazem pedido in cidade.Pedidos)
                    {
                        Console.WriteLine(pedido.Nome);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}