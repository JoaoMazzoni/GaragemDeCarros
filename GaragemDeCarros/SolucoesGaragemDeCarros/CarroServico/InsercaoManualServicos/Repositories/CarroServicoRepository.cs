

using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarroServicoRepository
    {
        private string Conn { get; set; }
        public CarroServicoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool InserirRelacao(CarroServico carroServico)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                
                db.Open();
                db.Execute("INSERT INTO CarroServico (CarroID, ServicoID, Status) VALUES (@CarroID, @ServicoID, @Status)", new
                {
                    CarroID = carroServico.Carro.Placa,
                    ServicoID = carroServico.Servico.Id,
                    Status = carroServico.Status

                });

                status = true;
                db.Close();
            }


            return status;

        }
    }
}
