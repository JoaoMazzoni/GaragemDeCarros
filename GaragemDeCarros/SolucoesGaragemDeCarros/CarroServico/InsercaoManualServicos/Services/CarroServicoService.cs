
using Models;
using Repositories;
using Repository;



namespace Services
{
    public class CarroServicoService
    {
        private CarroServicoRepository carroServicoRepository;
        private CarroRepository carroRepository;
        private ServicoRepository servicoRepository;

        public CarroServicoService()
        {
            carroServicoRepository = new CarroServicoRepository();
            carroRepository = new CarroRepository();
            servicoRepository = new ServicoRepository();
        }

        public bool InserirRelacao(CarroServico carroServico)
        {

            var listaCarro = carroRepository.LerDados();
            var listaServico = servicoRepository.LerDadosServicos();

            if(listaCarro.Exists((carro => carro.Placa == carroServico.Carro.Placa)) && listaServico.Exists(servico => servico.Id == carroServico.Servico.Id))
        {
                Console.WriteLine("Dados Encontrados!");
                Console.ReadLine();
                return carroServicoRepository.InserirRelacao(carroServico);
            }
        else
            {
                Console.WriteLine("Os Dados Informados Não Foram Encontrados");
                Console.ReadLine();
                return false;
            }
            

        }

    }
}
