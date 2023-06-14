namespace Trabalhos.T08
{
    public class Paragrafo
    {
        private List<string> sentencas;

        public Paragrafo()
        {
            sentencas = new List<string>();
        }

        public void AdicionarSentenca(string sentenca)
        {
            sentencas.Add(sentenca);
        }
        public void ExibirParagrafo()
        {
            foreach (string sentenca in sentencas)
            {
                Console.WriteLine(sentenca);
            }
        }
    }
}
