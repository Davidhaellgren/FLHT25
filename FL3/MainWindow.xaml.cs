using System.Numerics;
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

namespace FL3
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

        private void btbCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Vi vill summera alla värden på yatzy
            // övre halvan,1, ,2 ,3 ,4, ,5 och sex
            // Vad är det vi behöver för att kunna beräkna summan?
            // Användaren matar in heltal 1 -> 6
            // Summan av flera heltal blir alltid ett heltal

            int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0, total;    // Går att lägga in flera variabler av samma typ (int = nummer)

            // Vi vill hämta värden från användaren, inte hård koda 

            // vi kan inte stoppa in tal i en sträng
            // Låt oss konvertera --> parse
            // Det är en metod. Akka netider gar alltid en parantes
            // ibland ska det stå något inom parantesen
            ones = int.Parse(txtBoxEtt.Text);
            twos = int.Parse(txtBoxEtt.Text);
            threes = 

            total = ones + twos + threes + fours + fives + sixes;
            txtBlockSumma.Text = $"Du fick {total} poäng!";


        }
    }
}