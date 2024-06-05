using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;
using Repositories;

public class CarroService
{
    private CarroRepository carroRepository;
    private string directoryPath;

    public CarroService()
    {
        carroRepository = new CarroRepository();
        directoryPath = @"C:\Users\João Mazzoni\source\repos\CarroServico\ExtracaoRelatorios\ArquivosXML";
    }

    public void GerarArquivoXmlCarrosComStatusAtivo()
    {
        List<CarroServico> carros = carroRepository.GetCarrosComStatusAtivo();

        string filePath = Path.Combine(directoryPath, "CarrosComStatusAtivo.xml");

        XmlSerializer serializer = new XmlSerializer(typeof(List<CarroServico>));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, carros);
        }
    }

    public void GerarArquivoXmlCarrosVermelhos()
    {
        List<Carro> carros = carroRepository.GetCarrosVermelhos();

        string filePath = Path.Combine(directoryPath, "CarrosVermelhos.xml");

        XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, carros);
        }
    }

    public void GerarArquivoXmlCarrosFabricados2010ou2011()
    {
        List<Carro> carros = carroRepository.GetCarrosFabricados2010ou2011();

        string filePath = Path.Combine(directoryPath, "CarrosFabricados2010ou2011.xml");

        XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, carros);
        }
    }
}
