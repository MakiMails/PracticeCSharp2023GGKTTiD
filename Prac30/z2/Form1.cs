using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {

        Graphics g;
        Bitmap baner;
        Rectangle rct;

        public Form1()
        {
            InitializeComponent();
            try
            {
                baner = new Bitmap(@"D:\PracticCSharp\Prac30\z2\Bitmap\banner.png");
            }
            catch(Exception e)
            {
                MessageBox.Show($"Ошибка загрузки файла баннера\n {e}", "Баннер");
                this.Close();
                return;
            }
            rct.X = 0;
            rct.Y = 0;
            rct.Width = baner.Width;
            rct.Height = baner.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1;
            if(Math.Abs(rct.X) > rct.Width)
            {
                rct.X += rct.Width;
            }
            for(int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                //Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.
                //Choto ne tak?
                //I kod copnul iz zadania a on ne rabotaet
                g.DrawImage(baner, Convert.ToInt32(rct.X + i * rct.Width), Convert.ToInt32(rct.Y));
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                if (timer1.Enabled != false)
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                if (timer1.Enabled != true)
                {
                    timer1.Enabled = true;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }
    }
}
