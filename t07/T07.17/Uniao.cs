using System.Collections;

namespace t07._17
{
    public class Uniao
    {
        private ArrayList filhos;
        private Pessoa[] parceiros = new Pessoa[2];

        public void novoFilho(Pessoa p)
        {
            filhos.Add(p);
        }

        public Uniao(Pessoa a, Pessoa b)
        {
            parceiros[0] = a;
            parceiros[1] = b;
        }

        public static void Main() { }

    }
}