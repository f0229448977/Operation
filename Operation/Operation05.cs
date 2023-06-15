using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Operation
{
    public partial class Operation05 : Form
    {
        public Operation05()
        {
            InitializeComponent();
        }
        StudentScore Score;
        List<StudentScore> lsStudentScore = new List<StudentScore>();
        string MaxResult, MinResult;
        int  ScoreMin, ScoreMax;

        void MinMax()
        {
           
            ScoreMax = (Math.Max(Score.MathScore, (Math.Max(Score.ChineseScore, Score.EnglishScore))));
            if (ScoreMax == Score.ChineseScore)
            {
                MaxResult = "國文" + ScoreMax;
            }
            else if (ScoreMax == Score.EnglishScore)
            {
                MaxResult = "英文" + ScoreMax;
            }
            else
            {
                MaxResult = "數學" + ScoreMax;
            }

            ScoreMin = (Math.Min(Score.MathScore, (Math.Min(Score.ChineseScore, Score.EnglishScore))));
            if (Score.ChineseScore == ScoreMin)
            {
                MinResult = "國文" + ScoreMin;
            }
            else if (Score.EnglishScore == ScoreMin)
            {
                MinResult = "英文" + ScoreMin;
            }
            else
            {
                MinResult = "數學" + ScoreMin;
            }
        }

        void Method()
        {
            string result = "";
            

            for (int i = 0; i < lsStudentScore.Count; i++)//集合中的數量是使用Count(陣列是使用Lengh)
            {
                result += $"{(lsStudentScore[i].Name),-5}"+
                    $"{(lsStudentScore[i].ChineseScore),6}"+
                    $"{(lsStudentScore[i].EnglishScore),6}"+
                    $"{(lsStudentScore[i].MathScore),6}" +
                    $"{(lsStudentScore[i].Sum),7}"+
                    $"{(lsStudentScore[i].Adv),7}"+
                    $"{(lsStudentScore[i].Min),6}"+
                    $"{(lsStudentScore[i].Max),6}\n";
            }
            
            labAll.Text = result;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            labAll.Text = "";
            labAll02.Text = "";
            txtChinese.Clear();
            txtEnglish.Clear();
            txtMath.Clear();
            txtName.Clear();
            lsStudentScore.Clear();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
        bool isCNScore = int.TryParse(txtChinese.Text, out Score.ChineseScore);
        bool isENScore = int.TryParse(txtEnglish.Text, out Score.EnglishScore);
        bool isMAScore = int.TryParse(txtMath.Text, out Score.MathScore);
            
            Score.Name = txtName.Text;
            if (txtName.Text != "" && isCNScore == true && isENScore == true && isMAScore == true)
            {

                Score.ChineseScore = int.Parse(txtChinese.Text);
                Score.EnglishScore = int.Parse(txtEnglish.Text);
                Score.MathScore = int.Parse(txtMath.Text);
                Score.Sum = Score.ChineseScore + Score.EnglishScore + Score.MathScore;
                Score.Adv  = (Math.Round(Convert.ToDouble(Score.ChineseScore + Score.EnglishScore + Score.MathScore)/ 3,1));
                MinMax();
                Score.Min = MinResult;
                Score.Max = MaxResult;
                lsStudentScore.Add(Score);
                Method();          
            }

            else if (txtName.Text == "")
            {
                MessageBox.Show(" 請輸入姓名 ", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtChinese.Text == "" )
            {
                MessageBox.Show(Score.Name + " 請輸入國文成績！ ", "輸入錯誤",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChinese.Focus();
            }
            else if (txtEnglish.Text == ""  )
            {
                MessageBox.Show(Score.Name + " 請輸入英文成績！ ", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnglish.Focus();
            }
            else if (txtMath.Text == "")
            {
                MessageBox.Show(Score.Name + " 請輸入數學成績！ ", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMath.Focus();
            }
            else
            {
                MessageBox.Show(Score.Name + "  好好打字好嗎？", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChinese.Clear();
                txtEnglish.Clear();
                txtMath.Clear();
                txtChinese.Focus();
            }
            
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            Score.Name = (lsStudentScore.Count() + 1).ToString();
            Score.ChineseScore = rand.Next(0, 101);
            Score.EnglishScore = rand.Next(0, 101);
            Score.MathScore = rand.Next(0, 101);
            Score.Sum = Score.ChineseScore + Score.EnglishScore + Score.MathScore;
            Score.Adv = (Math.Round(Convert.ToDouble(Score.ChineseScore + Score.EnglishScore + Score.MathScore) / 3,1));
            MinMax();
            Score.Min = MinResult;
            Score.Max = MaxResult;
            lsStudentScore.Add(Score);
            Method();
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 21; i++)
            {
                Score.Name = (lsStudentScore.Count() + 1).ToString();
                Score.ChineseScore = rand.Next(0, 101);
                Score.EnglishScore = rand.Next(0, 101);
                Score.MathScore = rand.Next(0, 101);
                Score.Sum = Score.ChineseScore + Score.EnglishScore + Score.MathScore;
                Score.Adv = (Math.Round(Convert.ToDouble(Score.ChineseScore + Score.EnglishScore + Score.MathScore) / 3,1));
                MinMax();
                Score.Min = MinResult;
                Score.Max = MaxResult;
                lsStudentScore.Add(Score);
                Method();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string result = "";
             
            if (lsStudentScore.Count > 0)
            {
                int totalChScore = lsStudentScore.Sum(x => x.ChineseScore);
                int totalEnScore = lsStudentScore.Sum(x => x.EnglishScore);
                int totalMathScore = lsStudentScore.Sum(x => x.MathScore);
                int MinCHscore = lsStudentScore.Min(x => x.ChineseScore);
                int MinEHscore = lsStudentScore.Min(x => x.EnglishScore);
                int MinMAscore = lsStudentScore.Min(x => x.MathScore);
                int MaxCHscore = lsStudentScore.Max(x => x.ChineseScore);
                int MaxEHscore = lsStudentScore.Max(x => x.EnglishScore);
                int MaxMAscore = lsStudentScore.Max(x => x.MathScore);
                double ChScoreADV = (Math.Round(Convert.ToDouble(totalChScore / lsStudentScore.Count) / 3, 1));
                double EnScoreADV = (Math.Round(Convert.ToDouble(totalEnScore / lsStudentScore.Count) / 3, 1));
                double MaScoreADV = (Math.Round(Convert.ToDouble(totalMathScore / lsStudentScore.Count) / 3, 1));


                result += $"總分  : {totalChScore,5}{totalEnScore,5}{totalMathScore,5}\n" +
                    $"平均  : {ChScoreADV,5}{EnScoreADV,5}{MaScoreADV,5}\n" +
                    $"最高分: {MaxCHscore,5}{MaxEHscore,5}{MaxMAscore,5}\n" +
                    $"最低分: {MinCHscore,5}{MinEHscore,5}{MinMAscore,5}\n";
            }
            else
            {
                MessageBox.Show("尚未輸入", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            labAll02.Text = result;
        }

    }
}
