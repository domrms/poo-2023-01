using parquediversoes;

public class Program
{
    private static void Main(string[] args)
    {
        Parque parque = new Parque();

        // Criando algumas crianças e visitantes
        Crianca crianca1 = new Crianca("João", 5);
        Crianca crianca2 = new Crianca("Maria", 7);
        Visitante visitante1 = new Visitante("Carlos");
        Visitante visitante2 = new Visitante("Ana");

        // Criando bilhetes
        Bilhete bilheteUniversal = new BilheteUniversal(DateTime.Now, TimeSpan.FromHours(3));
        Bilhete bilheteEspecifico = new BilheteEspecifico(DateTime.Now, TimeSpan.FromHours(2), new List<string> { "Brinquedo1", "Brinquedo2" });

        // Realizando vendas de bilhetes
        CentroDeVenda centroDeVenda = new CentroDeVenda();
        centroDeVenda.VenderBilhete(bilheteUniversal);
        centroDeVenda.VenderBilhete(bilheteEspecifico);

        // Trocando um bilhete
        TrocaAPorB troca = new TrocaAPorB(DateTime.Now, TimeSpan.FromHours(1), 10);
        centroDeVenda.TrocarBilhete(bilheteUniversal, troca);

        // Criança se perdeu, registrando ocorrência
        Ocorrencia ocorrencia = new Ocorrencia("Criança perdida", DateTime.Now, "Descrição da ocorrência");
        parque.RegistrarOcorrencia(ocorrencia);

        // Criando colaboradores
        Funcionario funcionario1 = new Funcionario("Alice");
        Funcionario funcionario2 = new Funcionario("Bob");

        // Alocando rádios aos colaboradores
        Escala escala = new Escala();
        escala.AlocarRadio(funcionario1, new Radio("Radio1"));
        escala.AlocarRadio(funcionario2, new Radio("Radio2"));

        // Diretor do parque coordenando colaboradores
        Diretor diretor = new Diretor();
        diretor.CoordenarColaboradores(escala);
    }
}