namespace t11._03
{
    public class JanelaComVidro : Janela
    {
        public double AreaVidro { get; set; }

        public double AreaRestante
        {
            get { return Area - AreaVidro; }
        }
    }
}