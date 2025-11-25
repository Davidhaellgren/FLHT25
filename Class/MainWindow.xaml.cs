using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;


namespace Class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Frukt> frukskål = new List<Frukt>();
            
            Apelsin apelsin = new Apelsin
            {
                Färg = "Orange",
                Vikt = 0.25,
                Storlek = 4,

                Smak = "Jättegod!"
            };

            Tomat tomat = new Tomat
            {
                Färg = "Röd",
                Vikt = .75,
                Storlek = 40,
                Smak = "Söt men umami"
            };

            Banan banan = new Banan
            {
                Färg = "Gul",
                Vikt = .50,
                Storlek = .75,
                Smak = "söt"
            };

            frukskål.Add(banan);
            frukskål.Add(tomat);
            frukskål.Add(apelsin);

        }
    }
}