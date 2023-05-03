// Refatorar em casa

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;

public class trabalho07
{
    Classe com dois atributos sendo duas associações com ela própria
    public class  Pessoa {
        private String nome;
        private DateTime nascimento;
      private Pessoa pai;
       private Pessoa mae;
    }
    
    //Classe Prova como o método get e set. O acessor get é responsável por retornar um valor de um campo privado da classe e o acessor set é responsável por atribuir um novo valor ao campo.
    public class Prova {
        private byte numQuestoes { get; set; }
    }
    
    //public class testeProva {
     //   public static void Main(string[] args)
    //{
    //    Prova pf = new Prova();
     //   Console.WriteLine("OK!");
    //}
    //}
    
    public class Casa {
        public Casa() {
            Console.WriteLine("Mais uma casa!");
        }
        public static void Main(string[] args){
            Casa c = new Casa();
            Console.WriteLine("OK!");
        }
    }
    
    public abstract class Pessoa {}
    
    public class Festa {
        SortedList convidados = new SortedList();
    }
    
    public void novoConvidado (Convidado c){
        convidados.add(c);
    }
    public Festa (Convidado c) {
        convidados.add(c);
    }
    
}
