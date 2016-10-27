using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Triangle;
using Triangle = Triangle.Triangle;

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Side a=new Side(new Triangle.Point(1,1), new Triangle.Point(1, 2));
            Side b = new Side(new Triangle.Point(1, 5), new Triangle.Point(1, 6));
            Side c = new Side(new Triangle.Point(1, 6), new Triangle.Point(1, 8));
            try
            {
                Triangle ;
                label.Content += Convert.ToString(triangle.Square());
                label.Content += triangle.Square().ToString();
            }
            catch (InvalidTriangleException)
            {
                label.Content = "exception";
            }

        }
    }
}
