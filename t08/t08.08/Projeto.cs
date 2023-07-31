namespace t08._08
{
    public class Projeto
    {
        public string Nome { get; set; }
        public List<Pessoa> PessoasEnvolvidas { get; set; }

        public Projeto()
        {
            PessoasEnvolvidas = new List<Pessoa>();
        }
        static void Main(string[] args)
        {
            Projeto projeto = new Projeto();
            projeto.Nome = "Projeto A";

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";
            projeto.PessoasEnvolvidas.Add(pessoa1);

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Maria";
            projeto.PessoasEnvolvidas.Add(pessoa2);

            Pessoa pessoa3 = new Pessoa();
            pessoa3.Nome = "Carlos";
            projeto.PessoasEnvolvidas.Add(pessoa3);
        }

    }
}