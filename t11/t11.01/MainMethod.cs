namespace t11._01
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criação de uma casa
            Casa minhaCasa = new Casa();

            // Adicionando partes à casa
            minhaCasa.AdicionarQuarto(new Quarto { Nome = "Quarto 1" });
            minhaCasa.AdicionarQuarto(new Quarto { Nome = "Quarto 2" });
            minhaCasa.AdicionarBanheiro(new Banheiro { Nome = "Banheiro 1" });
            minhaCasa.AdicionarSala(new Sala { Nome = "Sala de Estar" });
            minhaCasa.AdicionarArea(new Area { Nome = "Área de Lazer" });
            minhaCasa.AdicionarGaragem(new Garagem { Nome = "Garagem" });

            // Exibindo as partes da casa
            minhaCasa.ExibirPartes();
        }
    }
}