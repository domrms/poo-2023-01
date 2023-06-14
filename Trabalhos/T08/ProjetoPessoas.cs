namespace Trabalhos.T08
{
    public class ProjetoPessoas
    {
        public string Nome { get; set; }
        public List<Pessoa> PessoasEnvolvidas { get; set; }

        public ProjetoPessoas()
        {
            PessoasEnvolvidas = new List<Pessoa>();
        }
        static void Main(string[] args)
        {
            ProjetoPessoas projeto = new ProjetoPessoas();
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
