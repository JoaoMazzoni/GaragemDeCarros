
namespace Models
{
    public class Servico
    {
        public int Id { get; set; }  
        public string Descricao { get; set; }

        public Servico(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public Servico()
        {
        }
    }
}
