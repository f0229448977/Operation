using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace Operation
{
    
    public partial class Operation04 : Form
    {
        public Operation04()
        {
            InitializeComponent();
        }
        String  ScoreResult, MaxResult,MinResult;
        StudentScore Score ;
        private void button1_Click(object sender, EventArgs e)
        {

            bool isNum = int.TryParse(txtChinese.Text, out Score.ChineseScore);
            bool isENNum = int.TryParse(txtEnglish.Text, out Score.EnglishScore);
            bool isMANum = int.TryParse(txtMath.Text, out Score.MathScore);
            if (isNum == true & isENNum == true & isMANum == true) 
            {
                Score.Name = txtName.Text;
                Score.ChineseScore = int.Parse(txtChinese.Text);
                Score.EnglishScore = int.Parse(txtEnglish.Text);
                Score.MathScore = int.Parse(txtMath.Text);
                ScoreResult = "姓名：" + Score.Name + " \n" +
                              "國文：" + Score.ChineseScore + " 分\n" +
                              "英文：" + Score.EnglishScore + " 分\n" +
                              "數學：" + Score.MathScore + " 分\n";
            }
            else
            {
                MessageBox.Show("好好打字好嗎？");
                txtChinese.Clear();
                txtEnglish.Clear();
                txtMath.Clear();
                txtChinese.Focus();

            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labShow.Text = ScoreResult;
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            
            List <int> MaxSubject = new List<int> { Score.ChineseScore, Score.EnglishScore, Score.MathScore };
            int MaxScore = MaxSubject.Max();
            if (Score.ChineseScore == MaxScore)
            {
                MaxResult = "最高科目成績為：國文 " + MaxScore + " 分\n";
            }
            else if (Score.EnglishScore == MaxScore)
            {
                MaxResult = "最高科目成績為：英文 " + MaxScore + " 分\n";
            }
            else
            {
                MaxResult = "最高科目成績為：數學 " + MaxScore + " 分\n";
            }

            List<int> MinSubject = new List<int> { Score.ChineseScore, Score.EnglishScore, Score.MathScore };
            int MinScore = MinSubject.Min();
            if (Score.ChineseScore == MinScore)
            {
                MinResult = "最低科目成績為：國文 " + MinScore + " 分\n";
            }
            else if (Score.EnglishScore == MinScore)
            {
                MinResult = "最低科目成績為：英文 " + MinScore + " 分\n";
            }
            else
            {
                MinResult = "最低科目成績為：數學 " + MinScore + " 分\n";
            }

            labMinMax.Text = MaxResult+MinResult;

        }
    }
}
