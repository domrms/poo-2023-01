namespace t11._10
{
    public class Floresta
    {
        public List<Arvore> Arvores { get; set; }

        public Floresta()
        {
            Arvores = new List<Arvore>();
        }

        public void AdicionarArvore(Arvore arvore)
        {
            Arvores.Add(arvore);
        }
    }
}