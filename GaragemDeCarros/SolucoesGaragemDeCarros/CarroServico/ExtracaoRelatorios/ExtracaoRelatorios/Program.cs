using Controllers;

namespace CarroServicoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarroController carroController = new CarroController();

            
            carroController.GerarArquivoXmlCarrosComStatusAtivo();
            Console.WriteLine("Arquivo XML para carros com status ativo gerado com sucesso!");


            carroController.GerarArquivoXmlCarrosVermelhos();
            Console.WriteLine("Arquivo XML para carros vermelhos gerado com sucesso!");


            carroController.GerarArquivoXmlCarrosFabricados2010ou2011();
            Console.WriteLine("Arquivo XML para carros fabricados em 2010 ou 2011 gerado com sucesso!");

            Console.ReadLine(); 

        }
    }
}
