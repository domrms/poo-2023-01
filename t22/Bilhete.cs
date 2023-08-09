namespace parquediversoes
{
    public class Bilhete
    {
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }

        public Bilhete(DateTime data, TimeSpan hora)
        {
            Data = data;
            Hora = hora;
        }
    }
}