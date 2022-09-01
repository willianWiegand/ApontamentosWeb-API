using ApontmentoWebAPI.Classes;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ApontmentoWebAPI
{
    public partial class FormApontamento : Form
    {
        public FormApontamento()
        {
            InitializeComponent();
        }

       // public string jsonSchema = "{\"type\": \"object\",\"properties\": {\"orders\": {\"type\": \"array\",\"items\": [{\"type\": \"object\",\"properties\": {\"order\": {\"type\": \"string\"},\"quantity\": {\"type\": \"number\"},\"productCode\": {\"type\": \"string\"},\"productDescription\": {\"type\": \"string\"},\"image\": {\"type\": \"string\"},\"cycleTime\": {\"type\": \"number\"},\"materials\": {\"type\": \"array\",\"items\": [{\"type\": \"object\",\"properties\": {\"materialCode\": { \"type\":\"string\"},"materialDescription": { "type":"string"}},"required": ["materialCode","materialDescription"]}]}},"required": ["order","quantityproductCode","productDescription","image","cycleTime","materials"]}]}}};

        private void Form1_Load(object sender, EventArgs e)
        {

            string stringURL = "http://demo-coleta.brazilsouth.cloudapp.azure.com:2070/api/orders/GetOrders";

            HttpClient client = new HttpClient();

            var repply = client.GetAsync(stringURL).Result;
            if (repply.IsSuccessStatusCode)
            {
                var response = repply.Content.ReadAsStringAsync().Result;
<<<<<<< HEAD
                OrderList orderList = JsonConvert.DeserializeObject<OrderList>(response);
                lstOP.Items[0] = repply.Content.ReadAsStringAsync().Result;
=======
                // JObject teste = JObjetc.parse(response);
                //bool valid = teste.IsValid(jsonSchema);
                OrderList orderList = JsonConvert.DeserializeObject<OrderList>(response);
                lstOP.Items.Clear();
                var c = orderList.Orders.Count;

                for ( int i = 1 ; i < c; i++)
                {
                    string str = "Teste "+i;
                    //string o2 = String.Format("{0}", orderList.Orders.Order.);
                    string ordr = orderList.Orders.ToString();
                    MessageBox.Show(ordr);
                    lstOP.Items.Add(str);
                    //lstOP.Items.AddRange(OrderList[].items);
                }
               // Orders teste = orderList.Orders.foreach (Orders item in collection)
	            //{
                 //   lstOP.Items.Add(item.order);

	          
                        //(String.Format(orderList.Orders[c].order));
                //}
                //lstOP.Items[0] = orderList(0).Orders.Order;
>>>>>>> 6a660d51d11bc24e15cb79bda29312276809ec10
                //lstOP.Items[1] = ordersList.Order;
            }
            else
            {
<<<<<<< HEAD

=======
                MessageBox.Show("Erro ou obter resposta.");
>>>>>>> 6a660d51d11bc24e15cb79bda29312276809ec10
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
