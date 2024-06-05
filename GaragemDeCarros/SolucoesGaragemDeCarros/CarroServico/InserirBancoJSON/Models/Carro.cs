
using Newtonsoft.Json;
using System.Text;

namespace Models
{
    public class Carro
    {
        [JsonProperty("Placa")]
        public string Placa { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("AnoModelo")]
        public int AnoModelo { get; set; }

        [JsonProperty("AnoFabricacao")]
        public int AnoFabricacao { get; set; }

        [JsonProperty("Cor")]
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
