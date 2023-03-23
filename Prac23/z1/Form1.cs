using System.Text.RegularExpressions;
using static System.Math;


namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonÑalculate_Click(object sender, EventArgs e)
        {
            double numX = GetNumWithStr(textBoxNumX.Text);
            double numY = GetNumWithStr(textBoxNumY.Text);
            double numZ = GetNumWithStr(textBoxNumZ.Text);
            labelResult.Text = "Result: " + Func(numX, numY, numZ).ToString();
        }

        private double GetNumWithStr(string str)
        {
            if (CheckForExponentiation(str))
            {
               return NumInExponentiation(str);
            }
            return Convert.ToDouble(str);
        }

        private bool CheckForExponentiation(string str)
        {
            string pattern = @"[-]{0,1}\d+\*[-]{0,1}\d+\^[-]{0,1}\d*";
            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        private double NumInExponentiation(string num)
        {
            Regex regex = new Regex(@"[-]{0,1}\d+");
            MatchCollection matches = regex.Matches(num);
            if (matches.Count > 3) 
            {
                return Convert.ToDouble(matches[0].Value + ',' + matches[1].Value) *
                 Math.Pow(Convert.ToDouble(matches[2].Value), Convert.ToDouble(matches[3].Value));
            }
            return Convert.ToDouble(matches[0].Value) *
                Math.Pow(Convert.ToDouble(matches[1].Value), Convert.ToDouble(matches[2].Value));
        }

        private double Func(double x, double y, double z) => Log(Pow(y, -1 * Sqrt(Abs(x)))) *
            (x - (y / 2)) + Pow(Sin(Atan(z)), 2);

    }
}