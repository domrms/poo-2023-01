namespace t11._10
{
    public class Arvore
    {
        public List<Folha> Folhas { get; set; }

        public Arvore()
        {
            Folhas = new List<Folha>();
        }

        public void AdicionarFolha(Folha folha)
        {
            Folhas.Add(folha);
        }
    }
}