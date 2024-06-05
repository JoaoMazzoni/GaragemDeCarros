using Models;
using Repositories;
using Repository;

namespace Services
{
    
    public class CarroService
    {
        private CarroRepository carroRepository;

        public CarroService()
        {
            carroRepository = new CarroRepository();
        }


        public List<Carro> LerDados()
        {
            return carroRepository.LerDados();
        }
    }
}
