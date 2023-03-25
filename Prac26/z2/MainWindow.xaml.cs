using System.Windows;

namespace z2
{
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
