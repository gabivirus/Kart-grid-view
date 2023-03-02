
namespace GridView
{
    partial class GridVisual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProdLabel = new System.Windows.Forms.Label();
            this.ProdBox = new System.Windows.Forms.TextBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.QttBox = new System.Windows.Forms.TextBox();
            this.QtdLabel = new System.Windows.Forms.Label();
            this.Carrinho = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdLabel
            // 
            this.ProdLabel.AutoSize = true;
            this.ProdLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ProdLabel.Location = new System.Drawing.Point(52, 13);
            this.ProdLabel.Name = "ProdLabel";
            this.ProdLabel.Size = new System.Drawing.Size(63, 18);
            this.ProdLabel.TabIndex = 0;
            this.ProdLabel.Text = "Produto:";
            // 
            // ProdBox
            // 
            this.ProdBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ProdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProdBox.Location = new System.Drawing.Point(55, 34);
            this.ProdBox.Name = "ProdBox";
            this.ProdBox.Size = new System.Drawing.Size(184, 26);
            this.ProdBox.TabIndex = 1;
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ValueBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ValueBox.Location = new System.Drawing.Point(248, 34);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(145, 26);
            this.ValueBox.TabIndex = 3;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(245, 13);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(45, 18);
            this.ValueLabel.TabIndex = 2;
            this.ValueLabel.Text = "Valor:";
            // 
            // QttBox
            // 
            this.QttBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.QttBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.QttBox.Location = new System.Drawing.Point(399, 34);
            this.QttBox.Name = "QttBox";
            this.QttBox.Size = new System.Drawing.Size(110, 26);
            this.QttBox.TabIndex = 5;
            // 
            // QtdLabel
            // 
            this.QtdLabel.AutoSize = true;
            this.QtdLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.QtdLabel.Location = new System.Drawing.Point(396, 13);
            this.QtdLabel.Name = "QtdLabel";
            this.QtdLabel.Size = new System.Drawing.Size(86, 18);
            this.QtdLabel.TabIndex = 4;
            this.QtdLabel.Text = "Quantidade:";
            // 
            // Carrinho
            // 
            this.Carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Valor,
            this.Quantidade,
            this.Total});
            this.Carrinho.Location = new System.Drawing.Point(55, 130);
            this.Carrinho.Name = "Carrinho";
            this.Carrinho.Size = new System.Drawing.Size(454, 229);
            this.Carrinho.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(55, 88);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(454, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Adiconar ao carrinho";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeaveBtn.Location = new System.Drawing.Point(55, 369);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(110, 23);
            this.LeaveBtn.TabIndex = 8;
            this.LeaveBtn.Text = "Sair";
            this.LeaveBtn.UseVisualStyleBackColor = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 110;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 40;
            // 
            // Total
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // TotalBox
            // 
            this.TotalBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.TotalBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TotalBox.Location = new System.Drawing.Point(399, 366);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(110, 26);
            this.TotalBox.TabIndex = 10;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.TotalLabel.Location = new System.Drawing.Point(307, 369);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(86, 18);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Quantidade:";
            // 
            // GridVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 409);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.Carrinho);
            this.Controls.Add(this.QttBox);
            this.Controls.Add(this.QtdLabel);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ProdBox);
            this.Controls.Add(this.ProdLabel);
            this.Name = "GridVisual";
            this.Text = "GridView";
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProdLabel;
        private System.Windows.Forms.TextBox ProdBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox QttBox;
        private System.Windows.Forms.Label QtdLabel;
        private System.Windows.Forms.DataGridView Carrinho;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button LeaveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label TotalLabel;
    }
}

