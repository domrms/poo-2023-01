namespace t09._06
{
    public class MainMethod
    {
        public static void Main()
        {
            Mamifero mamifero = new Mamifero();
            Elefante elefante = new Elefante();

            mamifero.Amamentar();     // Ação geral de amamentação realizada por mamíferos
            elefante.Amamentar();     // Elefante herda o método Amamentar da classe Mamifero
            elefante.BalancarOrelhas();  // Ação específica realizada por elefantes
        }
    }
}
