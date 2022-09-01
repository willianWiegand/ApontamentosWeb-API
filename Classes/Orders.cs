using Newtonsoft.Json;

namespace ApontmentoWebAPI.Classes
{
    public class Orders
    {
        
        [JsonProperty(propertyName: "order")]
        public string Order { get; set; }
        [JsonProperty(propertyName: "quantity")]
        public int Quantity { get; set; }
        [JsonProperty(propertyName: "productCode")]
        public string ProductCode { get; set; }
        [JsonProperty(propertyName: "productDescription")]
        public string ProductDescription { get; set; }
        [JsonProperty(propertyName: "image")]
        public string Image { get; set; }
        [JsonProperty(propertyName: "cycleTime")]
        public double CycleTime { get; set; }
        //[JsonProperty(propertyName: "materials")]
        //public Materials Materials { get; set; }

    }
}
