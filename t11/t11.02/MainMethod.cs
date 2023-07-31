namespace t11._02
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criação de pessoas e cadeiras de exemplo
            Pessoa pessoa1 = new Pessoa { Nome = "João", Sexo = "Masculino" };
            Pessoa pessoa2 = new Pessoa { Nome = "Maria", Sexo = "Feminino" };

            Cadeira cadeira1 = new Cadeira { Proprietario = pessoa1.Nome };
            Cadeira cadeira2 = new Cadeira { Proprietario = pessoa2.Nome };

            // Exibição dos proprietários das cadeiras
            Console.WriteLine("Proprietário da Cadeira 1: " + cadeira1.Proprietario);
            Console.WriteLine("Proprietário da Cadeira 2: " + cadeira2.Proprietario);
        }
    }
}