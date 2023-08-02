namespace t08._06
{
    public class Pais
    {
        public string Nome { get; set; }
        public Cidade Capital { get; set; }

        private static void Main(string[] args)
        {
            Pais pais = new Pais();
            pais.Nome = "Brasil";

            Cidade cidade = new Cidade();
            cidade.Nome = "Brasília";
            cidade.PaisCorrespondente = pais;

            pais.Capital = cidade;
            Console.WriteLine(pais.Nome);
        }
    }
}