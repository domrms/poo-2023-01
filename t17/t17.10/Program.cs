namespace t17._10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Produto produto1 = new Produto("Camiseta", 2, 29.99m);
            Produto produto2 = new Produto("Calça", 1, 59.99m);
            Produto produto3 = new Produto("Tênis", 1, 129.99m);

            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.AdicionarItem(produto1);
            notaFiscal.AdicionarItem(produto2);
            notaFiscal.AdicionarItem(produto3);

            // Exibindo informações
            Console.WriteLine("Nota Fiscal:");
            foreach (ItemNotaFiscal item in notaFiscal.Itens)
            {
                Console.WriteLine($"- Produto: {item.Produto.Nome}");
                Console.WriteLine($"  Quantidade: {item.Quantidade}");
                Console.WriteLine($"  Preço Unitário: {item.Produto.PrecoUnitario}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}