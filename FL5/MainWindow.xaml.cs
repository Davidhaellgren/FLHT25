using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FL5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _speed;                                                              // Global variable för speed
        Random _random = new Random();                                           // Slumpgenerator
        public MainWindow()
        {
            InitializeComponent();                                               // Här kan vi koda för att ändra värden utifrån olika situationer
            int currentMonth = 11;
            if (currentMonth >= 11)
            {
                _speed = 70;
            }
            else
            {
                _speed = 90;
            }
           _speed = _random.Next(20, 90);                                           // _speed är ett slumpat tal mellan 20 - 89
        }

        private void btnIncrease_Click(object sender, RoutedEventArgs e) {
            _speed += 5;                                                            // Ökar hastigheten med 5
        }

        private void btnDecrease_Click(object sender, RoutedEventArgs e) {
            _speed -= 5;                                                            // Minskar hastigheten med 5
        }

        private void btnShow_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(_speed.ToString());                                     // Visar hastigheten
        }
    }
}