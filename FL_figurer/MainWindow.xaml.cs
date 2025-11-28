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

namespace FL_figurer
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
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new(4, 12);



            Triangle triangle = new(length: 3, height: 12);


            // Vi vill ha en lista!!!!!!

            List<Shape> shapes = new();
            shapes.Add(rectangle);
            shapes.Add(triangle);

            double area = 0;

            // Lista = loop är BFF

            foreach (Shape shape in shapes)
            {
                area += shape.GetArea();
            }
        }
    }
}