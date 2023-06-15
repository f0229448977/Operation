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
    public partial class Operation07 : Form
    {
        public Operation07()
        {
            InitializeComponent();
        }

        
        int XSpeed = 5;
        int YSpeed = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += XSpeed;
            pictureBox1.Top += YSpeed;

            if (pictureBox1.Left <= 0 || pictureBox1.Right >= ClientSize.Width)
            {
                XSpeed = -XSpeed;
            }
            if(pictureBox1.Top <= 0 || pictureBox1.Bottom >= ClientSize.Height)
            {
                YSpeed = -YSpeed;
            }
        }

        public Point Movelocation;  //取得移動的距離
        private void Operation07_MouseMove(object sender, MouseEventArgs e)
        {

            int distance = Math.Abs(Cursor.Position.X - Movelocation.X)
                        + Math.Abs(Cursor.Position.Y - Movelocation.Y);
            if (distance >= 900)
            {
                Close();
            }
        }

        private void Operation07_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void Operation07_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }
    }
}
