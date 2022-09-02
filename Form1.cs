using ApontmentoWebAPI.Classes;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ApontmentoWebAPI
{


    public partial class FormApontamento : Form
    {
        private DateTime _startTimer = DateTime.MinValue;
        private bool _runningTimer = false;
        public OrderList orderList = new OrderList();
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

                orderList = JsonConvert.DeserializeObject<OrderList>(response);
                               //this.lstOP.DataSource = orderList;
                lstOP.Items.Clear();
                //lstOP.Items.AddRange(new OrderList[] { JsonConvert.DeserializeObject<OrderList>(response) });
                var c = orderList.Orders.Count;

                for (int i = 0; i < c; i++)
                {
                    string str = orderList.Orders[i].Order;
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
            label1.Text = orderList.Orders[lstOP.SelectedIndex].CycleTime.ToString();
            btnPoint.Enabled = false;
            DateTime instanteSelecao = DateTime.Now;
            _startTimer = instanteSelecao;
            _runningTimer = true;



            string produtoSelecionado = "Produto Selecionado: " + lstOP.SelectedItem;
            lblProduct.Text = produtoSelecionado;
            string inicioSelecao = "Início: " + instanteSelecao;
            lblStart.Text = inicioSelecao;
            lstMaterial.Items.Clear();
            int selectedOP = lstOP.SelectedIndex;
            nudQuantity.Value = orderList.Orders[selectedOP].Quantity;
            int c = orderList.Orders[selectedOP].Materials.Count;

            for (int i = 0; i < c; i++)
            {
                string str = orderList.Orders[selectedOP].Materials[i].MaterialCode;
                lstMaterial.Items.Add(str);
            }


        }

        private void lstMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedOP = lstOP.SelectedIndex;

        }
        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimer_Tick(object sender, EventArgs e)
        {
            if (!_runningTimer)
                return;

            DateTime dateNow = DateTime.Now;
            TimeSpan elapsedTime = dateNow.Subtract(_startTimer);
            var limit = orderList.Orders[lstOP.SelectedIndex].CycleTime;

            if (elapsedTime.TotalSeconds > limit)
            {
                btnPoint.Enabled = true;
                _runningTimer = false;
            }
        }

    }
}
