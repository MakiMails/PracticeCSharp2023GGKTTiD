using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSayName_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxName.Text.Length != 0)
            {
                labelGreeting.Content = $"Hello, {textBoxName.Text}";
            }
            else
            {
                MessageBox.Show(
                    "Введите имя.",
                    "Пустое значение",
                    MessageBoxButton.OK);
            }
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonReference_Click(object sender, RoutedEventArgs e)
        {
            ReferenceView rw = new ReferenceView();
            rw.Show();
        }
    }
}
