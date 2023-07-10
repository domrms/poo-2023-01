namespace T17._08
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criando objetos
            Empregado ceo = new Empregado("John", "CEO");
            Empregado gerente1 = new Empregado("Alice", "Gerente");
            Empregado gerente2 = new Empregado("Bob", "Gerente");
            Empregado funcionario1 = new Empregado("Tom", "Funcionário");
            Empregado funcionario2 = new Empregado("Emma", "Funcionário");

            // Definindo hierarquia
            gerente1.AdicionarSubordinado(funcionario1);
            gerente1.AdicionarSubordinado(funcionario2);
            gerente2.AdicionarSubordinado(funcionario1);

            ceo.AdicionarSubordinado(gerente1);
            ceo.AdicionarSubordinado(gerente2);

            // Exibindo informações
            Console.WriteLine($"Empregado: {ceo.Nome}, Cargo: {ceo.Cargo}");
            Console.WriteLine($"Subordinados: {ceo.ObterQuantidadeSubordinados()}");
            Console.WriteLine($"- {gerente1.Nome}, Cargo: {gerente1.Cargo}");
            Console.WriteLine($"  - Subordinados: {gerente1.ObterQuantidadeSubordinados()}");
            Console.WriteLine($"- {gerente2.Nome}, Cargo: {gerente2.Cargo}");
            Console.WriteLine($"  - Subordinados: {gerente2.ObterQuantidadeSubordinados()}");
            Console.WriteLine($"- {funcionario1.Nome}, Cargo: {funcionario1.Cargo}");
            Console.WriteLine($"- {funcionario2.Nome}, Cargo: {funcionario2.Cargo}");

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}