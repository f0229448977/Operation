using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class Operation02Report : Form
    {
        public Operation02Report(int monney, int year, double rate, double PMT, double All)
        {
            InitializeComponent();
            labMoney.Text = monney.ToString();
            labYear.Text = year.ToString();
            labRate.Text = rate.ToString();
            labAll.Text = All.ToString();
            labMonthpay.Text = PMT.ToString();
        }
    }
}
