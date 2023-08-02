namespace t09._04
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando um ponto
            Ponto ponto = new Ponto(3, 4);

            // Exibindo a posição do ponto
            Console.WriteLine("Ponto inicial:");
            Console.WriteLine($"Posição: ({ponto.X}, {ponto.Y})");

            // Transladando o ponto
            ponto.Transladar(2, -1);

            // Exibindo a posição do ponto após a translação
            Console.WriteLine("\nPonto após a translação:");
            Console.WriteLine($"Posição: ({ponto.X}, {ponto.Y})");

            // Criando um círculo com centro no ponto criado anteriormente
            Circulo circulo = new Circulo(ponto, 5);

            // Exibindo os dados do círculo
            Console.WriteLine("\nCírculo:");
            Console.WriteLine($"Centro: ({circulo.Centro.X}, {circulo.Centro.Y})");
            Console.WriteLine($"Raio: {circulo.Raio}");

            // Transladando o círculo
            circulo.Transladar(1, 3);

            // Exibindo os dados do círculo após a translação
            Console.WriteLine("\nCírculo após a translação:");
            Console.WriteLine($"Centro: ({circulo.Centro.X}, {circulo.Centro.Y})");
            Console.WriteLine($"Raio: {circulo.Raio}");
        }
    }
}