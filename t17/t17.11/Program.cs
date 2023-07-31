namespace t17._11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Avaliacao avaliacao1 = new Avaliacao("Prova 1", "Avaliação de Matemática", new DateTime(2023, 1, 10));
            Avaliacao avaliacao2 = new Avaliacao("Prova 2", "Avaliação de Ciências", new DateTime(2023, 2, 15));

            Aluno aluno1 = new Aluno("João");
            Aluno aluno2 = new Aluno("Maria");

            Prova prova1 = new Prova(avaliacao1, aluno1);
            Prova prova2 = new Prova(avaliacao1, aluno2);
            Prova prova3 = new Prova(avaliacao2, aluno1);

            // Exibindo informações
            Console.WriteLine("Sistema Acadêmico:");
            Console.WriteLine($"Avaliação: {avaliacao1.Nome}, Descrição: {avaliacao1.Descricao}, Data: {avaliacao1.Data.ToShortDateString()}");
            Console.WriteLine($"- Aluno: {prova1.Aluno.Nome}");
            Console.WriteLine($"  - Prova: {prova1.Nome}");
            Console.WriteLine($"- Aluno: {prova2.Aluno.Nome}");
            Console.WriteLine($"  - Prova: {prova2.Nome}");
            Console.WriteLine($"Avaliação: {avaliacao2.Nome}, Descrição: {avaliacao2.Descricao}, Data: {avaliacao2.Data.ToShortDateString()}");
            Console.WriteLine($"- Aluno: {prova3.Aluno.Nome}");
            Console.WriteLine($"  - Prova: {prova3.Nome}");

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}