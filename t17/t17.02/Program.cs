namespace t17._02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Aeroporto aeroporto = new Aeroporto();
            Voo voo1 = new Voo("V001", TipoVoo.Decolagem);
            Voo voo2 = new Voo("V002", TipoVoo.Aterrissagem);
            Aviao aviao1 = new Aviao("A001");
            Aviao aviao2 = new Aviao("A002");
            Lugar lugar1 = new Lugar("L001");
            Lugar lugar2 = new Lugar("L002");
            Passageiro passageiro1 = new Passageiro("P001", "123456");
            Passageiro passageiro2 = new Passageiro("P002", "789012");
            Piloto piloto = new Piloto("PI001");
            Copiloto copiloto = new Copiloto("CP001");
            Aeromoca aeromoca1 = new Aeromoca("AM001");
            Aeromoca aeromoca2 = new Aeromoca("AM002");

            // Relacionando os objetos
            aeroporto.AdicionarVoo(voo1);
            aeroporto.AdicionarVoo(voo2);
            voo1.SetAviao(aviao1);
            voo2.SetAviao(aviao2);
            aviao1.AdicionarLugar(lugar1);
            aviao2.AdicionarLugar(lugar2);
            lugar1.SetPassageiro(passageiro1);
            lugar2.SetPassageiro(passageiro2);
            voo1.SetTripulacao(piloto, copiloto, aeromoca1);
            voo2.SetTripulacao(piloto, copiloto, aeromoca2);

            // Configurando informações do voo
            voo1.SetOperacao(new Operacao("Partida", new DateTime(2023, 7, 10, 10, 30, 0)));
            voo2.SetOperacao(new Operacao("Chegada", new DateTime(2023, 7, 10, 14, 45, 0)));

            // Exibindo informações
            Console.WriteLine("Aeroporto:");
            Console.WriteLine("- Voos:");
            foreach (Voo voo in aeroporto.Voos)
            {
                Console.WriteLine($"  - {voo.Codigo}");
                Console.WriteLine($"    - Tipo: {voo.Tipo}");
                Console.WriteLine($"    - Avião: {voo.Aviao.Codigo}");
                Console.WriteLine($"    - Lugares:");
                foreach (Lugar lugar in voo.Aviao.Lugares)
                {
                    Console.WriteLine($"      - {lugar.Codigo}");
                    Console.WriteLine($"        - Passageiro: {lugar.Passageiro?.Codigo ?? "Vazio"}");
                }
                Console.WriteLine($"    - Piloto: {voo.Piloto.Codigo}");
                Console.WriteLine($"    - Co-piloto: {voo.Copiloto.Codigo}");
                Console.WriteLine($"    - Aeromoças:");
                foreach (Aeromoca aeromoca in voo.Aeromocas)
                {
                    Console.WriteLine($"      - {aeromoca.Codigo}");
                }
                Console.WriteLine($"    - Operação: {voo.Operacao.Tipo}, Data e Hora: {voo.Operacao.DataHora}");
            }

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}