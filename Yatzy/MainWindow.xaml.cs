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

namespace Yatzy
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
        private void btnSummering_Click(object sender, RoutedEventArgs e){
            int summaEtt = int.Parse(txtBoxEtt.Text);
            int summaTvå = int.Parse(txtBoxTvå.Text);
            int summaTre = int.Parse(txtBoxTre.Text);
            int summaFyra = int.Parse(txtBoxFyra.Text);
            int summaFem = int.Parse(txtBoxFem.Text);
            int summaSex = int.Parse(txtBoxSex.Text);

            int points = summaEtt + summaTvå + summaTre + summaFyra + summaFem + summaSex;
            String Sum = points.ToString();
            // string Points =  summaEtt + summaTvå + summaTre + summaFyra + summaFem + summaSex;
            
            MessageBox.Show(Sum);
        }
    }
}