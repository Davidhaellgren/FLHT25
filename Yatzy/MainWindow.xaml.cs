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
           int summaEtt = 0, summaTvå = 0, summaTre = 0, summaFyra = 0, summaFem = 0, summaSex = 0;
           string err = "";                                                                    //Skapar string "err" utan värde för att ge den värde om scrips ska avslutas
           if (int.Parse(txtBoxEtt.Text) >= 1 && int.Parse(txtBoxEtt.Text) <= 5) {
                summaEtt = int.Parse(txtBoxEtt.Text) * 1;
                string totalEtt = summaEtt.ToString();
                txtBlockTotalEtt.Text = totalEtt;
           }
           else {
                txtBlockTotalEtt.Text = "Du kasta för få/många tärningar";
                err = "err";
           }
           if (int.Parse(txtBoxTvå.Text) >= 1 && int.Parse(txtBoxTvå.Text) <= 5) {
                summaTvå = int.Parse(txtBoxTvå.Text) * 2;
                string totalTvå = summaTvå.ToString();
                txtBlockTotalTvå.Text = totalTvå;
           }
           else {
                txtBlockTotalTvå.Text = "Du kasta för få/många tärningar";
                err = "err";
           }
           if (int.Parse(txtBoxTre.Text) >= 1 && int.Parse(txtBoxTre.Text) <= 5) {
                summaTre = int.Parse(txtBoxTre.Text) * 3;
                string totalTre = summaTre.ToString();
                txtBlockTotalTre.Text = totalTre;
           }
           else {
                txtBlockTotalTre.Text = "Du kasta för få/många tärningar";
                err = "err";
           }
           if (int.Parse(txtBoxFyra.Text) >=1 && int.Parse(txtBoxFyra.Text) <= 5) {
                summaFyra = int.Parse(txtBoxFyra.Text) * 4;
                string totalFyra = summaFyra.ToString();
                txtBlockTotalFyra.Text = totalFyra;
           }
           else {
                txtBlockTotalFyra.Text = "Du kasta för få/många tärningar";
                err = "err";
           }
           if (int.Parse(txtBoxFem.Text) >= 1 && int.Parse(txtBoxFem.Text) <= 5) {
                summaFem = int.Parse(txtBoxFem.Text) * 5;
                string totalFem = summaFem.ToString();
                txtBlockTotalFem.Text = totalFem;
           }
           else {
                txtBlockTotalFem.Text = "Du kasta för få/många tärningar";
                err = "err";
           }
           if (int.Parse(txtBoxSex.Text) >= 1 && int.Parse(txtBoxSex.Text) <= 5) {
                summaSex = int.Parse(txtBoxSex.Text) * 6;
                string totalSex = summaSex.ToString();
                txtBlockTotalSex.Text = totalSex;
           }
           else {
                txtBlockTotalSex.Text = "Du kasta för få/många tärningar";
                err = "err";
           }
           if (err == "err") {                                                                 // Om err har värde "err" avbryter script
                txtBlockSum.Text = "";                                                         // Nollställer variable om man gör fel
                return;                                                                        // Avbryter sent för att alla fel ska pressenteras
           }
           int summa = summaEtt + summaTvå + summaTre + summaFyra + summaFem + summaSex;       // Summerar och lägger värdet i "points"

           if (summa >= 63){                                                                   // Om värdet i points är större eller lika med 63
                summa += 50;                                                                   // lägger till 50 "+="
                txtBlockSum.Text = $"dina totala poäng är {summa} poäng med YAZTY BONUS!";     // Anropar "txtSum" som är ett TextBlock och lägger in angiven text i "Text"
           }
           else{                                                                               // Allt annat                                                    
                txtBlockSum.Text = $"Du fick bara {summa} poäng och bör inte spela YATZY mer";  // Anropar "txtSum" som är ett TextBlock och lägger in angiven text i "Text"
           }
        }

        private void btnTestSum_Click(object sender, RoutedEventArgs e)
        {
            int twos = 0;
            twos = int.Parse(txtBoxTvå.Text);
            int numberOfDices = 5, maxValue;
            maxValue = 2 * numberOfDices;
            // Kontrollera värdet. Är det rimligt?
            //Fem tärningar
            // Alla ettor är intressantra. Alla andra är ointressanta

            if (twos > maxValue || twos < maxValue)
            {
                txtBlockSum.Foreground = Brushes.Red;
                txtBlockSum.FontSize = 30;
                txtBlockSum.Text = "Du gjorde fel!";
            }
        }
    }
} //Finns det någon fördel att skriva if satser och rikta mot sant eller falskt?