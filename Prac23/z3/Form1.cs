using static System.Math;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = Convert.ToDouble(textBoxX0.Text);
                double xk = Convert.ToDouble(textBoxXk.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                double a = Convert.ToDouble(textBoxA.Text);

                for (double x = x0; x <= xk; x += dx)
                {
                    double y = Pow(x, 4) + Cos(2 + Pow(x, 3) - a);
                    textBoxResult.Text += $"x: {x:.###}; y: {y:.###}" + Environment.NewLine;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show(
                "Одно из полей является пустым. Или же не соответсвует формату.",
                "Ошибка",
                MessageBoxButtons.OK);
            }
        }
    }
}