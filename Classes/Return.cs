using Newtonsoft.Json;

namespace ApontmentoWebAPI.Classes
{
    public class Return
    {

        [JsonProperty(propertyName: "status")]
        public double Status { get; set; }
        [JsonProperty(propertyName: "type")]
        public string Type { get; set; }
        [JsonProperty(propertyName: "description")]
        public string Description { get; set; }


    }
}