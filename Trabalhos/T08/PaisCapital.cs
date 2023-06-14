namespace Trabalhos.T08
{
    public class PaisCapital
    {
        public string Nome { get; set; }
        public CidadeCapital Capital { get; set; }

        static void Main(string[] args)
        {
            PaisCapital pais = new PaisCapital();
            pais.Nome = "Brasil";

            CidadeCapital cidade = new CidadeCapital();
            cidade.Nome = "Brasília";
            cidade.PaisCorrespondente = pais;

            pais.Capital = cidade;
        }
    }
}
