using Newtonsoft.Json;

namespace ClimaTempo.Models
{
    public class Clima
    {
        [JsonProperty("temp")]
        public string Temperatura { get; set; }

        [JsonProperty("temp_min")]
        public string TemperaturaMinina { get; set; }

        [JsonProperty("temp_max")]
        public string TemperaturaMaxima { get; set; }

        [JsonProperty("humidity")]
        public string Humidade { get; set; }
    }
}
