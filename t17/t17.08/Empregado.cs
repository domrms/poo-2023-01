namespace T17._08
{
    public class Empregado
    {
        public string Nome { get; }
        public string Cargo { get; }
        public List<Empregado> Subordinados { get; }

        public Empregado(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
            Subordinados = new List<Empregado>();
        }

        public void AdicionarSubordinado(Empregado subordinado)
        {
            Subordinados.Add(subordinado);
        }

        public int ObterQuantidadeSubordinados()
        {
            return Subordinados.Count;
        }
    }
}
