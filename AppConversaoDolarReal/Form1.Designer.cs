namespace AppConversaoDolarReal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelFinanciamento = new System.Windows.Forms.Label();
            this.labelTaxa = new System.Windows.Forms.Label();
            this.txtValorFinanciamento = new System.Windows.Forms.TextBox();
            this.txtTaxadeJuros = new System.Windows.Forms.TextBox();
            this.btnConverte = new System.Windows.Forms.Button();
            this.labelResultadoParcela = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.labelParcelas = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelTotalJuros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFinanciamento
            // 
            this.labelFinanciamento.AutoSize = true;
            this.labelFinanciamento.Location = new System.Drawing.Point(331, 85);
            this.labelFinanciamento.Name = "labelFinanciamento";
            this.labelFinanciamento.Size = new System.Drawing.Size(118, 13);
            this.labelFinanciamento.TabIndex = 0;
            this.labelFinanciamento.Text = "Valor do Financiamento";
            this.labelFinanciamento.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTaxa
            // 
            this.labelTaxa.AutoSize = true;
            this.labelTaxa.Location = new System.Drawing.Point(331, 145);
            this.labelTaxa.Name = "labelTaxa";
            this.labelTaxa.Size = new System.Drawing.Size(103, 13);
            this.labelTaxa.TabIndex = 1;
            this.labelTaxa.Text = "Taxa de Juros anual";
            this.labelTaxa.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValorFinanciamento
            // 
            this.txtValorFinanciamento.Location = new System.Drawing.Point(334, 101);
            this.txtValorFinanciamento.Name = "txtValorFinanciamento";
            this.txtValorFinanciamento.Size = new System.Drawing.Size(100, 20);
            this.txtValorFinanciamento.TabIndex = 1;
            // 
            // txtTaxadeJuros
            // 
            this.txtTaxadeJuros.Location = new System.Drawing.Point(335, 161);
            this.txtTaxadeJuros.Name = "txtTaxadeJuros";
            this.txtTaxadeJuros.Size = new System.Drawing.Size(100, 20);
            this.txtTaxadeJuros.TabIndex = 2;
            this.txtTaxadeJuros.TextChanged += new System.EventHandler(this.txtValorReal_TextChanged);
            // 
            // btnConverte
            // 
            this.btnConverte.Image = ((System.Drawing.Image)(resources.GetObject("btnConverte.Image")));
            this.btnConverte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverte.Location = new System.Drawing.Point(337, 238);
            this.btnConverte.Name = "btnConverte";
            this.btnConverte.Size = new System.Drawing.Size(98, 23);
            this.btnConverte.TabIndex = 3;
            this.btnConverte.Text = "Calcular";
            this.btnConverte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverte.UseVisualStyleBackColor = true;
            this.btnConverte.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResultadoParcela
            // 
            this.labelResultadoParcela.AutoSize = true;
            this.labelResultadoParcela.Location = new System.Drawing.Point(334, 285);
            this.labelResultadoParcela.Name = "labelResultadoParcela";
            this.labelResultadoParcela.Size = new System.Drawing.Size(85, 13);
            this.labelResultadoParcela.TabIndex = 6;
            this.labelResultadoParcela.Text = "Valor da Parcela";
            this.labelResultadoParcela.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 454);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(334, 200);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtParcelas.TabIndex = 8;
            // 
            // labelParcelas
            // 
            this.labelParcelas.AutoSize = true;
            this.labelParcelas.Location = new System.Drawing.Point(332, 184);
            this.labelParcelas.Name = "labelParcelas";
            this.labelParcelas.Size = new System.Drawing.Size(103, 13);
            this.labelParcelas.TabIndex = 9;
            this.labelParcelas.Text = "Número de Parcelas";
            this.labelParcelas.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(337, 331);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(64, 13);
            this.labelValorTotal.TabIndex = 10;
            this.labelValorTotal.Text = "Total pago: ";
            // 
            // labelTotalJuros
            // 
            this.labelTotalJuros.AutoSize = true;
            this.labelTotalJuros.Location = new System.Drawing.Point(337, 309);
            this.labelTotalJuros.Name = "labelTotalJuros";
            this.labelTotalJuros.Size = new System.Drawing.Size(97, 13);
            this.labelTotalJuros.TabIndex = 11;
            this.labelTotalJuros.Text = "Valor total de juros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalJuros);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.labelParcelas);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelResultadoParcela);
            this.Controls.Add(this.btnConverte);
            this.Controls.Add(this.txtTaxadeJuros);
            this.Controls.Add(this.txtValorFinanciamento);
            this.Controls.Add(this.labelTaxa);
            this.Controls.Add(this.labelFinanciamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFinanciamento;
        private System.Windows.Forms.Label labelTaxa;
        private System.Windows.Forms.TextBox txtValorFinanciamento;
        private System.Windows.Forms.TextBox txtTaxadeJuros;
        private System.Windows.Forms.Button btnConverte;
        private System.Windows.Forms.Label labelResultadoParcela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.Label labelParcelas;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelTotalJuros;
    }
}

