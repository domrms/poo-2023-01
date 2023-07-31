namespace t17._02
{
    public class Aeroporto
    {
        public List<Voo> Voos { get; set; }

        public Aeroporto()
        {
            Voos = new List<Voo>();
        }

        public void AdicionarVoo(Voo voo)
        {
            Voos.Add(voo);
        }
    }
}
