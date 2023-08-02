namespace Cartas
{
    public class Carta
    {
        public string Nome { get; set; }

        public Carta(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}