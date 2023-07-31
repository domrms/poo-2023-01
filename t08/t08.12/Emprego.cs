namespace T08._12
{
    public class Emprego
    {
        public decimal Salario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Empresa Empresa { get; set; }

        public Emprego(decimal salario, DateTime inicio, DateTime fim, Empresa empresa)
        {
            Salario = salario;
            Inicio = inicio;
            Fim = fim;
            Empresa = empresa;
        }

        public static void Main() { }
    }
}
