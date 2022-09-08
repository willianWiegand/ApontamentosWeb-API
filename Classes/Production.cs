using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ApontmentoWebAPI.Classes
{
    public class Production
    {
        [JsonProperty(propertyName: "email")]
        public string Email { get; set; }
        [JsonProperty(propertyName: "order")]
        public string Order { get; set; }
        [JsonProperty(propertyName: "date")]
        public string ProductionCompleteDate { get; set; }
        [JsonProperty(propertyName: "productionDate")]
        public string ProductionDate { get; set; }
        [JsonProperty(propertyName: "productionTime")]
        public string ProductionTime { get; set; }
        [JsonProperty(propertyName: "quantity")]
        public double Quantity { get; set; }
        [JsonProperty(propertyName: "materialCode")]
        public string MaterialCode { get; set; }
        [JsonProperty(propertyName: "cycleTime")]
        public double CycleTime { get; set; }
        [JsonProperty(propertyName: "productions")]
        public List<Production> Productions { get; set; }
    }
}