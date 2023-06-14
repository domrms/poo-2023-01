namespace Trabalhos.T08
{
    public class Pais
    {
        public string Nome { get; set; }
        public List<Cidade> Cidades { get; set; }

        public Pais()
        {
            Cidades = new List<Cidade>();
        }

        static void Main(string[] args)
        {
            Pais pais = new Pais();
            pais.Nome = "Brasil";

            Cidade cidade1 = new Cidade();
            cidade1.Nome = "São Paulo";
            cidade1.PaisCorrespondente = pais;
            pais.Cidades.Add(cidade1);

            Cidade cidade2 = new Cidade();
            cidade2.Nome = "Rio de Janeiro";
            cidade2.PaisCorrespondente = pais;
            pais.Cidades.Add(cidade2);
        }
    }
}
