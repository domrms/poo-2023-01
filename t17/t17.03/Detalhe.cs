namespace t17._03
{
    public class Detalhe
    {
        public string Descricao { get; set; }
        public Acompanhamento Acompanhamento { get; set; }

        public Detalhe(string descricao, Acompanhamento acompanhamento)
        {
            Descricao = descricao;
            Acompanhamento = acompanhamento;
        }
    }
}
