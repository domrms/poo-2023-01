namespace T17._07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Maria");
            Marca marca1 = new Marca("Ford");
            Marca marca2 = new Marca("Chevrolet");
            Modelo modelo1 = new Modelo("Fiesta");
            Modelo modelo2 = new Modelo("Cruze");
            Automovel automovel1 = new Automovel(marca1, modelo1, 2015);
            Automovel automovel2 = new Automovel(marca2, modelo2, 2018);

            // Relacionando os objetos
            pessoa1.AdicionarAutomovel(automovel1);
            pessoa2.AdicionarAutomovel(automovel2);

            // Exibindo informações
            Console.WriteLine("Pessoas:");
            Console.WriteLine($"- {pessoa1.Nome}");
            Console.WriteLine($"  - Automóvel: {pessoa1.Automovel.Marca.Nome} {pessoa1.Automovel.Modelo.Nome} ({pessoa1.Automovel.Ano})");
            Console.WriteLine($"- {pessoa2.Nome}");
            Console.WriteLine($"  - Automóvel: {pessoa2.Automovel.Marca.Nome} {pessoa2.Automovel.Modelo.Nome} ({pessoa2.Automovel.Ano})");

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}