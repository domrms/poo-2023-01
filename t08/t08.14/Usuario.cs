namespace t08._14
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public List<Diretorio> Diretorios { get; private set; }

        public Usuario(string nome)
        {
            Nome = nome;
            Diretorios = new List<Diretorio>();
        }

        public void AdicionarDiretorio(Diretorio diretorio)
        {
            Diretorios.Add(diretorio);
        }
    }
}