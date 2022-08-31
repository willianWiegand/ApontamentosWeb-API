
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApontamento));
            this.btnPoint = new System.Windows.Forms.Button();
            this.lstOP = new System.Windows.Forms.ListBox();
            this.lstMaterial = new System.Windows.Forms.ListBox();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(381, 266);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(75, 23);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = "Apontar";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // lstOP
            // 
            this.lstOP.FormattingEnabled = true;
            this.lstOP.Items.AddRange(new object[] {
            "aaaa1",
            "aaaa2",
            "bbbb1"});
            this.lstOP.Location = new System.Drawing.Point(12, 25);
            this.lstOP.Name = "lstOP";
            this.lstOP.Size = new System.Drawing.Size(288, 264);
            this.lstOP.TabIndex = 1;
            // 
            // lstMaterial
            // 
            this.lstMaterial.FormattingEnabled = true;
            this.lstMaterial.Items.AddRange(new object[] {
            "a",
            "b"});
            this.lstMaterial.Location = new System.Drawing.Point(306, 167);
            this.lstMaterial.Name = "lstMaterial";
            this.lstMaterial.Size = new System.Drawing.Size(150, 82);
            this.lstMaterial.TabIndex = 2;
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(12, 9);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(75, 13);
            this.lblOP.TabIndex = 0;
            this.lblOP.Text = "Selecionar OP";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(303, 151);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(97, 13);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Selecionar Material";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(303, 252);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(112, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantidade Produzida";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(303, 25);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(109, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto Selecionado:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(306, 269);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(69, 20);
            this.nudQuantity.TabIndex = 3;
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(306, 41);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(150, 107);
            this.picProduto.TabIndex = 7;
            this.picProduto.TabStop = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(303, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(37, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Início:";
            // 
            // FormApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 300);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picProduto);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.lstMaterial);
            this.Controls.Add(this.lstOP);
            this.Controls.Add(this.btnPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormApontamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
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
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Label lblStart;
    }
}

