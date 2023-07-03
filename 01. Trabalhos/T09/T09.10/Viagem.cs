namespace T09._10
{
    public class Viagem
    {
        public List<Cidade> Cidades { get; private set; }

        public Viagem(List<Cidade> cidades)
        {
            Cidades = cidades;
        }
    }
}
