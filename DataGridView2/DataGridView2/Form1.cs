using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            double uValue, tValue, Total = 0;
            int qtt; string title;

            qtt = Convert.ToInt32(QttBox.Text);
            title = PdtBox.Text;
            uValue = Convert.ToDouble(valueBox.Text);
            tValue = uValue * qtt;

            ProductsGrid.Rows.Add(title, uValue, qtt, tValue);

            foreach(DataGridViewRow row in ProductsGrid.Rows)
            {
                Total = Convert.ToDouble(row.Cells["total_col"].Value);
            }

            TotalBox.Text = Convert.ToDouble(Total).ToString("C");

        }
    }
}
