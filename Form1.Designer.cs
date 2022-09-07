
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
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoint
            // 
            this.btnPoint.Enabled = false;
            this.btnPoint.Location = new System.Drawing.Point(287, 153);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(100, 28);
            this.btnPoint.TabIndex = 4;
            this.btnPoint.Text = "Apontar";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // cbxOP
            // 
            this.cbxOP.FormattingEnabled = true;
            this.cbxOP.Items.AddRange(new object[] {
            "aaaa1",
            "aaaa2",
            "bbbb1"});
            this.cbxOP.Location = new System.Drawing.Point(17, 39);
            this.cbxOP.Margin = new System.Windows.Forms.Padding(5);
            this.cbxOP.Name = "cbxOP";
            this.cbxOP.Size = new System.Drawing.Size(383, 24);
            this.cbxOP.TabIndex = 1;
            this.cbxOP.SelectedIndexChanged += new System.EventHandler(this.cbxOP_SelectedIndexChanged);
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.ItemHeight = 16;
            this.cbxMaterial.Location = new System.Drawing.Point(14, 114);
            this.cbxMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(199, 24);
            this.cbxMaterial.Sorted = true;
            this.cbxMaterial.TabIndex = 2;
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(16, 11);
            this.lblOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(99, 17);
            this.lblOP.TabIndex = 0;
            this.lblOP.Text = "Selecionar OP";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(14, 78);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(129, 17);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Selecionar Material";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 159);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(150, 17);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantidade Produzida";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(410, 17);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(197, 17);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Nenhum Produto Selecionado";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(175, 157);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.nudQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(92, 22);
            this.nudQuantity.TabIndex = 3;
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(413, 39);
            this.picProduct.Margin = new System.Windows.Forms.Padding(5);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(194, 142);
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
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(287, 110);
            this.btnClean.Margin = new System.Windows.Forms.Padding(5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 28);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(615, 188);
            this.Controls.Add(this.btnClean);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormApontamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apontamento API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
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
        private System.Windows.Forms.Button btnClean;
    }
}

