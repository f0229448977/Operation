using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void frmCall(Form frm)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            //非最上層
            frm.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm.Visible = true;

            //設定From位置
            frm.Top = 0;
            frm.Left = 0;
            frm.Size = new Size(392, 595);

            splitContainer2.Panel2.Controls.Add(frm);
        }
        

        private void btnOpenOpratin1_Click(object sender, EventArgs e)
        {

            Operation01 OP01 = new Operation01();
            frmCall(OP01);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Operation02 OP02 = new Operation02();
          
            frmCall(OP02);
        }

        private void btnOpenOpratin3_Click(object sender, EventArgs e)
        {
            Operation03 OP03 = new Operation03();
            
            frmCall(OP03);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation04 OP04 = new Operation04();
            frmCall(OP04);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation05 OP05 = new Operation05();
            frmCall(OP05);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation06 OP06 = new Operation06();
            frmCall(OP06);
        }

            private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
           
        }

        private void btnOpenOpration7_Click(object sender, EventArgs e)
        {
            Operation07 OP07 = new Operation07();
            OP07.Show();
        }

        private void btnOpenOpration9_Click(object sender, EventArgs e)
        {
            Operation08 OP09 = new Operation08();
            frmCall(OP09);
        }
    }
    }

