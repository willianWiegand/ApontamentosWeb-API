using ApontmentoWebAPI.Classes;
using System;
using System.Drawing;
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
            this.Size = new Size(380, 283);
            pnlGetProduction.Location = new Point(0, 0);
            pnlGetProduction.BringToFront();
            pnlGetProduction.Visible = false;




        }
        //ao carregar o formulário preencher o Combobox com os dados da APIweb
        private void Form1_Load(object sender, EventArgs e)
        {
            WebAPI getAPI = new WebAPI(APIType.OrderList);
            orderList = getAPI.GetOrders(cbxOP);
        }

        //ao selecionar uma OP iniciar a contagem do tempo de produção e atualizar os controles com os dados da OP
        private void cbxOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOP.SelectedIndex == -1) return;
            btnPoint.Enabled = false;
            _startTimer = DateTime.Now;
            _runningTimer = true;
            this.toolTip1.SetToolTip(this.lblTimeCounter, "Apontamento habilitado após decorrido o tempo de ciclo padrão");
            lblProduct.Text = "Produto Selecionado: " + orderList.Orders[cbxOP.SelectedIndex].ProductCode;
            lblCycleTime.Text = "Tempo de ciclo padrão: " + orderList.Orders[cbxOP.SelectedIndex].CycleTime + "s";
            int imageID = Convert.ToInt16(orderList.Orders[cbxOP.SelectedIndex].Image.Substring(6, 1));
            picProduct.Image = imageList.Images[imageID];
            cbxMaterial.Items.Clear();
            int c = orderList.Orders[cbxOP.SelectedIndex].Materials.Count;

            for (int i = 0; i < c; i++)
            {
                string str = orderList.Orders[cbxOP.SelectedIndex].Materials[i].MaterialCode;
                cbxMaterial.Items.Add(str);
            }
            cbxMaterial.SelectedIndex = 0;
            nudQuantity.Value = (decimal)orderList.Orders[cbxOP.SelectedIndex].Quantity;

        }



        private void btnTimer_Tick(object sender, EventArgs e)
        {
            if (!_runningTimer)
                return;

            DateTime dateNow = DateTime.Now;
            TimeSpan elapsedTime = dateNow.Subtract(_startTimer);
            lblTimeCounter.Text = "Decorridos " + elapsedTime.Seconds + "s";
            //limite reduzido para agilizar os testes, em operação normal retirar o /10
            var limit = orderList.Orders[cbxOP.SelectedIndex].CycleTime;

            if (elapsedTime.TotalSeconds > limit)
            {
                btnPoint.Enabled = true;
                //_runningTimer = false;
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
            WebAPI postAPI = new WebAPI(APIType.Production);
            bool ok = postAPI.SendProduction(production);
            if (ok) ClearForm();

        }
        private void btnGetProduction_Click(object sender, EventArgs e)
        {

            pnlGetProduction.Visible = true;


            WebAPI getProductionAPI = new WebAPI(APIType.ProductionList);
            getProductionAPI.GetProduction(gridGetProduction);
        }

        public void ClearForm()
        {
            _runningTimer = false;
            cbxOP.SelectedIndex = -1;
            cbxMaterial.SelectedIndex = -1;
            nudQuantity.Value = 0;
            picProduct.Image = null;
            lblProduct.Text = "Nenhum Produto Selecionado";
            lblCycleTime.Text = "";
            lblTimeCounter.Text = "";
            btnPoint.Enabled = false;
            this.ProcessTabKey(true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlGetProduction.Visible = false;
        }

    }
}
