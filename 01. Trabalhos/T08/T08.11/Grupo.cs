namespace T08._11
{
    public class Grupo
    {
        public List<Permissao> Permissoes { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public Grupo()
        {
            Permissoes = new List<Permissao>();
            Usuarios = new List<Usuario>();
        }

        static void Main(string[] args)
        {
            Grupo grupo = new Grupo();
            Arquivo arquivo = new Arquivo();

            Permissao permissao = new Permissao();
            permissao.GrupoAssociado = grupo;
            permissao.ArquivoAssociado = arquivo;

            grupo.Permissoes.Add(permissao);
            arquivo.Permissoes.Add(permissao);

            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario();

            grupo.Usuarios.Add(usuario1);
            grupo.Usuarios.Add(usuario2);
        }
    }
}
