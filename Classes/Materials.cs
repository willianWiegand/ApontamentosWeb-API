using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
