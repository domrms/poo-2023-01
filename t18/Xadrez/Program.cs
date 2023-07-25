namespace Xadrez
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Partida partida = new Partida();

            // Adicionando lances à partida
            partida.AdicionarLance(new Lance(new Posicao(2, 2), new Posicao(4, 2), "Branco"));
            partida.AdicionarLance(new Lance(new Posicao(7, 2), new Posicao(5, 2), "Preto"));
            partida.AdicionarLance(new Lance(new Posicao(1, 3), new Posicao(3, 3), "Branco"));
            partida.AdicionarLance(new Lance(new Posicao(8, 7), new Posicao(6, 7), "Preto"));

            // Exibindo informações da partida
            Console.WriteLine("Partida de Xadrez:");
            Console.WriteLine("Lances:");
            foreach (Lance lance in partida.Lances)
            {
                Console.WriteLine($"- Jogador: {lance.Jogador}");
                Console.WriteLine($"  Origem: {lance.Origem.X}, {lance.Origem.Y}");
                Console.WriteLine($"  Destino: {lance.Destino.X}, {lance.Destino.Y}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}