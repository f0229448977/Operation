using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Operation
{
    public partial class Operation06 : Form
    {
        public Operation06()
        {
            InitializeComponent();

        }
        int result , Num1, Num2;
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool IsNum1 = int.TryParse(txtNum1.Text, out Num1);
            bool IsNum2 = int.TryParse(txtNum2.Text, out Num2);

                if (IsNum1 == true && IsNum2 == true)
            {
                result = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
                txtAnswer.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show ("請輸入數值！");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bool IsNum1 = int.TryParse(txtNum1.Text, out Num1);
            bool IsNum2 = int.TryParse(txtNum2.Text, out Num2);

            if (IsNum1 == true && IsNum2 == true)
            {
                result = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
                txtAnswer.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        

        private void btnmultip_Click(object sender, EventArgs e)
        {
            bool IsNum1 = int.TryParse(txtNum1.Text, out Num1);
            bool IsNum2 = int.TryParse(txtNum2.Text, out Num2);
            if (IsNum1 == true && IsNum2 == true)
            {
                result = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
                txtAnswer.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            bool IsNum1 = int.TryParse(txtNum1.Text, out Num1);
            bool IsNum2 = int.TryParse(txtNum2.Text, out Num2);
            if (IsNum1 == true && IsNum2 == true)
            {
                result = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
                txtAnswer.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}
