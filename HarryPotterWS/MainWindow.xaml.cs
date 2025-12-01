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

namespace HarryPotterWS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hogwarts hogwarts = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new()
            {
                Name = txtName.Text
            };

            hogwarts.Wizards.Add(wizard);

            Wand wand = new()
            {
                Kernal = "Drakblod",
                Name = "Harrys hemliga stav",
                Wood = "Olivträd",
                Length = wizard.GetNameLength(wizard)
            };

            wizard.Wand = wand;
            wizard.HasWand = true;
            if (hogwarts.IsWandLongEnough())
            {
                MessageBox.Show($"Din wand är bra nog och är {wand.Length} cm lång");
            }
        }
    }
}