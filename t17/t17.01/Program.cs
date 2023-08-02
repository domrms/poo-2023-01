namespace t17._01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando os objetos
            Computador computador = new Computador();
            PlacaMae placaMae = new PlacaMae();
            Mouse mouse = new Mouse();
            Teclado teclado = new Teclado();
            Monitor monitor = new Monitor();
            CPU cpu = new CPU();
            Memoria memoria = new Memoria();

            // Montando o computador
            computador.PlacaMae = placaMae;
            placaMae.Mouse = mouse;
            placaMae.Teclado = teclado;
            placaMae.Monitor = monitor;
            placaMae.CPU = cpu;
            cpu.Memoria = memoria;

            // Acessando a memória através da CPU
            cpu.AcessarMemoria();

            // Exibindo a estrutura do computador
            Console.WriteLine("Estrutura do computador:");
            Console.WriteLine("Computador");
            Console.WriteLine("|- Placa Mãe");
            Console.WriteLine("|  |- Mouse");
            Console.WriteLine("|  |- Teclado");
            Console.WriteLine("|  |- Monitor");
            Console.WriteLine("|  |- CPU");
            Console.WriteLine("|     |- Memória");

            // Aguardando a entrada do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}