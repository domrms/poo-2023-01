namespace t09._05
{
    public class MainMethod
    {
        public static void Main()
        {
            // Criando uma pessoa
            Pessoa pessoa = new Pessoa("Fulano", 25);

            // Criando um usuário associado à pessoa
            Usuario usuario = new Usuario(pessoa, "Administrador");

            // Realizando uma atividade como pessoa
            pessoa.RealizarAtividade("Ler");

            // Realizando uma atividade como usuário
            usuario.RealizarAtividade("Editar");

            // Acessando a pessoa associada ao usuário
            Pessoa pessoaDoUsuario = usuario.Pessoa;
            Console.WriteLine($"Nome da pessoa associada ao usuário: {pessoaDoUsuario.Nome}");
        }
    }
}