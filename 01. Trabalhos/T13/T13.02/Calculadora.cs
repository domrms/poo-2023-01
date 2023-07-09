namespace T13._02
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Digite o primeiro número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro válido: ");
            }

            Console.WriteLine("Digite o segundo número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro válido: ");
            }

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Entrada inválida. Digite uma opção válida: ");
            }

            int result = 0;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("A soma dos números é: " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("A subtração dos números é: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("A multiplicação dos números é: " + result);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("A divisão dos números é: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero não é permitida!");
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}