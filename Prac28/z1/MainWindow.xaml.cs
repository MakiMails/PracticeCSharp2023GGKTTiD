using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
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
    }
}
