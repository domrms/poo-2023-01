namespace T11._05
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public PapelFuncionario Papel { get; set; }

        public Funcionario(string nome, PapelFuncionario papel)
        {
            Nome = nome;
            Papel = papel;
        }
    }

    public enum PapelFuncionario
    {
        Funcionario,
        Gerente
    }
}