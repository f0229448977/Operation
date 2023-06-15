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
    public partial class Operation08 : Form
    {
        public Operation08()
        {
            InitializeComponent();
        }


        int x, y;
        private void btnColor_Click(object sender, EventArgs e)
        {
            var ColorDialog = new ColorDialog();
        }

        private void Operation08_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
