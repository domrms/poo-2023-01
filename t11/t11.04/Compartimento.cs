namespace t11._04
{
    public class Compartimento
    {
        public List<string> Livros { get; set; }
        public List<string> CDs { get; set; }

        public Compartimento()
        {
            Livros = new List<string>();
            CDs = new List<string>();
        }
    }
}
