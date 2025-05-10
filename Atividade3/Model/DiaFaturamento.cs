using System.Text.Json.Serialization;

namespace Atividade3.Model
{
    public class DiaFaturamento
    {
        [JsonPropertyName("dia")]
        public int Dia { get; set; }
        [JsonPropertyName("valor")]
        public double Valor { get; set; }
    }
}
