namespace Models
{
    public class CarroServico
    {
        public CarroServico(int id, Carro carro, Servico servico, bool status)
        {
            Id = id;
            Carro = carro;
            Servico = servico;
            Status = status;
        }

        // Adicionando um construtor vazio para inicialização
        public CarroServico()
        {
            Carro = new Carro(); // Inicializa uma nova instância de Carro
            Servico = new Servico(); // Inicializa uma nova instância de Servico
            Status = false; // Inicializa o status como false
        }

        public int Id { get; set; }

        public Carro Carro { get; set; }

        public Servico Servico { get; set; }

        public bool Status { get; set; }
    }
}
