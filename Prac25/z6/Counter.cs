﻿using System;
using System.Windows.Forms;

namespace z6
{
    public partial class Counter : UserControl
    {
        private int _num = 0;

        public int Num
        {
            get => _num;
            set => _num = value;
        }

        public Counter()
        {
            InitializeComponent();
            labelNum.Text = _num.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _num--;
            labelNum.Text = _num.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _num++;
            labelNum.Text = _num.ToString();
        }
    }
}
