namespace t17._02
{
    public enum TipoVoo
    {
        Decolagem,
        Aterrissagem
    }

    public class Voo
    {
        public string Codigo { get; set; }
        public TipoVoo Tipo { get; set; }
        public Aviao Aviao { get; private set; }
        public List<Aeromoca> Aeromocas { get; private set; }
        public Piloto Piloto { get; private set; }
        public Copiloto Copiloto { get; private set; }
        public Operacao Operacao { get; private set; }

        public Voo(string codigo, TipoVoo tipo)
        {
            Codigo = codigo;
            Tipo = tipo;
            Aeromocas = new List<Aeromoca>();
        }

        public void SetAviao(Aviao aviao)
        {
            Aviao = aviao;
        }

        public void SetTripulacao(Piloto piloto, Copiloto copiloto, params Aeromoca[] aeromocas)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            foreach (Aeromoca aeromoca in aeromocas)
            {
                Aeromocas.Add(aeromoca);
            }
        }

        public void SetOperacao(Operacao operacao)
        {
            Operacao = operacao;
        }
    }
}