namespace T08._14
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando alguns usuários
            Usuario usuario1 = new Usuario("Usuario1");
            Usuario usuario2 = new Usuario("Usuario2");
            Usuario usuario3 = new Usuario("Usuario3");

            // Criando alguns diretórios
            Diretorio diretorio1 = new Diretorio("Diretorio1");
            Diretorio diretorio2 = new Diretorio("Diretorio2");

            // Associando usuários aos diretórios
            usuario1.AdicionarDiretorio(diretorio1);
            usuario2.AdicionarDiretorio(diretorio2);
            usuario3.AdicionarDiretorio(diretorio1);
            usuario3.AdicionarDiretorio(diretorio2);

            diretorio1.AdicionarUsuarioAutorizado(usuario1);
            diretorio2.AdicionarUsuarioAutorizado(usuario2);
            diretorio1.AdicionarUsuarioAutorizado(usuario3);
            diretorio2.AdicionarUsuarioAutorizado(usuario3);

            // Exemplo de consulta aos diretórios de um usuário
            Console.WriteLine("Diretórios do Usuario1:");
            foreach (var diretorio in usuario1.Diretorios)
            {
                Console.WriteLine(diretorio.Nome);
            }

            Console.WriteLine("\nDiretórios do Usuario2:");
            foreach (var diretorio in usuario2.Diretorios)
            {
                Console.WriteLine(diretorio.Nome);
            }

            Console.WriteLine("\nDiretórios do Usuario3:");
            foreach (var diretorio in usuario3.Diretorios)
            {
                Console.WriteLine(diretorio.Nome);
            }
        }
    }
}
