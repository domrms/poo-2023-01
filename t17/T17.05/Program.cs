namespace T17._05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Acougueiro açougueiro = new Acougueiro();
            Padeiro padeiro = new Padeiro();
            Professor professor = new Professor();
            Advogado advogado = new Advogado();

            // Exibindo informações
            Console.WriteLine("Trabalhadores:");
            Console.WriteLine($"- {açougueiro.Profissao}");
            Console.WriteLine($"- {padeiro.Profissao}");
            Console.WriteLine($"- {professor.Profissao}");
            Console.WriteLine($"- {advogado.Profissao}");

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}