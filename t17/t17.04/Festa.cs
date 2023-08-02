namespace t17._04
{
    public class Festa
    {
        public List<Convidado> Convidados { get; set; }
        public List<Danca> Dancas { get; set; }

        public Festa()
        {
            Convidados = new List<Convidado>();
            Dancas = new List<Danca>();
        }

        public void AdicionarConvidado(Convidado convidado)
        {
            Convidados.Add(convidado);
        }

        public void AdicionarDanca(Danca danca)
        {
            Dancas.Add(danca);
        }

        public void AssociarConvidadoDanca(Convidado convidado, Danca danca)
        {
            convidado.Danca = danca;
        }

        public Danca ObterDancaPorConvidado(Convidado convidado)
        {
            return convidado.Danca;
        }
    }
}