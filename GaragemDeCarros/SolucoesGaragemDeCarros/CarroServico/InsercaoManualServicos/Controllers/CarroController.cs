

using Models;
using Services;

namespace Controllers
{
    public class CarroController
    {
        private CarroService carroService;

        public CarroController()
        {
            carroService = new CarroService();  
        }

        public List<Carro> LerDados()
        {
            return carroService.LerDados();
        }


    }
}
