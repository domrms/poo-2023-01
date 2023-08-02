namespace Xadrez
{
    public class Partida
    {
        public List<Lance> Lances { get; }

        public Partida()
        {
            Lances = new List<Lance>();
        }

        public void AdicionarLance(Lance lance)
        {
            Lances.Add(lance);
        }
    }
}