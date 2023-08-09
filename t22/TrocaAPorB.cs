namespace parquediversoes
{
    public class TrocaAPorB : Bilhete
    {
        public int Diferenca { get; set; }

        public TrocaAPorB(DateTime data, TimeSpan hora, int diferenca) : base(data, hora)
        {
            Diferenca = diferenca;
        }
    }
}