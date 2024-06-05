using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private string Conn { get; set; }
        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Inserir(Carro carro)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();                          
                db.Execute("INSERT INTO Carro (Placa, Nome, AnoModelo, AnoFabricacao, Cor) VALUES (@Placa, @Nome, @AnoModelo, @AnoFabricacao, @Cor)", new
                {
                     Placa = carro.Placa,
                     Nome = carro.Nome,
                     AnoModelo = carro.AnoModelo,   
                     AnoFabricacao = carro.AnoFabricacao,
                     Cor = carro.Cor
                });
                status = true;
                db.Close();
            }


            return status;

        }

    }
}
