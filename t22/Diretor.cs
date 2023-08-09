namespace parquediversoes
{
    public class Diretor : Funcionario
    {
        public Diretor() : base("Diretor")
        {
        }

        public void CoordenarColaboradores(Escala escala)
        {
            foreach (var kvp in escala.Alocacoes)
            {
                Console.WriteLine($"Coordenando {kvp.Key.Nome} com rádio {kvp.Value.Identificacao}");
            }
        }
    }
}