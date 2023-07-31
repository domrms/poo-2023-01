namespace T09._07
{
    public class Conteiner : Elemento
    {
        private List<Elemento> elementos;

        public Conteiner(string nome) : base(nome)
        {
            elementos = new List<Elemento>();
        }

        public void AdicionarElemento(Elemento elemento)
        {
            elementos.Add(elemento);
        }

        public void RemoverElemento(Elemento elemento)
        {
            elementos.Remove(elemento);
        }

        public void ListarElementos()
        {
            Console.WriteLine($"Elementos no contêiner {Nome}:");
            foreach (Elemento elemento in elementos)
            {
                Console.WriteLine(elemento.Nome);
            }
        }
    }
}