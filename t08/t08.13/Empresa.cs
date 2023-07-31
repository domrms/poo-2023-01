namespace t08._13
{
    public class Empresa
    {
        public string Nome { get; set; }
        public List<Pessoa> Empregados { get; } = new List<Pessoa>();

        public void Contratar(Pessoa pessoa)
        {
            Empregados.Add(pessoa);
            pessoa.AdicionarEmpregador(this);
        }
    }
}
