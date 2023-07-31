namespace t09._01
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando uma pessoa
            Pessoa pessoa1 = new Pessoa("Fulano");

            // Criando hábitos
            Habito habit1 = new Habito("Correr");
            Habito habit2 = new Habito("Ler");
            Habito habit3 = new Habito("Meditar");

            // Associando hábitos à pessoa
            pessoa1.AdicionarHabito(habit1);
            pessoa1.AdicionarHabito(habit2);
            pessoa1.AdicionarHabito(habit3);

            // Exibindo os hábitos da pessoa
            Console.WriteLine("Hábitos da pessoa:");
            foreach (var habit in pessoa1.Habit)
            {
                Console.WriteLine(habit.Nome);
            }
        }
    }
}
