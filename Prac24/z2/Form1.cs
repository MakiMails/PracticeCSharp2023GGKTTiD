using System;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                double minX = Convert.ToDouble(textBoxMinX.Text);
                double maxX = Convert.ToDouble(textBoxMaxX.Text);
                double h = Convert.ToDouble(textBoxH.Text);

                int countPoint = (int)Math.Ceiling((maxX - minX) / h) + 1;

                double[] x = new double[countPoint];
                double[] y = new double[countPoint];
                
                for(int i = 0; i < countPoint; i++)
                {
                    x[i] = minX + h * i;
                    y[i] = 1 / Math.Tan(x[i]);
                }

                chartMain.ChartAreas[0].AxisX.Minimum = minX;
                chartMain.ChartAreas[0].AxisX.Maximum = maxX;

                chartMain.ChartAreas[0].AxisX.MajorGrid.Interval = h;

                chartMain.Series[0].Points.DataBindXY(x, y);
                
            
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Не пракильный формат поля.",
                    "Ошибка",
                    MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
