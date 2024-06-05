
using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class ServicoRepository
    {
        private string Conn { get; set; }

        public ServicoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InserirServico(Servico servico)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO Servico (Descricao) VALUES (@Descricao)", new
                {
                   Descricao = servico.Descricao

                });

                status = true;
                db.Close();
            }


            return status;

        }

        public List<Servico> LerDadosServicos()
        {
            List<Servico> servicos = new List<Servico>();

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                servicos = db.Query<Servico>("SELECT * FROM Servico").AsList();
                db.Close();
            }

            return servicos;
        }

    }
}
