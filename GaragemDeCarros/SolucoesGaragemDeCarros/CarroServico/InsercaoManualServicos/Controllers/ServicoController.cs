using Models;
using Repositories;
using Services;

namespace Controllers
{
    public class ServicoController
    {
        private ServicoService servicoService;

        public ServicoController()
        {
            servicoService = new ServicoService();
        }

        public bool InserirServico(Servico servico)
        {
            return servicoService.InserirServico(servico);
        }

        public List<Servico> LerDadosServicos()
        {
            return servicoService.LerDadosServicos();
        }

    }
}
