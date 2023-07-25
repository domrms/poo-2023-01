namespace T10
{
    public class MainMethod
    {
        static void Main()
        {
            Homem homem = new Homem { Nome = "João", Idade = 30 };
            Bicicleta bicicleta = new Bicicleta { Marca = "Caloi", Modelo = "XRT" };

            HomemNaBicicleta homemNaBicicleta = new HomemNaBicicleta(homem, bicicleta);
            homemNaBicicleta.Pedalar();
        }
    }
}
