using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Operation
{
    public partial class Operation01 : Form
    {
        public Operation01()
        {
            InitializeComponent();
        }
            

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hello,我是：" +txtName.Text + "," + "\n" +
                "英文名字是：" + txtEnglishName.Text + "," + "\n" +
                "性別是：" + txtSex.Text + "," + "\n" +
                "星座是：" + txtSign.Text + "," + "\n"+
                "很高興認識你唷!!!"
                ) ;
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hi,我是：" + txtName.Text + "," + "\n" +
                "英文名字是：" + txtEnglishName.Text + "," + "\n" +
                "性別是：" + txtSex.Text + "," + "\n" +
                "星座是：" + txtSign.Text + "," + "\n"+
                "很高興認識你唷！"
                );
        }
    }
}
