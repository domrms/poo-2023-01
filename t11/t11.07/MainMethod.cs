namespace T11._07
{
    public class MainMethod
    {
        public static void Main()
        {
            string texto = "Esta é uma frase de exemplo";
            Frase frase = new Frase(texto);

            Console.WriteLine("Conteúdo da frase: " + texto);

            Console.WriteLine("Palavras na frase:");
            foreach (Palavra palavra in frase.Palavras)
            {
                Console.WriteLine("- " + string.Join("", palavra.Letras));
            }
        }
    }
}
