using Newtonsoft.Json;

namespace ClimaTempo.Models
{
    public class DadosClima
    {
        [JsonProperty("name")]
        public string NomeCidade { get; set; }

        [JsonProperty("main")]
        public Clima Clima { get; set; }        
    }
}
