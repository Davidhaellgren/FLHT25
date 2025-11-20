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

namespace FL11
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

        double _totalPrice = 0;
        int _items = 0;

        private double DiscountNrOfItems()
        {
            double discount = 0;

            if (_items >= 5 && _items <= 10)
            {
                discount = _totalPrice * 0.1;
            }
            else if (_items >= 20)
            {
                discount = _totalPrice * 0.2;
            }

            return discount;
        }

        private double DiscountTotalValue()
        {
            double discount = 0;

            if (_totalPrice > 500 && _totalPrice < 1000)
            {
                discount = _totalPrice * 0.05;
            }
            else if (_totalPrice >= 1000 && _totalPrice < 2000)
            {
                discount = _totalPrice * 0.1;
            }
            else if (_totalPrice >= 2000)
            {
                discount = _totalPrice * 0.2;
            }

            return discount;
        }


        private void btnValue_Click(object sender, RoutedEventArgs e)
        {
            // hämta summanfrån gränssnittet

            double discount = 0;

            double price = double.Parse(txtPrice.Text);
            _totalPrice += price;
           
            // ökarantal varoi
            _items++;

            // vi ska re rabatt
            // 500 kr -> 5%
            // 1000 kr -> 10%
            // 2000 kr -> 20%

            // under 5 varor ingen rabbat
            // mellan 5 och 10 varor -> 10%
            // över 10 varor -> 20%

            discount = DiscountNrOfItems();
            discount += DiscountTotalValue();

            _totalPrice -= discount;

            txtTotal.Text = _totalPrice.ToString();
        
        }
    }
}