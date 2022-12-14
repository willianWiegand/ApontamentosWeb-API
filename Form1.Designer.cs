
using System.Windows.Forms;

namespace ApontmentoWebAPI
{
    partial class FormApontamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApontamento));
            this.btnPoint = new System.Windows.Forms.Button();
            this.cbxOP = new System.Windows.Forms.ComboBox();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnGetPRoduction = new System.Windows.Forms.Button();
            this.lblTimeCounter = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCycleTime = new System.Windows.Forms.Label();
            this.pnlGetProduction = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gridGetProduction = new System.Windows.Forms.DataGridView();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionCompleteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnlGetProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGetProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoint
            // 
            this.btnPoint.Enabled = false;
            this.btnPoint.Location = new System.Drawing.Point(200, 210);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(75, 23);
            this.btnPoint.TabIndex = 4;
            this.btnPoint.Text = "Apontar";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // cbxOP
            // 
            this.cbxOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOP.FormattingEnabled = true;
            this.cbxOP.Items.AddRange(new object[] {
            "aaaa1",
            "aaaa2",
            "bbbb1"});
            this.cbxOP.Location = new System.Drawing.Point(13, 32);
            this.cbxOP.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOP.Name = "cbxOP";
            this.cbxOP.Size = new System.Drawing.Size(173, 21);
            this.cbxOP.TabIndex = 1;
            this.cbxOP.SelectedIndexChanged += new System.EventHandler(this.cbxOP_SelectedIndexChanged);
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.ItemHeight = 13;
            this.cbxMaterial.Location = new System.Drawing.Point(204, 32);
            this.cbxMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(150, 21);
            this.cbxMaterial.Sorted = true;
            this.cbxMaterial.TabIndex = 2;
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(12, 9);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(86, 15);
            this.lblOP.TabIndex = 0;
            this.lblOP.Text = "Selecionar OP";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(201, 9);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(114, 15);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Selecionar Material";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(201, 67);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(130, 15);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantidade Produzida";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(13, 67);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(173, 15);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Nenhum Produto Selecionado";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(204, 86);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(69, 20);
            this.nudQuantity.TabIndex = 3;
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(13, 85);
            this.picProduct.Margin = new System.Windows.Forms.Padding(4);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(171, 129);
            this.picProduct.TabIndex = 7;
            this.picProduct.TabStop = false;
            this.picProduct.Tag = "a";
            // 
            // btnTimer
            // 
            this.btnTimer.Enabled = true;
            this.btnTimer.Interval = 500;
            this.btnTimer.Tick += new System.EventHandler(this.btnTimer_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Imagem 0x00000.png");
            this.imageList.Images.SetKeyName(1, "Imagem 0x00001.png");
            this.imageList.Images.SetKeyName(2, "Imagem 0x00002.png");
            // 
            // btnGetPRoduction
            // 
            this.btnGetPRoduction.Location = new System.Drawing.Point(280, 210);
            this.btnGetPRoduction.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetPRoduction.Name = "btnGetPRoduction";
            this.btnGetPRoduction.Size = new System.Drawing.Size(75, 23);
            this.btnGetPRoduction.TabIndex = 5;
            this.btnGetPRoduction.Text = "Consultar";
            this.btnGetPRoduction.UseVisualStyleBackColor = true;
            this.btnGetPRoduction.Click += new System.EventHandler(this.btnGetProduction_Click);
            // 
            // lblTimeCounter
            // 
            this.lblTimeCounter.AutoSize = true;
            this.lblTimeCounter.Location = new System.Drawing.Point(201, 194);
            this.lblTimeCounter.Name = "lblTimeCounter";
            this.lblTimeCounter.Size = new System.Drawing.Size(0, 15);
            this.lblTimeCounter.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // lblCycleTime
            // 
            this.lblCycleTime.AutoSize = true;
            this.lblCycleTime.Location = new System.Drawing.Point(13, 218);
            this.lblCycleTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCycleTime.Name = "lblCycleTime";
            this.lblCycleTime.Size = new System.Drawing.Size(0, 15);
            this.lblCycleTime.TabIndex = 0;
            // 
            // pnlGetProduction
            // 
            this.pnlGetProduction.Controls.Add(this.btnBack);
            this.pnlGetProduction.Controls.Add(this.gridGetProduction);
            this.pnlGetProduction.Location = new System.Drawing.Point(371, 0);
            this.pnlGetProduction.Name = "pnlGetProduction";
            this.pnlGetProduction.Size = new System.Drawing.Size(370, 240);
            this.pnlGetProduction.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 20);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridGetProduction
            // 
            this.gridGetProduction.AllowUserToAddRows = false;
            this.gridGetProduction.AllowUserToDeleteRows = false;
            this.gridGetProduction.AllowUserToOrderColumns = true;
            this.gridGetProduction.AutoGenerateColumns = false;
            this.gridGetProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGetProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDataGridViewTextBoxColumn,
            this.ProductionCompleteDate,
            this.quantityDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.cycleTimeDataGridViewTextBoxColumn});
            this.gridGetProduction.DataSource = this.productionBindingSource;
            this.gridGetProduction.Location = new System.Drawing.Point(0, 20);
            this.gridGetProduction.Name = "gridGetProduction";
            this.gridGetProduction.ReadOnly = true;
            this.gridGetProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridGetProduction.RowHeadersWidth = 20;
            this.gridGetProduction.Size = new System.Drawing.Size(367, 220);
            this.gridGetProduction.TabIndex = 0;
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataSource = typeof(ApontmentoWebAPI.Classes.Production);
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDataGridViewTextBoxColumn.Width = 50;
            // 
            // ProductionCompleteDate
            // 
            this.ProductionCompleteDate.DataPropertyName = "ProductionCompleteDate";
            this.ProductionCompleteDate.HeaderText = "ProductionCompleteDate";
            this.ProductionCompleteDate.MinimumWidth = 6;
            this.ProductionCompleteDate.Name = "ProductionCompleteDate";
            this.ProductionCompleteDate.ReadOnly = true;
            this.ProductionCompleteDate.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Qnt.";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 35;
            // 
            // materialCodeDataGridViewTextBoxColumn
            // 
            this.materialCodeDataGridViewTextBoxColumn.DataPropertyName = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialCodeDataGridViewTextBoxColumn.Name = "materialCodeDataGridViewTextBoxColumn";
            this.materialCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialCodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // cycleTimeDataGridViewTextBoxColumn
            // 
            this.cycleTimeDataGridViewTextBoxColumn.DataPropertyName = "CycleTime";
            this.cycleTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.cycleTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cycleTimeDataGridViewTextBoxColumn.Name = "cycleTimeDataGridViewTextBoxColumn";
            this.cycleTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cycleTimeDataGridViewTextBoxColumn.Width = 40;
            // 
            // FormApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 321);
            this.Controls.Add(this.pnlGetProduction);
            this.Controls.Add(this.lblCycleTime);
            this.Controls.Add(this.lblTimeCounter);
            this.Controls.Add(this.btnGetPRoduction);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.cbxOP);
            this.Controls.Add(this.btnPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormApontamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apontamento API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnlGetProduction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGetProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.ComboBox cbxOP;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Timer btnTimer;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnGetPRoduction;
        private Label lblTimeCounter;
        private ToolTip toolTip1;
        private Label lblCycleTime;
        private Panel pnlGetProduction;
        private DataGridView gridGetProduction;
        private BindingSource productionBindingSource;
        private Button btnBack;
        private DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductionCompleteDate;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cycleTimeDataGridViewTextBoxColumn;
    }
}

