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

                OrderList orderList = JsonConvert.DeserializeObject<OrderList>(response);
                label1.Text = repply.Content.ReadAsStringAsync().Result;
                //this.lstOP.DataSource = orderList;
                lstOP.Items.Clear();
                //lstOP.Items.AddRange(new OrderList[] { JsonConvert.DeserializeObject<OrderList>(response) });
               var c = orderList.Orders.Count;

                for (int i = 1; i < c; i++)
                {
                    string str = orderList.Orders[i].Order;
                //    //string o2 = String.Format("{0}", orderList.Orders.Order.);
                //    string ordr = orderList.Orders.[1].Order;
                //    MessageBox.Show(ordr);
                    lstOP.Items.Add(str);

                }
                // Orders teste = orderList.Orders.foreach (Orders item in collection)
                //{
                //   lstOP.Items.Add(item.order);


                //(String.Format(orderList.Orders[c].order));
                //}

            }
            else
            {

                MessageBox.Show("Erro ou obter resposta.");

            }


        }


        private void lstOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPoint.Enabled = false;
            DateTime instanteSelecao = DateTime.Now;
            //            if (btnTimer.Enabled)
            //            {
            //                btnTimer.Dispose();
            //            }
            //            CreateTimer();
            //            btnTimer.Interval = 3000;
            //            btnTimer.Tick += new EventHandler(Time_Tick);
            //            btnTimer.Start();



            string produtoSelecionado = "Produto Selecionado: " + lstOP.SelectedItem;
            lblProduct.Text = produtoSelecionado;
            string inicioSelecao = "Início: " + instanteSelecao;
            lblStart.Text = inicioSelecao;
            lstMaterial.Items.Clear();

        }

        //        public void CreateTimer()
        //        {
        //           public Timer btnTimer = new Timer();
        //    }

        //    public void Time_Tick(object sender, EventArgs e)
        //    {
        //        this.btnPoint.Enabled = true;
        //    }
    }
}
