namespace Trabalhos.T08
{
    public class PaisCapital02
    {
        public string Nome { get; set; }
        public List<CidadeCapital02> Cidades { get; set; }
        public CidadeCapital02 Capital { get; set; }

        public PaisCapital02()
        {
            Cidades = new List<CidadeCapital02>();
        }

        static void Main(string[] args)
        {
            PaisCapital02 pais = new PaisCapital02();
            pais.Nome = "Brasil";

            CidadeCapital02 cidade1 = new CidadeCapital02();
            cidade1.Nome = "São Paulo";
            cidade1.PaisCorrespondente = pais;
            pais.Cidades.Add(cidade1);

            CidadeCapital02 cidade2 = new CidadeCapital02();
            cidade2.Nome = "Rio de Janeiro";
            cidade2.PaisCorrespondente = pais;
            pais.Cidades.Add(cidade2);

            pais.Capital = cidade1;
        }
    }
}
