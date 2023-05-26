namespace Trabalhos.T08
{
    public class Escola
    {
        public string nome;
        public int capacidade;
        public Endereco endereco;

        static void Main()
        {
            Escola escola = new Escola();
            escola.nome = "ESCOLINHA ALIANÇA";
            escola.capacidade = 200;
            escola.endereco.cep = 0000000;
            escola.endereco.logradouro = "RUA DOS BOBOS";
            escola.endereco.numero = 0;
            escola.endereco.bairro = "BAIRRO NENHUM";
        }
    }
}