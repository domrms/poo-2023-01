namespace t17._10
{
    public class Produto
    {
        public string Nome { get; }
        public int Quantidade { get; }
        public decimal PrecoUnitario { get; }

        public Produto(string nome, int quantidade, decimal precoUnitario)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}
