namespace t17._11
{
    public class Avaliacao
    {
        public string Nome { get; }
        public string Descricao { get; }
        public DateTime Data { get; }

        public Avaliacao(string nome, string descricao, DateTime data)
        {
            Nome = nome;
            Descricao = descricao;
            Data = data;
        }
    }
}