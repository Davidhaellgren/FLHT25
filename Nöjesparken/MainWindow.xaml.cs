using System.Runtime.CompilerServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace Nöjesparken
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

        private bool CheckLengthUnder140(int length)
        {
            int minimumLength = 140;

            if (length < minimumLength)
            {
                return false;
            }
            else
            {
                return true;
            }     
        }

        private string MultipleRides(int length, bool adultCompany)
        {
 
            string[] rides = new string[5];
            int count = 0;

            // Vi lägger in varje karusell i arrayen och räknar hur många det blir baserat på längt och om det finns en vuxen
            if (length >= 89 || adultCompany)
            {
                rides[count] = "Småbarnens karusell";
                count++;
            }
            if (length >= 90 || adultCompany)
            {
                rides[count] = "Snurrande tekoppar";
                count++;
            }
            if (length >= 110 || adultCompany)
            {
                rides[count] = "Flygande elefanter";
                count++;
            }
            if (length >= 130)
            {
                rides[count] = "Lilla berg-och-dalbanan";
                count++;
            }
            if (length >= 140)
            {
                rides[count] = "Stora berg-och-dalbanan";
                count++;
            }
            // skickar in arrayen och count till en metod som avgränsar med ", " och " och "
            string text = Delimeter(rides, count);

            if (text == "")
            {
                text = "ingen berg-och dalbana då du är för kort";
            }
            return text;

        }

        private string Delimeter(string[] myString, int words)
        {
            string text = "";

            for (int i = 0; i < words; i++)
            {
                if (i == 0)                         // Första varvet vägger vi endast in första ordet
                {
                    text += myString[i];
                }
                else if (i == words - 1)            // Om det är sista ordet avslutar med "och" och arrayens ord
                {
                    text += " och " + myString[i];
                }
                else                                // Om det är är i mitten av arrayen används ", "
                {
                    text += ", " + myString[i];
                }
            }

            return text;
        }

        private int CountKidsCanRide(int[] Lengths)
        {
            int kidsCanRide = 0;

            foreach (int Length in Lengths)
            {
                if (Length >= 130 && Length <= 139)
                {
                    {
                        kidsCanRide++;
                    }
                }
            }
            return kidsCanRide;

        }

        private void btnCtrlHeight_Click(object sender, RoutedEventArgs e)
        {
            int kidLength = int.Parse(txtHeight.Text);
            bool canRide = CheckLengthUnder140(kidLength);

            if (canRide)
            {
                MessageBox.Show("Du är tillräckligt lång för att åka!");
            }
            else
            {
                MessageBox.Show("Tyvärr, du är inte tillräckligt lång för att åka.");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int kidLength2 = int.Parse(txtLength2.Text);
            bool adultCompany = (bool)chkVuxen.IsChecked;
            string rides = MultipleRides(kidLength2, adultCompany);

            MessageBox.Show($"Du får åka: {rides}.");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[] lengths = {
            186, 147, 175, 94, 171, 132, 145, 198, 104, 197,
            157, 198, 92, 129, 175, 124, 94, 185, 89, 106,
            135, 197, 103, 68, 136, 130, 197, 143, 102, 112,
            116, 175, 169, 140, 189, 194, 172, 182, 112, 163,
            164, 178, 168, 190, 143, 154, 168, 181, 157, 84,
            203, 188, 105, 175, 155, 140, 174, 203, 139, 106,
            173, 177, 195, 136, 166, 202, 161, 95, 181, 198,
            100, 141, 182, 97, 100, 191, 68, 101, 160, 93,
            146, 178, 74, 172, 184, 173, 138, 96, 144, 91,
            139, 104, 106, 142, 100, 179, 159, 160, 128, 121
            };

            int kidsCanRide = CountKidsCanRide(lengths);

            MessageBox.Show($"{kidsCanRide} personer får åka berg-och dalbanan");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int money = int.Parse(txtMoney.Text);


            int ticketPrice = 25;
            int ticketBoundlePrice = 200;
            int ticketBoundle = 10;
            int ticketCount = 0;

            while (money >= ticketBoundlePrice)
            {
                money -= ticketBoundlePrice;
                ticketCount += ticketBoundle;
            }
            while (money > ticketPrice)
            {
                money -= ticketPrice;
                ticketCount++;
            }
            
            MessageBox.Show($"Du fick {ticketCount} biljetter och du får {money} kr tillbaka");
        }
    }
}