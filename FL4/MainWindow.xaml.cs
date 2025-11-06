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

namespace FL4
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Poliskontroll
            int carSpeed = 100, speedLimit = 90;
            // Alla decimaler i koden måste vara punkter!
            double alcoholLevel = 1, alcoholLimit = 0.2, alcohollimit2 = 0.5;
            // rattfylla har en gräns på 0.5

            bool isSober = alcoholLevel < alcoholLimit;
            if (!isSober)
            {
                // Du är inte nykter
            }
            if (isSober)
            {
                // Du ligger under 0.2 promille
            }
            if (carSpeed > speedLimit)
            {
                // Du kör för fort
            }
            if (alcoholLevel >= alcoholLimit)
            {
                // Du är onykter
                if (alcoholLevel >= alcohollimit2)
                {
                    // du är redlös
                }
            }
            else
            {
                // bra du får köra vidare
            }
        }
    }
}