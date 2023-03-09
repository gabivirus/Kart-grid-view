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

        double Total;

        private void Limpar()
        {
            PdtBox.Clear();
            ValueBox.Clear();
            QttBox.Clear();
            PdtBox.Focus();
        }

        public void CalcTotal()
        {
            Total = 0;

            foreach(DataGridViewRow row in ProductsGrid.Rows)
            {
                Total += Convert.ToDouble(row.Cells["total_col"].Value);
            }

            TotalBox.Text = Convert.ToDouble(Total).ToString("C");
        }

        private bool VerifyField()
        {
            if(PdtBox.Text == "" || QttBox.Text == "" || ValueBox.Text == "")
            {
                return false;
            }
            else { return true; }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            double Total = 0;
            double uValue, tValue;
            int qtt; string title;
            
            bool x = VerifyField();

            if (x)
            {
                qtt = Convert.ToInt32(QttBox.Text);
                title = PdtBox.Text;
                uValue = Convert.ToDouble(ValueBox.Text);
                tValue = uValue * qtt;

                ProductsGrid.Rows.Add(title, uValue, qtt, tValue);

                CalcTotal();

                Limpar();

            }

            else
            {
                MessageBox.Show("Campos em branco");
            }

            foreach(DataGridViewRow row in ProductsGrid.Rows)
            {
                Total = Convert.ToDouble(row.Cells["total_col"].Value);
            }

            TotalBox.Text = Convert.ToDouble(Total).ToString("C");

        }

        private void ValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsGrid.Rows.Remove(ProductsGrid.CurrentRow);
                CalcTotal();
            }
            catch
            {
                MessageBox.Show("Campo vazio");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
