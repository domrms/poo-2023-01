namespace parquediversoes
{
    public class Escala
    {
        private Dictionary<Funcionario, Radio> alocacoes = new Dictionary<Funcionario, Radio>();

        public void AlocarRadio(Funcionario funcionario, Radio radio)
        {
            alocacoes[funcionario] = radio;
            Console.WriteLine($"{funcionario.Nome} alocado à rádio {radio.Identificacao}");
        }
    }
}