namespace t11._05
{
    public class Lanchonete
    {
        public Funcionario Gerente { get; set; }
        public Funcionario[] Funcionarios { get; set; }

        public Lanchonete(Funcionario[] funcionarios)
        {
            if (funcionarios.Length < 2)
            {
                throw new ArgumentException("Uma lanchonete deve ter pelo menos 2 funcionários.");
            }

            Funcionarios = funcionarios;
            Gerente = EncontrarGerente();
        }

        private Funcionario EncontrarGerente()
        {
            foreach (Funcionario funcionario in Funcionarios)
            {
                if (funcionario.Papel == PapelFuncionario.Gerente)
                {
                    return funcionario;
                }
            }

            return null;
        }
    }
}