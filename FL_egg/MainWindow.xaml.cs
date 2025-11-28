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

namespace FL_egg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Farm _farm = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _farm.BuyEgg(120);

            // Visa alla ägg här
            List<Egg> fertilesEggs = _farm.GetFertileEgg();
            lstEggs.ItemsSource = null;
            lstEggs.ItemsSource = fertilesEggs;
        }

        private void lstEggs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Egg selectedEgg = (Egg)lstEggs.SelectedItem;

            if (selectedEgg is null)
            {
                return;
            }
            Chicken chicken = _farm.HatchEgg(selectedEgg);
            //MessageBox.Show(selectedEgg.Id.ToString());
            MessageBox.Show($"Kycklingen {chicken.Name} med id {chicken.Id} har fötts");
        }
    }
}