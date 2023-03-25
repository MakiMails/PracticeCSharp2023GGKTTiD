using System;
using System.Windows.Forms;

namespace z3_WinTimer1_ControlLibrary
{
    public partial class UserControlTimer : UserControl
    {
        public bool TimeEnabled
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }

        public UserControlTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
