using System.Collections;

namespace T07._16
{
    public   class Festa
    {
        private SortedList convidados = new SortedList();

        public void novoConvidado(Convidado c)
        {
            convidados.Add(c, c);
        }

        public Festa(Convidado c)
        {
            convidados.Add(c, c);
        }
    }
}
