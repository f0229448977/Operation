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
    public partial class Operation02 : Form
    {

        int money,year,downpay,month;
        double R,rpn,PMT,All,PMT2,All2, rate;

        public Operation02()
        {
            InitializeComponent();
        }

        public void pay()
        {
            Int32.TryParse(txtMoney.Text, out money);//本金
            double.TryParse(txtRate.Text, out rate);//年利率
            Int32.TryParse(txtYear.Text, out year);//期限
            Int32.TryParse(txtDownPay.Text, out downpay);//頭期

            if (money > 0 && rate > 0 && year > 0 )
            {
                //PMT=money*(1+rate/12%)^(year*12)*((1+rate/12%)-1)
                //   /(1+rate/12%)^(year*12)-1

                R = 1.0 + rate / 12 / 100; //公比
                month = year * 12; //期數
                rpn = Math.Pow(R, month);

                PMT = (money - downpay) * rpn * (R - 1) / (rpn - 1);
                All = PMT * month;
                PMT2 = (int)PMT;
                All2 = (int)All;
            }
          
        }
 
        private void btnPMT_Click(object sender, EventArgs e)
        {
            
            
                pay();
                MessageBox.Show("月付額：" + PMT2 + "元");
          
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            
                pay();
                MessageBox.Show(" 總付額：" + All2 + "元");
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pay();
            Operation02Report OP021 = new Operation02Report(money,year,rate,PMT2,All2);
            OP021.Show(); ;
        }
    }
}
