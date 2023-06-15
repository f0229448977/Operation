using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Operation
{
    public partial class Operation03 : Form
    {
        public Operation03()
        {
            InitializeComponent();
        }
        
        int count, total,BeerCount, Beertotal, Tequilacount, Tequilatotal, Whiskycount, Whiskytotal, Winecount, Winetotal;

        string[] StrAll = new string[4];


        private void btnBeer_Click(object sender, EventArgs e)
        {
            
            BeerCount++;
            Beertotal += 120;

            StrAll[0]  =  "啤酒Beer x" + BeerCount + ",共NT$" + Beertotal + "元" + "\r\n";
            into();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            Tequilacount++;
            Tequilatotal += 180;

            StrAll[1] = "龍舌蘭Tequila x" + Tequilacount + ",共NT$" + Tequilatotal + "元" + "\r\n";
            into();
        }



        private void btnWhisky_Click(object sender, EventArgs e)
        {
            Whiskycount++;
            Whiskytotal += 350;

            StrAll[2] = "威士忌Whisky x" + Whiskycount + ",共NT$" + Whiskytotal + "元" + "\r\n";
            into();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            Winecount++;
            Winetotal += 320;

            StrAll[3] = "紅酒Wine x" + Winecount + ",共NT$" + Winetotal + "元" + "\r\n";
            into();

        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            
            if (total != 0) 
            { 
                MessageBox.Show("總金額：NT$" + total);
            }
            else
            { 
                MessageBox.Show("尚未點餐！"); 
            }
                
        }
        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if (total != 0)
            {
                MessageBox.Show("總金額：NT$" + total + "\n" + "折扣後金額：NT$" + total * 0.9);
            }
            else
            {
                MessageBox.Show("尚未點餐！");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            count = 0;
            total= 0;
            BeerCount = 0;
            Beertotal = 0;
            Tequilacount = 0;
            Tequilatotal = 0;
            Whiskycount = 0;
            Whiskytotal = 0;
            Winecount = 0;
            Winetotal = 0;
            StrAll[0] = StrAll[1] = StrAll[2] = StrAll[3] = "";
            labListAll.Text = "";
            labText.Text = "NT$ 0";
            labListAll.Text = "尚未點餐";
        }

        
        void into()
        {
            total = Whiskytotal + Tequilatotal + Beertotal + Winetotal;
            labText.Text = "NT$"+Convert.ToString(total);
            labListAll.Text = StrAll[0] + StrAll[1]  + StrAll[2]  + StrAll[3];
  
        }


    }
}
