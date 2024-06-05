using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Collections.Generic;
using System.Configuration;

namespace Repositories
{
    public class CarroRepository
    {
        private string Conn { get; set; }

        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public List<CarroServico> GetCarrosComStatusAtivo()
        {
            using (var db = new SqlConnection(Conn))
            {
                db.Open();

                var carros = db.Query<CarroServico, Carro, Servico, CarroServico>(
                    @"SELECT cs.ID, c.*, s.*, cs.Status FROM CarroServico cs
                    INNER JOIN Carro c ON cs.CarroID = c.Placa
                    INNER JOIN Servico s ON cs.ServicoID = s.ID
                    WHERE cs.Status = 1",
                    (carroServico, carro, servico) =>
                    {
                        carroServico.Carro = carro;
                        carroServico.Servico = servico;
                        carroServico.Status = true; // Definindo explicitamente como true, pois Status=1
                        return carroServico;
                    },
                    splitOn: "Placa,ID"
                );


                return carros.ToList();
            }
        }

        public List<Carro> GetCarrosVermelhos()
        {
            using (var db = new SqlConnection(Conn))
            {
                db.Open();

                var carros = db.Query<Carro>("SELECT Placa, Nome, AnoModelo, AnoFabricacao, Cor FROM Carro WHERE Cor = 'Vermelho'");
                return carros.ToList();
            }
        }

        public List<Carro> GetCarrosFabricados2010ou2011()
        {
            using (var db = new SqlConnection(Conn))
            {
                db.Open();

                var carros = db.Query<Carro>("SELECT Placa, Nome, AnoModelo, AnoFabricacao, Cor FROM Carro WHERE AnoFabricacao = 2010 OR AnoFabricacao = 2011");
                return carros.ToList();
            }
        }
    }
}
