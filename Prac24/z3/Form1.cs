using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black, 2);
            g.DrawLine(p, 100, 100, 200, 100);
            g.DrawLine(p, 200, 100, 300,50);
            g.DrawLine(p, 300,50, 500, 50);
            g.DrawLine(p, 500, 50, 600, 100);
            g.DrawLine(p, 600, 100, 800, 100);
            g.DrawLine(p, 800, 100, 800, 190);
            g.DrawLine(p, 800, 190, 100, 190);
            g.DrawLine(p, 100, 190, 100,100);
            g.DrawEllipse(p, 150, 150, 100, 100);
            g.DrawEllipse(p, 650, 150, 100, 100);


        }
    }
}
