using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace z4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            Button bt = new Button();
            bt.Width = 100;
            bt.Height = 20;
            Random r = new Random();
            bt.Margin = new Thickness(r.Next(0,1000), r.Next(0, 1000),0,0);
            bt.PreviewMouseMove += Button_PreviewMouseMove;
            bt.Click += Button_Click;
            c.Children.Add(bt);
            
        }

        private void   Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            c.Children.Remove(bt);
        }
    }
}
