using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            pictureBox();//**
        }
        List<PictureBox> lstPB;
        string folderPath = @"..\..\img\";
        
        public void pictureBox()
            {
                lstPB = new List<PictureBox>();
                string[] imagePath = Directory.GetFiles(folderPath, "*.*");
                foreach (string item in imagePath)
                {
                    PictureBox PB = new PictureBox();
                    PB.Size = new Size(100, 100);
                    PB.SizeMode = PictureBoxSizeMode.Zoom;
                    PB.Image = Image.FromFile(item);
                    flowLayoutPanel1.Controls.Add(PB);
                    PB.MouseClick += PB_MouseClick;
                }
            }
            //開啟單一圖片
            private void PB_MouseClick(object sender, MouseEventArgs e)
            {
                Form singleImgForm = new Form();
                singleImgForm.BackgroundImage = ((PictureBox)sender).Image;
                singleImgForm.BackgroundImageLayout = ImageLayout.Zoom;
                singleImgForm.Show();
            }
        }
    }

