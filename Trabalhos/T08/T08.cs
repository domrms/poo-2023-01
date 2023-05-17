namespace Trabalhos.T08
{
    public class T08
    {
        public class Disciplina
        {
            public static string nome { get; set; }
        }

        public class Projeto
        {
            public class LingaguemProgracao { };

            public List<LingaguemProgracao> lingaguemProgracao { get; set; }
        }

        public class Escola
        {
            public string nome { get; set; }
            public int capacidade { get; set; }
            public Endereco endereco { get; set; }


        }
        public class Endereco
        {
            public int cep { get; set; }
            public string logradouro { get; set; }
            public int numero { get; set; }
            public string bairro { get; set; }
        }

        public class TesteEscola
        {
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
}
