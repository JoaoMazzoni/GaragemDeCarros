

using Models;
using Repositories;

namespace Services
{
    public class ServicoService
    {
        private ServicoRepository servicoRepository;

        public ServicoService()
        {
            servicoRepository = new ServicoRepository();
        }

        public bool InserirServico(Servico servico)
        {
            
            return servicoRepository.InserirServico(servico);
        }


        public List<Servico> LerDadosServicos()
        {
            return servicoRepository.LerDadosServicos();
        }
    }
}
