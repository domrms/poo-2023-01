namespace parquediversoes
{
    public class Ocorrencia
    {
        public string Tipo { get; set; }
        public DateTime InstanteTempo { get; set; }
        public string Descricao { get; set; }

        public Ocorrencia(string tipo, DateTime instanteTempo, string descricao)
        {
            Tipo = tipo;
            InstanteTempo = instanteTempo;
            Descricao = descricao;
        }
    }
}