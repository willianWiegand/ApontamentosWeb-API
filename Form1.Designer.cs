
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
            this.lstOP = new System.Windows.Forms.ListBox();
            this.lstMaterial = new System.Windows.Forms.ListBox();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoint
            // 
            this.btnPoint.Enabled = false;
            this.btnPoint.Location = new System.Drawing.Point(508, 327);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(100, 28);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = "Apontar";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // lstOP
            // 
            this.lstOP.FormattingEnabled = true;
            this.lstOP.ItemHeight = 16;
            this.lstOP.Items.AddRange(new object[] {
            "aaaa1",
            "aaaa2",
            "bbbb1"});
            this.lstOP.Location = new System.Drawing.Point(13, 32);
            this.lstOP.Margin = new System.Windows.Forms.Padding(4);
            this.lstOP.Name = "lstOP";
            this.lstOP.Size = new System.Drawing.Size(383, 324);
            this.lstOP.TabIndex = 1;
            this.lstOP.SelectedIndexChanged += new System.EventHandler(this.lstOP_SelectedIndexChanged);
            // 
            // lstMaterial
            // 
            this.lstMaterial.FormattingEnabled = true;
            this.lstMaterial.ItemHeight = 16;
            this.lstMaterial.Items.AddRange(new object[] {
            "a",
            "b"});
            this.lstMaterial.Location = new System.Drawing.Point(408, 206);
            this.lstMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.lstMaterial.Name = "lstMaterial";
            this.lstMaterial.Size = new System.Drawing.Size(199, 100);
            this.lstMaterial.TabIndex = 2;
            this.lstMaterial.SelectedIndexChanged += new System.EventHandler(this.lstMaterial_SelectedIndexChanged);
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
            this.lblMaterial.Location = new System.Drawing.Point(404, 186);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(129, 17);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Selecionar Material";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(404, 310);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(150, 17);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantidade Produzida";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(404, 55);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(144, 17);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Produto Selecionado:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(408, 331);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(92, 22);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(408, 76);
            this.picProduct.Margin = new System.Windows.Forms.Padding(4);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(200, 106);
            this.picProduct.TabIndex = 7;
            this.picProduct.TabStop = false;
            this.picProduct.Tag = "a";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(405, 32);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 17);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Início:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecionar OP";
            // 
            // btnTimer
            // 
            this.btnTimer.Enabled = true;
            this.btnTimer.Interval = 500;
            this.btnTimer.Tick += new System.EventHandler(this.btnTimer_Tick);
            // 
            // FormApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.lstMaterial);
            this.Controls.Add(this.lstOP);
            this.Controls.Add(this.btnPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormApontamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.ListBox lstOP;
        private System.Windows.Forms.ListBox lstMaterial;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer btnTimer;
    }
}

