
using Models;
using Services;

namespace Controllers
{
    public class CarroServicoController
    {
        private CarroServicoService carroServicoService;

        public CarroServicoController()
        {
            carroServicoService = new CarroServicoService();
        }

        public bool InserirRelacao(CarroServico carroServico)
        {
            return carroServicoService.InserirRelacao(carroServico);
        }
         
    }
}
