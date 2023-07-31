namespace t11._06
{
    public class MainMethod
    {
        public static void Main()
        {
            ItemCompra item1 = new ItemCompra { Nome = "Celular", Quantidade = 1 };
            ItemCompra item2 = new ItemCompra { Nome = "Notebook", Quantidade = 2 };

            Prestacao prestacao1 = new Prestacao { Valor = 1000, DataLimite = new DateTime(2023, 7, 31) };
            Prestacao prestacao2 = new Prestacao { Valor = 800, DataLimite = new DateTime(2023, 8, 31) };

            Carne carne = new Carne();
            carne.ItensCompra.Add(item1);
            carne.ItensCompra.Add(item2);
            carne.Prestacoes.Add(prestacao1);
            carne.Prestacoes.Add(prestacao2);

            Console.WriteLine("Itens da compra:");
            foreach (ItemCompra item in carne.ItensCompra)
            {
                Console.WriteLine("- Nome: " + item.Nome + ", Quantidade: " + item.Quantidade);
            }

            Console.WriteLine();

            Console.WriteLine("Prestações do carnê:");
            foreach (Prestacao prestacao in carne.Prestacoes)
            {
                Console.WriteLine("- Valor: " + prestacao.Valor + ", Data Limite: " + prestacao.DataLimite.ToShortDateString());
            }
        }
    }
}
