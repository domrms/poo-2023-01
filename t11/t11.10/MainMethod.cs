namespace T11._10
{
    public class MainMethod
    {
        public static void Main()
        {
            TipoFolha tipo1 = new TipoFolha("Folha 1");
            TipoFolha tipo2 = new TipoFolha("Folha 2");

            Folha folha1 = new Folha(tipo1);
            Folha folha2 = new Folha(tipo2);

            Arvore arvore1 = new Arvore();
            arvore1.AdicionarFolha(folha1);

            Arvore arvore2 = new Arvore();
            arvore2.AdicionarFolha(folha2);

            Floresta floresta = new Floresta();
            floresta.AdicionarArvore(arvore1);
            floresta.AdicionarArvore(arvore2);

            Console.WriteLine("Floresta:");
            foreach (Arvore arvore in floresta.Arvores)
            {
                Console.WriteLine("Árvore:");
                foreach (Folha folha in arvore.Folhas)
                {
                    Console.WriteLine("- Folha: " + folha.Tipo.Nome);
                }
            }
        }
    }
}
