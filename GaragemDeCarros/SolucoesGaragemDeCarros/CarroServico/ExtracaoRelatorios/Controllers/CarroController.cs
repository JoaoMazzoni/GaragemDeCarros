using System.Collections.Generic;
using Models;


namespace Controllers
{
    public class CarroController
    {
        private CarroService carroService;

        public CarroController()
        {
            carroService = new CarroService();
        }

        public void GerarArquivoXmlCarrosComStatusAtivo()
        {
            carroService.GerarArquivoXmlCarrosComStatusAtivo();
        }

        public void GerarArquivoXmlCarrosVermelhos()
        {
            carroService.GerarArquivoXmlCarrosVermelhos();
        }

        public void GerarArquivoXmlCarrosFabricados2010ou2011()
        {
            carroService.GerarArquivoXmlCarrosFabricados2010ou2011();
        }
    }
}
