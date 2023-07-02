namespace T08._13
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public List<Empresa> Empregadores { get; } = new List<Empresa>();

        public void AdicionarEmpregador(Empresa empregador)
        {
            Empregadores.Add(empregador);
        }
    }
}