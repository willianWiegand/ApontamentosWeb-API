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
        public DateTime opSelectedInstant;
        public OrderList orderList = new OrderList();
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

                MessageBox.Show("Erro ou obter resposta.");

            }


        }


        private void cbxOP_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnPoint.Enabled = false;
            opSelectedInstant = DateTime.Now;
            _startTimer = opSelectedInstant;
            _runningTimer = true;



            string produtoSelecionado = "Produto Selecionado: " + orderList.Orders[cbxOP.SelectedIndex].ProductCode;
            lblProduct.Text = produtoSelecionado;
            string inicioSelecao = "Início: " + opSelectedInstant;
            //lblStart.Text = inicioSelecao;
            cbxMaterial.Items.Clear();
            int selectedOP = cbxOP.SelectedIndex;
            nudQuantity.Value = (decimal)orderList.Orders[selectedOP].Quantity;
            int c = orderList.Orders[selectedOP].Materials.Count;

            for (int i = 0; i < c; i++)
            {
                string str = orderList.Orders[selectedOP].Materials[i].MaterialCode;
                cbxMaterial.Items.Add(str);
            }

            int imageID = Convert.ToInt16(orderList.Orders[selectedOP].Image.Substring(6, 1));
            picProduct.Image = imageList.Images[imageID];
            cbxMaterial.SelectedIndex = 0;
        }



        private void btnTimer_Tick(object sender, EventArgs e)
        {
            if (!_runningTimer)
                return;

            DateTime dateNow = DateTime.Now;
            TimeSpan elapsedTime = dateNow.Subtract(_startTimer);
            var limit = orderList.Orders[cbxOP.SelectedIndex].CycleTime/10;

            if (elapsedTime.TotalSeconds > limit)
            {
                btnPoint.Enabled = true;
                _runningTimer = false;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            DateTime pointInstant = DateTime.Now;
            Production production = new Production
            {
                Email = "willian.wiegand@gmail.com",
                Order = cbxOP.SelectedItem.ToString(),
                Quantity = (double)nudQuantity.Value,
                MaterialCode = orderList.Orders[cbxOP.SelectedIndex].Materials[cbxMaterial.SelectedIndex].MaterialCode,
                ProductionDate = pointInstant.ToString("yyyy-MM-dd"),
                ProductionTime = pointInstant.ToString("T"),
                CycleTime = (double)pointInstant.Subtract(opSelectedInstant).Seconds


            };
            string sendProduction = JsonConvert.SerializeObject(production);

            //MessageBox.Show(sendProduction);
            string stringURL = "http://demo-coleta.brazilsouth.cloudapp.azure.com:2070/api/orders/SetProduction";

            HttpClient client = new HttpClient();
            var httpContent = new StringContent(sendProduction, System.Text.Encoding.UTF8, "application/json");
            var postReturn = client.PostAsync(stringURL, httpContent).Result;
            if (postReturn.IsSuccessStatusCode)
            {
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
                this.Close();
                

            }

        }
    }
}
