namespace parquediversoes
{
    public class Parque
    {
        private List<Ocorrencia> ocorrencias = new List<Ocorrencia>();

        public void RegistrarOcorrencia(Ocorrencia ocorrencia)
        {
            ocorrencias.Add(ocorrencia);
            Console.WriteLine($"Ocorrência registrada: {ocorrencia.Tipo} - {ocorrencia.Descricao}");
        }
    }
}