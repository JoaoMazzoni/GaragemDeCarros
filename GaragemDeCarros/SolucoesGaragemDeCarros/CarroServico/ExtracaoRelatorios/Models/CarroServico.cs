namespace Models
{
    public class CarroServico
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }
        public Servico Servico { get; set; }
        public bool Status { get; set; }
    }
}
