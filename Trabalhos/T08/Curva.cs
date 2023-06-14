namespace Trabalhos.T08
{
    public class Curva
    {
        public List<Ponto> Pontos { get; set; }

        public Curva()
        {
            Pontos = new List<Ponto>();
        }

        static void Main(string[] args)
        {
            Curva curva = new Curva();

            Ponto ponto1 = new Ponto() { X = 1, Y = 2 };
            curva.Pontos.Add(ponto1);

            Ponto ponto2 = new Ponto() { X = 3, Y = 4 };
            curva.Pontos.Add(ponto2);

            Ponto ponto3 = new Ponto() { X = 5, Y = 6 };
            curva.Pontos.Add(ponto3);
        }
    }
}
