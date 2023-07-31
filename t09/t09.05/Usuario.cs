namespace t09._05
{
    public class Usuario
    {
        public Pessoa Pessoa { get; private set; }
        public string Papel { get; private set; }

        public Usuario(Pessoa pessoa, string papel)
        {
            Pessoa = pessoa;
            Papel = papel;
        }

        public void RealizarAtividade(string atividade)
        {
            Console.WriteLine($"O usuário {Pessoa.Nome}, no papel de {Papel}, está realizando a atividade: {atividade}");
        }
    }
}