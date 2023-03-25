using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using LiveCharts.Definitions.Series;

namespace z3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            chart.Series = new SeriesCollection { new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(),
            PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                }
            };

            DataContext = this;
        }

        private void buttonCaculate_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                int minX = Convert.ToInt32(textBoxMinX.Text);
                int maxX = Convert.ToInt32(textBoxMaxX.Text);

                if (minX < maxX)
                {
                    ChartValues<ObservablePoint> points = new ChartValues<ObservablePoint>();
                    for (int i = minX; i <= maxX; i++)
                    {
                        if (i != 0)
                        {
                            points.Add(new ObservablePoint(i, 1 / Math.Tan(i)));
                        }
                    }
                    chart.Series = new SeriesCollection { new LineSeries
                    {
                        Values = points,
                        PointGeometrySize = 0,
                        StrokeThickness = 4,
                        Fill = Brushes.Transparent
                    } 
                    };
                }

            }

            catch (FormatException)
            {
                MessageBox.Show(
                    "Неправильные данные введенные в поля",
                    "Неправильный формат",
                    MessageBoxButton.OK);
            }

        }
    }
}
