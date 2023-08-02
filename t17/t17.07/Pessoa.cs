namespace t17._07
{
    public class Pessoa
    {
        public string Nome { get; }
        public Automovel Automovel { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public void AdicionarAutomovel(Automovel automovel)
        {
            Automovel = automovel;
        }
    }
}