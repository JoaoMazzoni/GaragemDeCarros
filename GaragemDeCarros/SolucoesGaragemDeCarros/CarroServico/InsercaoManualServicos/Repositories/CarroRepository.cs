using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Microsoft.Data.SqlClient;
using Models;

namespace Repository
{
    public class CarroRepository
    {
        static string sqlConnectionString = "Server=127.0.0.1; Database=DBCarroServico; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";

        SqlConnection conn;

        public CarroRepository()
        {
            conn = new SqlConnection(sqlConnectionString);
            conn.Open();
        }

        public List<Carro> LerDados()
        {
            List<Carro> carros = new List<Carro>();

            StringBuilder sb = new StringBuilder();
            sb.Append(Carro.SELECT);

            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Carro carro = new Carro();
                    carro.Placa = reader.GetString(0);
                    carro.Nome = reader.GetString(1);
                    carro.AnoModelo = reader.GetInt32(2);
                    carro.AnoFabricacao = reader.GetInt32(3);
                    carro.Cor = reader.GetString(4);
                    carros.Add(carro);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return carros;
        }
    }
}
