namespace T17._11
{
    public class Prova
    {
        public string Nome { get; }
        public Avaliacao Avaliacao { get; }
        public Aluno Aluno { get; }

        public Prova(Avaliacao avaliacao, Aluno aluno)
        {
            Nome = $"Prova de {avaliacao.Nome}";
            Avaliacao = avaliacao;
            Aluno = aluno;
        }
    }
}
