namespace t09._10
{
    public class MainMethod
    {
        public static void Main()
        {
            Armazem armazem1 = new Armazem("Armazém 1");
            Armazem armazem2 = new Armazem("Armazém 2");
            Armazem armazem3 = new Armazem("Armazém 3");

            Cidade cidade1 = new Cidade("Cidade A");
            cidade1.AdicionarPedido(armazem1);
            cidade1.AdicionarPedido(armazem2);

            Cidade cidade2 = new Cidade("Cidade B");
            cidade2.AdicionarPedido(armazem3);

            Viagem viagem1 = new Viagem(new List<Cidade> { cidade1, cidade2 });

            CaixeiroViajante caixeiro = new CaixeiroViajante();
            caixeiro.AdicionarViagem(viagem1);

            caixeiro.ListarViagens();
        }
    }
}