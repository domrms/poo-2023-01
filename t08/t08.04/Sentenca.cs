namespace t08._04
{
    public class Sentenca
    {
        private static void Main(string[] args)
        {
            // Criação do texto
            Texto texto = new Texto();

            // Criação de parágrafos
            Paragrafo paragrafo1 = new Paragrafo();
            paragrafo1.AdicionarSentenca("Primeira sentença do parágrafo 1.");
            paragrafo1.AdicionarSentenca("Segunda sentença do parágrafo 1.");

            Paragrafo paragrafo2 = new Paragrafo();
            paragrafo2.AdicionarSentenca("Primeira sentença do parágrafo 2.");

            // Adição dos parágrafos ao texto
            texto.AdicionarParagrafo(paragrafo1);
            texto.AdicionarParagrafo(paragrafo2);

            // Exibição do texto
            texto.ExibirTexto();
        }
    }
}