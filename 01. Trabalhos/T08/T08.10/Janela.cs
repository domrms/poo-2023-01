namespace T08._10
{
    public class Janela
    {
        public List<ElementoInteracao> Elementos { get; set; }

        public Janela()
        {
            Elementos = new List<ElementoInteracao>();
            // Cria as instâncias dos elementos de interação
            Elementos.Add(new Botao());
            Elementos.Add(new Menu());
            Elementos.Add(new BarraRolagem());
        }

    }
}