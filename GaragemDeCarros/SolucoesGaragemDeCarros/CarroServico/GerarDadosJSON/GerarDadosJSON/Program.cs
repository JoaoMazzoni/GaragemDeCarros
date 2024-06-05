using System;
using System.Collections.Generic;
using System.IO; // Importe o namespace System.IO para acessar a classe Directory
using Newtonsoft.Json;
using Models;

namespace CarroJsonGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"ArquivoJSON\";
            string filePath = Path.Combine(directory, "carros.json");

            // Verifica se o diretório existe, caso contrário, cria o diretório
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            Random random = new Random();

            List<Carro> carros = new List<Carro>();

            string[] sufixos = { "XL", "LX", "GL", "Sport", "Top", "GT", "Limited", "Sedan", "Turbo" };

            
            string[] marcas = { "Ford", "Chevrolet", "Volkswagen", "Toyota", "Honda", "BMW", "Mercedes-Benz", "Audi", "Hyundai", "Fiat" };

            for (int i = 0; i < 30; i++)
            {
                string marcaAleatoria = marcas[random.Next(marcas.Length)];
                string sufixoAleatorio = sufixos[random.Next(sufixos.Length)];

                int anoModelo = random.Next(2000, 2025);


                int anoFabricacao = anoModelo - 1;

                string nome = $"{marcaAleatoria} {sufixoAleatorio}";

                Carro carro = new Carro
                {
                    Placa = "ABC" + i.ToString("D4"),
                    Nome = nome,
                    AnoModelo = anoModelo,
                    AnoFabricacao = anoFabricacao,
                    Cor = i % 2 == 0 ? "Azul" : "Vermelho"
                };

                carros.Add(carro);
            }

            string json = JsonConvert.SerializeObject(carros, Formatting.Indented);

           
            File.WriteAllText(filePath, json);

            Console.WriteLine($"Arquivo JSON gerado com sucesso em {filePath}");
        }
    }
}
