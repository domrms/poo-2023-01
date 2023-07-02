namespace T08._13
{
    public class MainMethod
    {
        public static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa { Nome = "Empresa A" };
            Empresa empresa2 = new Empresa { Nome = "Empresa B" };

            Pessoa pessoa1 = new Pessoa { Nome = "João" };
            Pessoa pessoa2 = new Pessoa { Nome = "Maria" };

            empresa1.Contratar(pessoa1);
            empresa1.Contratar(pessoa2);
            empresa2.Contratar(pessoa2);

            Console.WriteLine("Empregados da Empresa A:");
            foreach (var empregado in empresa1.Empregados)
            {
                Console.WriteLine(empregado.Nome);
            }

            Console.WriteLine("\nEmpregados da Empresa B:");
            foreach (var empregado in empresa2.Empregados)
            {
                Console.WriteLine(empregado.Nome);
            }

            Console.WriteLine("\nEmpregadores do João:");
            foreach (var empregador in pessoa1.Empregadores)
            {
                Console.WriteLine(empregador.Nome);
            }

            Console.WriteLine("\nEmpregadores da Maria:");
            foreach (var empregador in pessoa2.Empregadores)
            {
                Console.WriteLine(empregador.Nome);
            }
        }
    }
}
