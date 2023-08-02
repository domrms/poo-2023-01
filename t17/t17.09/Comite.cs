namespace t17._09
{
    public class Comite
    {
        public List<Pessoa> Presidentes { get; }

        public Comite()
        {
            Presidentes = new List<Pessoa>();
        }

        public void DefinirPresidentes(params Pessoa[] presidentes)
        {
            if (presidentes.Length < 2 || presidentes.Length > 3)
            {
                throw new ArgumentException("Um comitê deve ter dois ou três presidentes.");
            }

            foreach (Pessoa presidente in presidentes)
            {
                Presidentes.Add(presidente);
            }
        }
    }
}