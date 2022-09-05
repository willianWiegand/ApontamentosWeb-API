using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ApontmentoWebAPI.Classes;

namespace ApontmentoWebAPI.Classes
{
    class WebAPI
    {
        public string URL { get; set; }
        public APIType Type { get; set; }

        public WebAPI(string url, APIType type)
        {
            URL = url;
            Type = type;
           
            switch (Type)
            {
                case APIType.Production:
                    URL += "SetProduction";
                break;

                case APIType.OrderList:
                    URL += "GetOrders";
                break;
            }

        }

        public void GetOrder(OrderList orderList)
        {

        }
    }
}
