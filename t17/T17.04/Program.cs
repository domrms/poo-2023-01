namespace T17._04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Festa festa = new Festa();
            Convidado convidado1 = new Convidado("João");
            Convidado convidado2 = new Convidado("Maria");
            Danca danca1 = new Danca("Salsa");
            Danca danca2 = new Danca("Forró");
            Musica musica1 = new Musica("Despacito");
            Musica musica2 = new Musica("Asa Branca");

            // Relacionando os objetos
            festa.AdicionarConvidado(convidado1);
            festa.AdicionarConvidado(convidado2);
            festa.AdicionarDanca(danca1);
            festa.AdicionarDanca(danca2);
            danca1.SetMusica(musica1);
            danca2.SetMusica(musica2);
            festa.AssociarConvidadoDanca(convidado1, danca1);
            festa.AssociarConvidadoDanca(convidado2, danca2);

            // Exibindo informações
            Console.WriteLine("Festa:");
            Console.WriteLine("- Convidados:");
            foreach (Convidado convidado in festa.Convidados)
            {
                Console.WriteLine($"  - {convidado.Nome}");
                Console.WriteLine($"    - Dança: {festa.ObterDancaPorConvidado(convidado)?.Nome ?? "Nenhuma"}");
            }
            Console.WriteLine("- Danças:");
            foreach (Danca danca in festa.Dancas)
            {
                Console.WriteLine($"  - {danca.Nome}");
                Console.WriteLine($"    - Música: {danca.Musica?.Nome ?? "Nenhuma"}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}
