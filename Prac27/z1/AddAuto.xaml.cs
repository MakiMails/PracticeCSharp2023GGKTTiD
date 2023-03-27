using System;
using System.Windows;

namespace z1
{
    public partial class AddAuto : Window
    {
        private Window _mainWin;

        public AddAuto(Window mainWin)
        {
            InitializeComponent();
            _mainWin = mainWin;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _mainWin.IsEnabled = true;
        }
    }
}
