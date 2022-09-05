using Newtonsoft.Json;
using System;
using System.Globalization;

namespace ApontmentoWebAPI.Classes
{
    public class Return
    {
        [JsonProperty(propertyName: "status")]
        public string Status { get; set; }
        [JsonProperty(propertyName: "type")]
        public string Type { get; set; }
        [JsonProperty(propertyName: "description")]
        public string Description { get; set; }
    }
}