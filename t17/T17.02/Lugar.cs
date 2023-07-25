namespace T17._02
{
    public class Lugar
    {
        public string Codigo { get; set; }
        public Passageiro Passageiro { get; private set; }

        public  Lugar(string codigo)
        {
            Codigo = codigo;
        }

        public void SetPassageiro(Passageiro passageiro)
        {
            Passageiro = passageiro;
        }
    }
}
