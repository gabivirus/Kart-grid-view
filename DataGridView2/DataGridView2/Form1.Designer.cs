
namespace DataGridView2
{
    partial class Table
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
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.pdt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.PdtBox = new System.Windows.Forms.TextBox();
            this.labelPdt = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.QttBox = new System.Windows.Forms.TextBox();
            this.labelQtd = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pdt_col,
            this.value_col,
            this.qtt_col,
            this.total_col});
            this.ProductsGrid.Location = new System.Drawing.Point(12, 169);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.Size = new System.Drawing.Size(638, 187);
            this.ProductsGrid.TabIndex = 0;
            // 
            // pdt_col
            // 
            this.pdt_col.HeaderText = "Produto";
            this.pdt_col.MinimumWidth = 100;
            this.pdt_col.Name = "pdt_col";
            this.pdt_col.Width = 200;
            // 
            // value_col
            // 
            this.value_col.HeaderText = "V. unitário";
            this.value_col.MinimumWidth = 50;
            this.value_col.Name = "value_col";
            this.value_col.Width = 120;
            // 
            // qtt_col
            // 
            this.qtt_col.HeaderText = "Quantidade";
            this.qtt_col.MinimumWidth = 100;
            this.qtt_col.Name = "qtt_col";
            // 
            // total_col
            // 
            this.total_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_col.HeaderText = "Total";
            this.total_col.MinimumWidth = 100;
            this.total_col.Name = "total_col";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 367);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(15, 383);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(160, 20);
            this.TotalBox.TabIndex = 2;
            // 
            // PdtBox
            // 
            this.PdtBox.Location = new System.Drawing.Point(14, 31);
            this.PdtBox.Name = "PdtBox";
            this.PdtBox.Size = new System.Drawing.Size(161, 20);
            this.PdtBox.TabIndex = 4;
            // 
            // labelPdt
            // 
            this.labelPdt.AutoSize = true;
            this.labelPdt.Location = new System.Drawing.Point(11, 15);
            this.labelPdt.Name = "labelPdt";
            this.labelPdt.Size = new System.Drawing.Size(50, 13);
            this.labelPdt.TabIndex = 3;
            this.labelPdt.Text = " Produto:";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(14, 81);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(161, 20);
            this.valueBox.TabIndex = 6;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 65);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(57, 13);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "V. unitário:";
            // 
            // QttBox
            // 
            this.QttBox.Location = new System.Drawing.Point(14, 129);
            this.QttBox.Name = "QttBox";
            this.QttBox.Size = new System.Drawing.Size(161, 20);
            this.QttBox.TabIndex = 8;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(12, 113);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(65, 13);
            this.labelQtd.TabIndex = 7;
            this.labelQtd.Text = "Quantidade:";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBtn.Location = new System.Drawing.Point(587, 31);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(63, 118);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Adicionar";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.QttBox);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.PdtBox);
            this.Controls.Add(this.labelPdt);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ProductsGrid);
            this.Name = "Table";
            this.Text = "Carrinho";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_col;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.TextBox PdtBox;
        private System.Windows.Forms.Label labelPdt;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox QttBox;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Button AddBtn;
    }
}

