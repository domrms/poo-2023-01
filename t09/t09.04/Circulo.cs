namespace t09._04
{
    public class Circulo
    {
        public Ponto Centro { get; private set; }
        public double Raio { get; private set; }

        public Circulo(Ponto centro, double raio)
        {
            Centro = centro;
            Raio = raio;
        }

        public void Transladar(double deslocamentoX, double deslocamentoY)
        {
            Centro.Transladar(deslocamentoX, deslocamentoY);
        }

    }
}