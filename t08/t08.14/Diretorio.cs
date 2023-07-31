namespace t08._14
{
    public class Diretorio
    {
        public string Nome { get; private set; }
        public List<Usuario> UsuariosAutorizados { get; private set; }

        public Diretorio(string nome)
        {
            Nome = nome;
            UsuariosAutorizados = new List<Usuario>();
        }

        public void AdicionarUsuarioAutorizado(Usuario usuario)
        {
            UsuariosAutorizados.Add(usuario);
        }
    }
}
