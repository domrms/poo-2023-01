namespace t11._09
{
    public class MainMethod
    {
        public static void Main()
        {
            Data dataInicial = new Data(new DateTime(2022, 1, 1));
            Data dataFinal = new Data(new DateTime(2022, 12, 31));

            Periodo periodo = new Periodo(dataInicial, dataFinal);

            Console.WriteLine("Período:");
            Console.WriteLine("Data Inicial: " + periodo.DataInicial.Valor);
            Console.WriteLine("Data Final: " + periodo.DataFinal.Valor);
        }
    }
}