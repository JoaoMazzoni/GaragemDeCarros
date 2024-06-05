

namespace Models
{
    public class Servico
    {
        public Servico()
        {
        }
        public Servico(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        

    }
}
