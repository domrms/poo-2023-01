namespace t17._01
{
    public class CPU
    {
        public required Memoria Memoria { get; set; }

        public void AcessarMemoria()
        {
            Console.WriteLine("A CPU está acessando a memória.");
        }
    }
}
