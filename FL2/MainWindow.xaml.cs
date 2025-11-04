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

namespace FL2
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

        private void btnOk_Click(object sender, RoutedEventArgs e){
            //Vi gör en variable
            // Den här variabeln är avdatatypen "string"  som har en text
            // en text är egentigen en sammansättning av olika tecken 
            string name = txtName.Text;

            // En variabel kan byta värde. Ersätts med något nytt
            //name = "David";

            //name = txtName.Text;

            //Mål:
            // Hej <Namnet>, hoppas du mår bra!

            // För att lyckas måste vi göra en stringinterpolation
            string message = $"Hej {name}, hoppas du mår bra!";
            MessageBox.Show(message);
        }
    }
}