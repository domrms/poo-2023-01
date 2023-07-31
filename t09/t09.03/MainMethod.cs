namespace t09._03
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando um círculo
            Circulo circulo = new Circulo(3, 4, 5);

            // Exibindo os dados do círculo
            Console.WriteLine("Círculo inicial:");
            Console.WriteLine($"Posição do centro: ({circulo.X}, {circulo.Y})");
            Console.WriteLine($"Raio: {circulo.Raio}");

            // Transladando o círculo
            circulo.Transladar(2, -1);

            // Exibindo os dados do círculo após a translação
            Console.WriteLine("\nCírculo após a translação:");
            Console.WriteLine($"Posição do centro: ({circulo.X}, {circulo.Y})");
            Console.WriteLine($"Raio: {circulo.Raio}");
        }
    }
}
