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


        public void Ler(string arquivo)
        {
            bool resultado = carroService.Ler(arquivo);

            if (resultado)
            {
                Console.WriteLine("Carros inseridos com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha ao inserir carros.");
            }
        }
    }
}
