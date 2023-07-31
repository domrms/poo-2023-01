namespace t17._02
{
    public class Aviao
    {
        public string Codigo { get; set; }
        public List<Lugar> Lugares { get; private set; }

        public Aviao(string codigo)
        {
            Codigo = codigo;
            Lugares = new List<Lugar>();
        }

        public void AdicionarLugar(Lugar lugar)
        {
            Lugares.Add(lugar);
        }
    }
}
