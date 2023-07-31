namespace t09._04
{
    public class Ponto
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Ponto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Transladar(double deslocamentoX, double deslocamentoY)
        {
            X += deslocamentoX;
            Y += deslocamentoY;
        }
    }
}
