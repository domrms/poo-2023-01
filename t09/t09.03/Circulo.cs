namespace t09._03
{
    public class Circulo
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Raio { get; private set; }

        public Circulo(double x, double y, double raio)
        {
            X = x;
            Y = y;
            Raio = raio;
        }

        public void Transladar(double deslocamentoX, double deslocamentoY)
        {
            X += deslocamentoX;
            Y += deslocamentoY;
        }
    }
}