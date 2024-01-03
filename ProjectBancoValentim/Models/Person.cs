using Newtonsoft.Json;

namespace ProjectBancoValentim.Models
{
    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
     
    }
}