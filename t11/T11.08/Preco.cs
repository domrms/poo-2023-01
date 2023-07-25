namespace T11._08
{
    public enum Moeda
    {
        Real,
        Dolar,
        Euro,
        Libra,
        Iene,
        Outra
    }

    public class Preco
    {
        public decimal Valor { get; set; }
        public Moeda Moeda { get; set; }

        public Preco(decimal valor, Moeda moeda)
        {
            Valor = valor;
            Moeda = moeda;
        }

        public override string ToString()
        {
            return $"{Valor} {Moeda}";
        }
    }
}