using System.Text;

namespace Models
{
    public class Carro
    {
        public readonly static string SELECT = "SELECT Placa, Nome, AnoModelo, AnoFabricacao, Cor FROM Carros";

        public Carro(string placa, string nome, int anoModelo, int anoFabricacao, string cor)
        {
            Placa = placa;
            Nome = nome;
            AnoModelo = anoModelo;
            AnoFabricacao = anoFabricacao;
            Cor = cor;
        }

        public Carro()
        {
        }

        public string Placa { get; set; }
        public string Nome { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Placa: {Placa}");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Ano do Modelo: {AnoModelo}");
            sb.AppendLine($"Ano de Fabricação: {AnoFabricacao}");
            sb.AppendLine($"Cor: {Cor}");
            return sb.ToString();
        }
    }
}
