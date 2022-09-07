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
        //ao carregar o formulário preencher o Combobox com os dados da APIweb
        private void Form1_Load(object sender, EventArgs e)
        {
            WebAPI consultaAPI = new WebAPI(APIType.OrderList);
            orderList = consultaAPI.GetOrders(cbxOP);
        }

        //ao selecionar uma OP iniciar a contagem do tempo de produção e atualizar os controles com os dados da OP
        private void cbxOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOP.SelectedIndex == -1) return;
            btnPoint.Enabled = false;
            opSelectedInstant = DateTime.Now;
            _startTimer = opSelectedInstant;
            _runningTimer = true;


            lblProduct.Text = "Produto Selecionado: " + orderList.Orders[cbxOP.SelectedIndex].ProductCode;
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
            //limite reduzido para agilizar os testes, em operação normal retirar o /10
            var limit = orderList.Orders[cbxOP.SelectedIndex].CycleTime / 10;

            if (elapsedTime.TotalSeconds > limit)
            {
                btnPoint.Enabled = true;
                _runningTimer = false;
            }
        }

        //ao enviar um apontamento, montar o objeto com os resultados e enviar pela API
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
            WebAPI consultaAPI = new WebAPI(APIType.Production);
            consultaAPI.SendProduction(production);
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //ClearForm();
        }

        //private void ClearForm()
        //{
        //    _runningTimer = false;
        //    cbxOP.SelectedIndex = -1;
        //    cbxMaterial.SelectedIndex = -1;
        //    nudQuantity.Value = 0;
        //    picProduct.Image = null;
        //    lblProduct.Text = "Nenhum Produto Selecionado";
        //    btnPoint.Enabled = false;
        //    this.ProcessTabKey(true);
        //}


    }
}
