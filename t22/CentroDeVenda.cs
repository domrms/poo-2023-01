namespace parquediversoes
{
    public class CentroDeVenda
    {
        private List<Bilhete> bilhetesVendidos = new List<Bilhete>();

        public void VenderBilhete(Bilhete bilhete)
        {
            bilhetesVendidos.Add(bilhete);
            Console.WriteLine($"Bilhete vendido: {bilhete.GetType().Name} - Data: {bilhete.Data}, Hora: {bilhete.Hora}");
        }

        public void TrocarBilhete(Bilhete bilhete, TrocaAPorB troca)
        {
            Console.WriteLine($"Bilhete {bilhete.GetType().Name} trocado por Bilhete TrocaAPorB - Data: {troca.Data}, Hora: {troca.Hora}, Diferença: {troca.Diferenca}");
        }
    }
}