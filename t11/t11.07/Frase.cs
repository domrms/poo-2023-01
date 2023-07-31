namespace t11._07
{
    public class Frase
    {
        public List<Palavra> Palavras { get; set; }

        public Frase(string frase)
        {
            Palavras = new List<Palavra>();

            string[] palavrasSeparadas = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string palavra in palavrasSeparadas)
            {
                Palavra novaPalavra = new Palavra(palavra);
                Palavras.Add(novaPalavra);
            }
        }
    }
}