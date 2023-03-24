using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxStrNums.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Результат: ";
            string str = (string)listBoxStrNums.Items[listBoxStrNums.SelectedIndex];
            string[] elems = str.Split(' ');
            foreach(string elem in elems)
            {
                if (IsEven(Convert.ToInt32(elem)))
                {
                    labelResult.Text += elem + " ";
                }
            }
        }

        private bool IsEven(int num) => num % 2 == 0;
    }
}
