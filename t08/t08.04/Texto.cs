namespace t08._04
{
    public class Texto
    {
        private List<Paragrafo> paragrafos;

        public Texto()
        {
            paragrafos = new List<Paragrafo>();
        }

        public void AdicionarParagrafo(Paragrafo paragrafo)
        {
            paragrafos.Add(paragrafo);
            ExibirTexto();
        }
        public void ExibirTexto()
        {
            foreach (Paragrafo paragrafo in paragrafos)
            {
                paragrafo.ExibirParagrafo();
                Console.WriteLine();
            }
        }

    }
}