namespace t11._04
{
    public class MainMethod
    {
        public static void Main()
        {
            Armario armario = new Armario();

            Prateleira prateleira1 = new Prateleira();
            armario.Prateleiras.Add(prateleira1);

            Compartimento compartimento1 = new Compartimento();
            compartimento1.Livros.Add("Livro 1");
            compartimento1.Livros.Add("Livro 2");
            compartimento1.CDs.Add("CD 1");
            compartimento1.CDs.Add("CD 2");
            compartimento1.CDs.Add("CD 3");
            prateleira1.Compartimentos.Add(compartimento1);

            Prateleira prateleira2 = new Prateleira();
            armario.Prateleiras.Add(prateleira2);

            Compartimento compartimento2 = new Compartimento();
            compartimento2.Livros.Add("Livro 3");
            compartimento2.CDs.Add("CD 4");
            compartimento2.CDs.Add("CD 5");
            compartimento2.CDs.Add("CD 6");
            compartimento2.CDs.Add("CD 7");
            compartimento2.CDs.Add("CD 8");
            prateleira2.Compartimentos.Add(compartimento2);

            // Exemplo de exibição dos objetos no armário
            foreach (Prateleira prateleira in armario.Prateleiras)
            {
                Console.WriteLine("Prateleira:");
                foreach (Compartimento compartimento in prateleira.Compartimentos)
                {
                    Console.WriteLine("- Compartimento:");
                    Console.WriteLine("   Livros:");
                    foreach (string livro in compartimento.Livros)
                    {
                        Console.WriteLine("      " + livro);
                    }
                    Console.WriteLine("   CDs:");
                    foreach (string cd in compartimento.CDs)
                    {
                        Console.WriteLine("      " + cd);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}