namespace Circulo
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

        public void Mover(double deslocamentoX, double deslocamentoY)
        {
            Centro.Mover(deslocamentoX, deslocamentoY);
        }
    }
}