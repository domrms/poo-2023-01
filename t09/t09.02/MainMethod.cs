namespace t09._02
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando uma pessoa
            Pessoa pessoa1 = new Pessoa("Fulano", 25);

            // Adicionando hábitos à pessoa
            pessoa1.AdicionarHabito("Correr");
            pessoa1.AdicionarHabito("Ler");
            pessoa1.AdicionarHabito("Meditar");

            // Exibindo os dados da pessoa e seus hábitos
            Console.WriteLine($"Nome: {pessoa1.Nome}");
            Console.WriteLine($"Idade: {pessoa1.Idade}");
            Console.WriteLine("Hábitos:");
            foreach (var habit in pessoa1.Habit)
            {
                Console.WriteLine(habit.Descricao);
            }
        }
    }
}
