namespace T10
{
    public class Bicicleta
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

    }
    public class HomemNaBicicleta
    {
        private Homem homem;
        private Bicicleta bicicleta;

        public HomemNaBicicleta(Homem homem, Bicicleta bicicleta)
        {
            this.homem = homem;
            this.bicicleta = bicicleta;
        }

        public void Pedalar()
        {
            Console.WriteLine($"{homem.Nome} está pedalando a bicicleta {bicicleta.Marca} {bicicleta.Modelo}.");
        }
    }
}