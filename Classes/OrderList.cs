<<<<<<< HEAD
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontmentoWebAPI.Classes
{
     public class OrderList
    {
        public OrderList()
        {
            this.Orders = new Orders();
        }
        //propriedade ou array???
        [JsonProperty(propertyName: "orders")]
        public Orders Orders { get; set; }
    }
}
=======
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontmentoWebAPI.Classes
{
     public class OrderList
    {
        public OrderList()
        {
            this.Orders = new List<Orders>();
        }
        //propriedade ou array???
        [JsonProperty(propertyName: "orders")]
        public List<Orders> Orders { get; set; }
    }

}
>>>>>>> 6a660d51d11bc24e15cb79bda29312276809ec10
