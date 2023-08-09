namespace parquediversoes
{
    public class Crianca : Pessoa
    {
        public int Idade { get; set; }

        public Crianca(string nome, int idade) : base(nome)
        {
            Idade = idade;
        }
    }
}