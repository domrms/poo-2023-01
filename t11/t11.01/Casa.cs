namespace t11._01
{
    public class Casa
    {
        private List<Quarto> quartos;
        private List<Banheiro> banheiros;
        private List<Sala> salas;
        private List<Area> areas;
        private List<Garagem> garagens;

        public Casa()
        {
            quartos = new List<Quarto>();
            banheiros = new List<Banheiro>();
            salas = new List<Sala>();
            areas = new List<Area>();
            garagens = new List<Garagem>();
        }

        // Adiciona um quarto à casa
        public void AdicionarQuarto(Quarto quarto)
        {
            quartos.Add(quarto);
        }

        // Adiciona um banheiro à casa
        public void AdicionarBanheiro(Banheiro banheiro)
        {
            banheiros.Add(banheiro);
        }

        // Adiciona uma sala à casa
        public void AdicionarSala(Sala sala)
        {
            salas.Add(sala);
        }

        // Adiciona uma área à casa
        public void AdicionarArea(Area area)
        {
            areas.Add(area);
        }

        // Adiciona uma garagem à casa
        public void AdicionarGaragem(Garagem garagem)
        {
            garagens.Add(garagem);
        }

        // Método para exibir as partes da casa
        public void ExibirPartes()
        {
            Console.WriteLine("Quartos:");
            foreach (var quarto in quartos)
            {
                Console.WriteLine(quarto.Nome);
            }

            Console.WriteLine("Banheiros:");
            foreach (var banheiro in banheiros)
            {
                Console.WriteLine(banheiro.Nome);
            }

            Console.WriteLine("Salas:");
            foreach (var sala in salas)
            {
                Console.WriteLine(sala.Nome);
            }

            Console.WriteLine("Áreas:");
            foreach (var area in areas)
            {
                Console.WriteLine(area.Nome);
            }

            Console.WriteLine("Garagens:");
            foreach (var garagem in garagens)
            {
                Console.WriteLine(garagem.Nome);
            }
        }
    }
}