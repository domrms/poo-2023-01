namespace t17._03
{
    public class Pedido
    {
        private static int contadorPedidos = 1;

        public int Numero { get; private set; }
        public List<Detalhe> Detalhes { get; private set; }
        public Bebida Bebida { get; private set; }

        public Pedido()
        {
            Numero = contadorPedidos;
            contadorPedidos++;
            Detalhes = new List<Detalhe>();
        }

        public void AdicionarDetalhe(Detalhe detalhe)
        {
            Detalhes.Add(detalhe);
        }

        public void AdicionarBebida(Bebida bebida)
        {
            Bebida = bebida;
        }
    }
}