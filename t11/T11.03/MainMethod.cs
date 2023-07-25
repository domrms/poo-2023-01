namespace T11._03
{
    public class MainMethod
    {
        public static void Main()
        {
            JanelaComVidro janelaComVidro = new JanelaComVidro
            {
                Area = 100,
                AreaVidro = 60
            };

            Console.WriteLine("Área total da janela: " + janelaComVidro.Area);
            Console.WriteLine("Área ocupada pelo vidro: " + janelaComVidro.AreaVidro);
            Console.WriteLine("Área restante da janela: " + janelaComVidro.AreaRestante);
        }
    }
}