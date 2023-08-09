namespace restaurante
{
    public class CartaoCredito : Pagamento
    {
        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }
        public string Validade { get; set; }
        public string CodigoSeguranca { get; set; }
    }
}