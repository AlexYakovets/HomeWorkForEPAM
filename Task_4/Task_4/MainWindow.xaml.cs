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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Figures;
namespace Task_4
{
    // <summary>
    // Logic for module user window
    // </summary>
    public class ShowTriangleWindow : Window
    {
        public ShowTriangleWindow(Triangle triangle)
        {
            InitializedComponent(triangle);
        }
        private void InitializedComponent(Triangle triangle)
        {

            // Новая форма
            this.Width = this.Height = 300;
            this.Left = this.Top = 100;
            this.Title = "Triangle";

            // Переходим к компоновке
            Grid triangleGrid= new Grid();
            if (triangle.IsExists())
            {
                List<Line> listOfLines = triangle.TriangleToLines();
                foreach (Line line in listOfLines)
                {
                    triangleGrid.Children.Add(line);
                }
                this.AddChild(triangleGrid);
            }
            else this.Title = "Error!!!Triangle with input parametres is ot exists";

        }


    }
    // <summary>
    // Логика взаимодействия для MainWindow.xaml
    // </summary>
    public partial class MainWindow : Window
    {
        public Triangle triangle;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Side a=new Side(new Figures.Point(1,1), new Figures.Point(20, 100));
            Side b = new Side(new Figures.Point(20, 100), new Figures.Point(90, 56));
            Side c = new Side(new Figures.Point(90, 56), new Figures.Point(1, 1));
            CreateTriangle CreatorOfTriangles=new CreateTriangle();
            triangle = (Triangle)CreatorOfTriangles.Create(a, b, c);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ShowTriangleWindow showTr=new ShowTriangleWindow(triangle);
            showTr.Show();
        }

    }
}
