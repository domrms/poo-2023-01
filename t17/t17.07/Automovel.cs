namespace t17._07
{
    public class Automovel
    {
        public Marca Marca { get; }
        public Modelo Modelo { get; }
        public int Ano { get; }

        public Automovel(Marca marca, Modelo modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }
    }
}
