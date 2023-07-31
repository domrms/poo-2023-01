namespace t09._07
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando objetos
            Objeto objeto1 = new Objeto("Objeto 1");
            Objeto objeto2 = new Objeto("Objeto 2");
            Objeto objeto3 = new Objeto("Objeto 3");

            // Criando contêineres
            Conteiner conteiner1 = new Conteiner("Contêiner 1");
            Conteiner conteiner2 = new Conteiner("Contêiner 2");

            // Adicionando objetos aos contêineres
            conteiner1.AdicionarElemento(objeto1);
            conteiner1.AdicionarElemento(objeto2);

            conteiner2.AdicionarElemento(objeto3);
            conteiner2.AdicionarElemento(conteiner1);

            // Listando os elementos no contêiner
            conteiner2.ListarElementos();

            // Removendo um elemento do contêiner
            conteiner2.RemoverElemento(conteiner1);

            // Listando os elementos atualizados no contêiner
            conteiner2.ListarElementos();
        }
    }
}
