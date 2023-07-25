namespace T17._09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Maria");
            Pessoa pessoa3 = new Pessoa("Carlos");
            Pessoa pessoa4 = new Pessoa("Ana");
            Comite comite1 = new Comite();
            Comite comite2 = new Comite();

            // Definindo presidentes dos comitês
            comite1.DefinirPresidentes(pessoa1, pessoa2, pessoa3);
            comite2.DefinirPresidentes(pessoa4, pessoa2);

            // Exibindo informações
            Console.WriteLine("Comitês:");
            Console.WriteLine($"Comitê 1: Presidentes");
            foreach (Pessoa presidente in comite1.Presidentes)
            {
                Console.WriteLine($"- {presidente.Nome}");
            }

            Console.WriteLine($"Comitê 2: Presidentes");
            foreach (Pessoa presidente in comite2.Presidentes)
            {
                Console.WriteLine($"- {presidente.Nome}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}