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

        private void Form1_Load(object sender, EventArgs e)
        {

            string stringURL = "http://demo-coleta.brazilsouth.cloudapp.azure.com:2070/api/orders/GetOrders";

            HttpClient client = new HttpClient();

            var repply = client.GetAsync(stringURL).Result;
            if (repply.IsSuccessStatusCode)
            {
                var response = repply.Content.ReadAsStringAsync().Result;
                OrderList orderList = JsonConvert.DeserializeObject<OrderList>(response);
                lstOP.Items[0] = repply.Content.ReadAsStringAsync().Result;
                //lstOP.Items[1] = ordersList.Order;
            }
            else
            {

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
