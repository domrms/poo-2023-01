namespace T11._05
{
    public class MainMethod
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("João", PapelFuncionario.Funcionario);
            Funcionario funcionario2 = new Funcionario("Maria", PapelFuncionario.Gerente);
            Funcionario funcionario3 = new Funcionario("Pedro", PapelFuncionario.Funcionario);

            Funcionario[] funcionarios = { funcionario1, funcionario2, funcionario3 };

            Lanchonete lanchonete = new Lanchonete(funcionarios);

            Console.WriteLine("Gerente da lanchonete: " + lanchonete.Gerente.Nome);
            Console.WriteLine("Funcionários da lanchonete:");
            foreach (Funcionario funcionario in lanchonete.Funcionarios)
            {
                Console.WriteLine("- " + funcionario.Nome);
            }
        }
    }
}