namespace T17._02
{
    public class Passageiro
    {
        public string Codigo { get; set; }
        public string Bilhete { get; set; }

        public Passageiro(string codigo, string bilhete)
        {
            Codigo = codigo;
            Bilhete = bilhete;
        }
    }
}
