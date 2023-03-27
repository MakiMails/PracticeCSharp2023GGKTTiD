using System.Windows;
using z1.ViewModels;

namespace z1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowsViewModel();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddAuto addAuto = new(this);
            addAuto.Show();
            IsEnabled = false;
        }
    }
}
