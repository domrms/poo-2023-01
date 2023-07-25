namespace T11._07
{
    public class Palavra
    {
        public List<Letra> Letras { get; set; }

        public Palavra(string palavra)
        {
            Letras = new List<Letra>();
            foreach (char caractere in palavra)
            {
                Letra letra = new Letra(caractere);
                Letras.Add(letra);
            }
        }
    }
}
