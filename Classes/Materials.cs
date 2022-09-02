using Newtonsoft.Json;

namespace ApontmentoWebAPI.Classes
{
    public class Materials
    {
        [JsonProperty(propertyName:"materialCode")]
        public string MaterialCode { get; set; }
        [JsonProperty(propertyName: "materialDescription")]
        public string MaterialDescription { get; set; }

    }
}