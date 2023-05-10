using System.Collections;

namespace Trabalhos.T07
{
    public class T07
    {
        public class Pessoa
        {
            private readonly String nome;
            private DateTime nascimento;
            private readonly Pessoa pai;
            private readonly Pessoa mae;
        }

        //Classe Prova como o método get e set. O acessor get é responsável por retornar um valor de um campo privado da classe e o acessor set é responsável por atribuir um novo valor ao campo.
        public class Prova
        {
            private byte numQuestoes { get; set; }
        }

        public class testeProva {
            Prova pf = new Prova();
        }

        public class Casa
        {
            public Casa() { }
                Casa c = new Casa();
        }

        public abstract class Pessoa2 { };

        public class Festa
        {
            SortedList convidados = new SortedList();
        }

        public class Convidado
        {
            public Convidado convidados { get; set; }
            public void novoConvidado(Convidado c)
            {
                convidados = c;
            }   
            public void Festa(Convidado c)
            {
                convidados = c;
            }
        }
    }
}
