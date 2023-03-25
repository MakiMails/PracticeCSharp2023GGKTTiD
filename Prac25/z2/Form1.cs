using System;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spData.Text =
                Convert.ToString(DateTime.Today.ToLongDateString());
            spWin.Text = "Windows is cascade";
        }
    }
}
