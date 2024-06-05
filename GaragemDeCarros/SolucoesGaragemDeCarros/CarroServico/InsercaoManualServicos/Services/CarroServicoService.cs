
using Models;
using Repositories;
using Repository;

namespace Services
{
    public class CarroServicoService
    {
        private CarroServicoRepository carroServicoRepository;

        public CarroServicoService()
        {
            carroServicoRepository = new CarroServicoRepository();
        }

        public bool InserirRelacao(CarroServico carroServico)
        {
            //Fazer verificação aqui se Carro e Servico existem no Banco.
            return carroServicoRepository.InserirRelacao(carroServico);
        }

    }
}
