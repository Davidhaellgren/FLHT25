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

namespace FL9
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

        private bool canRideOnNextRound(int passangersInQue)
        {
            //if (passangersInQue > 47)
            //    return false;
            //else
            //    return true;
            bool canRide;
            int numberOfWaggons = 24, seatsPerWaggon = 2;
            canRide = passangersInQue <= numberOfWaggons * seatsPerWaggon;
            return canRide;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int nrOfPassenger = 12;
            double balanceWeight = nrOfPassenger % 2;
            // modulus kan du använda för att ta redo på om något
            // tal är jämt delbart, eller om du vill veta decimalerna

            if (nrOfPassenger % 2 == 0)
            {
                MessageBox.Show("det är jämt");
            }
            else
            {
                MessageBox.Show("Det är inte jämt");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int passangersInQue = 40;
            bool canRideNow;
            canRideNow = canRideOnNextRound(passangersInQue);


        }
    }
}