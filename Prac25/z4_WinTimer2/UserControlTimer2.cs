using System;
using System.Drawing;
using System.Windows.Forms;

namespace z4_WinTimer2
{
    public partial class UserControlTimer2 : UserControl
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width,
            this.Height);
            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(),
                this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }
    }
}
