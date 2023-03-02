using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class GridVisual : Form
    {
        public GridVisual()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            double price, summ, tall = 0;
            int ammount = 0;
            string name;

            name = ProdBox.Text;

            try { ammount = int.Parse(QttBox.Text); }
            catch { ammount = Convert.ToInt32(QttBox.Text); }

            price = Convert.ToDouble(ValueBox.Text);
            summ = price * ammount;

            Carrinho.Rows.Add(name, price, ammount, summ);

            foreach(DataGridViewRow row in Carrinho.Rows)
            {
                tall += Convert.ToDouble(row.Cells["Total"].Value);
            }

            TotalBox.Text = Convert.ToDouble(tall).ToString("C");
        }
    }
}
