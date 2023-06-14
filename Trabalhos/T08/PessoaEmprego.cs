namespace Trabalhos.T08
{
    public class PessoaEmprego
    {
        public string Nome { get; set; }
        public Emprego Emprego { get; set; }

        public PessoaEmprego(string nome)
        {
            Nome = nome;
        }

        public void AtribuirEmprego(Emprego emprego)
        {
            Emprego = emprego;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Empresa empresa1 = new Empresa("Empresa A");
                Empresa empresa2 = new Empresa("Empresa B");

                Emprego emprego1 = new Emprego(2000, new DateTime(2023, 1, 1), new DateTime(2023, 12, 31), empresa1);
                Emprego emprego2 = new Emprego(3000, new DateTime(2023, 6, 1), new DateTime(2023, 12, 31), empresa2);

                PessoaEmprego pessoa1 = new PessoaEmprego("João");
                PessoaEmprego pessoa2 = new PessoaEmprego("Maria");

                pessoa1.AtribuirEmprego(emprego1);
                pessoa2.AtribuirEmprego(emprego2);

                Console.WriteLine("Pessoa 1:");
                Console.WriteLine("Nome: " + pessoa1.Nome);
                Console.WriteLine("Emprego: " + pessoa1.Emprego.Salario);
                Console.WriteLine("Empresa: " + pessoa1.Emprego.Empresa.Nome);
                Console.WriteLine();

                Console.WriteLine("Pessoa 2:");
                Console.WriteLine("Nome: " + pessoa2.Nome);
                Console.WriteLine("Emprego: " + pessoa2.Emprego.Salario);
                Console.WriteLine("Empresa: " + pessoa2.Emprego.Empresa.Nome);

                Console.ReadLine();
            }
        }

    }
}
