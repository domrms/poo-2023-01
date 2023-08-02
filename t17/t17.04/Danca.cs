namespace t17._04
{
    public class Danca
    {
        public string Nome { get; set; }
        public Musica Musica { get; private set; }

        public Danca(string nome)
        {
            Nome = nome;
        }

        public void SetMusica(Musica musica)
        {
            Musica = musica;
        }
    }
}