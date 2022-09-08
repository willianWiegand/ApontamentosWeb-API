
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace ApontmentoWebAPI.Classes
{
    class WebAPI
    {
        public string URL { get; set; }
        public APIType Type { get; set; }
        HttpClient client = new HttpClient();

        public WebAPI(APIType type)
        {
            URL = "http://demo-coleta.brazilsouth.cloudapp.azure.com:2070/api/orders/";
            Type = type;

            switch (Type)
            {
                case APIType.Production:
                    URL += "SetProduction";
                    break;

                case APIType.OrderList:
                    URL += "GetOrders";
                    break;

                case APIType.ProductionList:
                    URL += "GetProduction?email=willian.wiegand@gmail.com";
                    break;


            }

        }

        public OrderList GetOrders(ComboBox cbxOP)
        {
            OrderList orderList = new OrderList();
            var repply = client.GetAsync(URL).Result;
            if (repply.IsSuccessStatusCode)
            {
                var response = repply.Content.ReadAsStringAsync().Result;
                orderList = JsonConvert.DeserializeObject<OrderList>(response);
                cbxOP.Items.Clear();
                var c = orderList.Orders.Count;

                for (int i = 0; i < c; i++)
                {
                    string str = orderList.Orders[i].Order;
                    cbxOP.Items.Add(str);
                }
            }
            else
            {
                MessageBox.Show("Erro ao obter resposta.");
            }
            return orderList;
        }
        public bool SendProduction(Production production)
        {
            string sendProduction = JsonConvert.SerializeObject(production);

            string stringURL = "http://demo-coleta.brazilsouth.cloudapp.azure.com:2070/api/orders/SetProduction";

            var httpContent = new StringContent(sendProduction, System.Text.Encoding.UTF8, "application/json");
            var postReturn = client.PostAsync(stringURL, httpContent).Result;
            var response = postReturn.Content.ReadAsStringAsync().Result;
            Return msgReturn = JsonConvert.DeserializeObject<Return>(response);
            string stringReturn =
                "Retorno de apontamento\n"
                + "Status: "
                + msgReturn.Status
                + "\nType: "
                + msgReturn.Type
                + "\nDescrição: "
                + msgReturn.Description;
            MessageBox.Show(stringReturn);
            return postReturn.IsSuccessStatusCode;
        }

        internal void GetProduction(DataGridView gridGetProduction)
        {
            var repply = client.GetAsync(URL).Result;
            if (repply.IsSuccessStatusCode)
            {
                var response = repply.Content.ReadAsStringAsync().Result;
                Production productionList = JsonConvert.DeserializeObject<Production>(response);
                
                var c = productionList.Productions.Count;
                gridGetProduction.DataSource = productionList.Productions;

                //for (int i = 0; i < c; i++)
                //{
                //    Production p.Productions[i] = productionList.Productions[i];
                    
                //}
            }
            else
            {
                MessageBox.Show("Erro ao obter resposta.");
            }
        }
    }
}
