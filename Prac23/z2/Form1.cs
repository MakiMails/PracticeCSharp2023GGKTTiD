using static System.Math;

namespace z2
{
    public partial class Form1 : Form
    {
        private delegate double FuncX(double x);
        private FuncX _funcX;

        public Form1()
        {
            InitializeComponent();
            _funcX = DefineFunction();
        }

        private void buttonFunc_Click(object sender, EventArgs e)
        {

            try
            {
                double x = Convert.ToDouble(textBoxNumX.Text);
                int maxI = Convert.ToInt32(textBoxNumI.Text);

                Calculate(maxI, x, _funcX);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                "Одно из полей является пустым. Или же не соответсвует формату.",
                "Ошибка",
                MessageBoxButtons.OK);
            }
        }

        private void radioButtonFunc_Click(object sender, EventArgs e)
        {
            _funcX = DefineFunction();
        }

        private FuncX DefineFunction()
        {
            FuncX funcX;
            if (radioButtonShX.Checked)
            {
                funcX = Sinh;
            }
            else if (radioButtonSquareX.Checked)
            {
                funcX = Squaring;
            }
            else
            {
                funcX = Exp;
            }
            return funcX;
        }

        private double Squaring(double x) => Pow(x, 2);

        private void Calculate(int maxI, double x, FuncX funcX)
        {
            textBoxResult.Clear();
            for (int i = 0; i <= maxI; i++)
            {
                double e;
                if (!IsEven(i) && funcX(x) > 0)
                {
                    e = i * Sqrt(funcX(x));
                }
                else if (IsEven(i) && funcX(x) < 0)
                {
                    e = i / (2 * Sqrt(Abs(funcX(x))));
                }
                else
                {
                    e = Sqrt(Abs(i * funcX(x)));
                }
                WriteResultInTextBox(i, funcX(x), e);
            }
        }

        private bool IsEven(int i) => i % 2 == 0;

        private void WriteResultInTextBox(int i,double x, double result)
        {
            textBoxResult.Text += $"i: {i} funcX(x):" +
                $" {x:.###} result: {result:.###}" + Environment.NewLine;
        }



    }
}