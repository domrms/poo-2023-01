namespace t17._02
{
    public class Operacao
    {
        public string Tipo { get; set; }
        public DateTime DataHora { get; set; }

        public Operacao(string tipo, DateTime dataHora)
        {
            Tipo = tipo;
            DataHora = dataHora;
        }
    }
}