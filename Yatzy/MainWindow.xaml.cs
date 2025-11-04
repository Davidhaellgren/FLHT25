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
                                                                                                // Gör om variable "Text" till int (nummer) och sparar i "SummaEtt"
            int summaTvå = int.Parse(txtBoxTvå.Text);
            
            int summaTre = int.Parse(txtBoxTre.Text);
            
            int summaFyra = int.Parse(txtBoxFyra.Text);
            
            int summaFem = int.Parse(txtBoxFem.Text);
            
            int summaSex = int.Parse(txtBoxSex.Text);
            
            int points = summaEtt + summaTvå + summaTre + summaFyra + summaFem + summaSex;      // Summerar och lägger värdet i "points"

            if (points >= 63){                                                                  // Om värdet i points är större eller lika med 63
                //string message = $"Du fick {points} och får därför YATZY bonus!";
                //MessageBox.Show(message);
                txtSum.Text = $"Du fick {points} och får därför YATZY bonus!";                  // Anropar "txtSum" som är ett TextBlock och lägger in angiven text i "Text"
            }
            else{                                                                               // Allt annat
                 //string message = $"Du fick {points} och får därför inte YATZY bonus";         
                 //MessageBox.Show(message);                                                     
                 txtSum.Text = $"Du fick {points} och får därför inte YATZY bonus";             // Anropar "txtSum" som är ett TextBlock och lägger in angiven text i "Text"
            }
        }
    }
}