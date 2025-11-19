using Microsoft.VisualBasic.FileIO;
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

namespace FL10
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
            int[] numbers = { 1, 23, 232, 2, 10 };

            int searchValue = 1;

            if (ContainsValue(numbers, searchValue))
            {
                MessageBox.Show("Ja, talet finns i listan");
            }
            else
            {
                MessageBox.Show("Nej, talet finns inte i listan");
            }
            string text = "Hej jag heter David och han gillar inte C#";
            bool result = ContainsValue(text, 'd');
        }

        private bool ContainsValue(string sentence, char search)
        {
            // casesensitivt
            foreach (letter in sentence)
            { 
                if (char.ToUpper(letter) == search)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsValue(int[] values, int search)
        {
            foreach (int value in values)
            {
                if (value == search)
                {
                    return true;
                }
            }
            return false;
        } 
    }
}