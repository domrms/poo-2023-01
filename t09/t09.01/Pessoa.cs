namespace t09._01
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public List<Habito> Habit { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome;
            Habit = new List<Habito>();
        }

        public void AdicionarHabito(Habito habito)
        {
            Habit.Add(habito);
        }
    }
}