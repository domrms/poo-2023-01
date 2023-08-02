namespace t11._08
{
    public class MainMethod
    {
        public static void Main(string[] args)
        {
            Preco preco1 = new Preco(10, Moeda.Dolar);
            Preco preco2 = new Preco(25.5m, Moeda.Real);

            Console.WriteLine("Preço 1: " + preco1);
            Console.WriteLine("Preço 2: " + preco2);
        }
    }
}