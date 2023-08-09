namespace parquediversoes
{
    public class BilheteEspecifico : Bilhete
    {
        public List<string> Brinquedos { get; set; }

        public BilheteEspecifico(DateTime data, TimeSpan hora, List<string> brinquedos) : base(data, hora)
        {
            Brinquedos = brinquedos;
        }
    }
}