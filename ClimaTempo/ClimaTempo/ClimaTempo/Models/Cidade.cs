using Newtonsoft.Json;

namespace ClimaTempo.Models
{
    public class Cidade
    {
        [JsonProperty("name")]
        public string NomeCidade { get; set; }

        [JsonProperty("main")]
        public Clima Clima { get; set; }
    }
}
