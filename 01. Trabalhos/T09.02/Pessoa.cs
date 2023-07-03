namespace T09._02
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public List<Habito> Habit { get; private set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Habit = new List<Habito>();
        }

        public void AdicionarHabito(string descricao)
        {
            Habit.Add(new Habito(descricao));
        }

    }
}