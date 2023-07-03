namespace T11._09
{
    public class Periodo
    {
        public Data DataInicial { get; set; }
        public Data DataFinal { get; set; }

        public Periodo(Data dataInicial, Data dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }
    }
}
