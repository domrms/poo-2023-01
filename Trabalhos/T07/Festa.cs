using System.Collections;

namespace Trabalhos.T07
{
    public class Festa
    {
        private SortedList convidados = new SortedList();

        public void novoConvidado (Convidado c )
        {
            convidados.Add(c,c);
        }
        
        public Festa (Convidado c)
        {
            convidados.Add(c, c);
        }
    }
}
