using Models;
using Newtonsoft.Json;
using Repositories;


namespace Services
{
    public class CarroService
    {
        private ICarroRepository carroRepository;

        public CarroService()
        {
            carroRepository = new CarroRepository();
        }


        public bool Inserir(Carro carro)
        {
            return carroRepository.Inserir(carro);
        }


        public bool Ler(string path)
        {
            try
            {
                
                string jsonString = File.ReadAllText(path);

                
                var carros = JsonConvert.DeserializeObject<List<Carro>>(jsonString);

                
                foreach (var carro in carros)
                {
                    if (!Inserir(carro))
                    {
                        Console.WriteLine($"Falha ao inserir o carro com a placa: {carro.Placa}");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo JSON: {ex.Message}");
                return false;
            }
        }
    }
}
