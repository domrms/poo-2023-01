namespace t08._03
{
    public class Escola
    {
        public string nome;
        public int capacidade;
        public Endereco endereco;

        private static void Main()
        {
            Escola escola = new Escola();
            escola.nome = "ESCOLINHA ALIANÇA";
            escola.capacidade = 200;
            escola.endereco.cep = 74605000;
            escola.endereco.logradouro = "RUA DOS BOBOS";
            escola.endereco.numero = 0;
            escola.endereco.bairro = "BAIRRO NENHUM";
        }
    }
}