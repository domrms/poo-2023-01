namespace t09._05
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void RealizarAtividade(string atividade)
        {
            Console.WriteLine($"A pessoa {Nome} está realizando a atividade: {atividade}");
        }
    }
}