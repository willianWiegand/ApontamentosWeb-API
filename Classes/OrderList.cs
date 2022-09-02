using Newtonsoft.Json;
using System.Collections.Generic;
namespace ApontmentoWebAPI.Classes
{
     public class OrderList
    {
        public OrderList()
        {
            this.Orders = new List<Orders>();
        }
        [JsonProperty(propertyName: "orders")]
        public List<Orders> Orders { get; set; }
    }

}
