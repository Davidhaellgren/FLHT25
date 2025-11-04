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

namespace FL1;

public partial class MainWindow : Window{
    public MainWindow() {
        InitializeComponent();
    }
    private void btnRed_Click(object sender, RoutedEventArgs e){
        frameChangeColor.Background = Brushes.Red;

        // Variable
        // Datatypen    Namnet och eventuellt vilket värden den ska ha

        // Vi deklarerar en varieble och tilldelar värde
        double widthAndHeight = 300;

        frameChangeColor.Width = widthAndHeight;
        frameChangeColor.Height = widthAndHeight;
    }
    private void btnBlue_Click(object sender, RoutedEventArgs e){
        frameChangeColor.Background = Brushes.Blue;
    }
    private void btnGreen_Click(object sender, RoutedEventArgs e){
        frameChangeColor.Background = Brushes.Green;
    }

    private void btnOrange_Click(object sender, RoutedEventArgs e){
        frameChangeColor.Background = Brushes.Orange;
    }
}