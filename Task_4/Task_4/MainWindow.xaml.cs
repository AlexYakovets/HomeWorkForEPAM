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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class ShowTriangleWindow : Window
    {
        public ShowTriangleWindow()
        {
           InitializedComponent();
        }

        private void InitializedComponent()
        {
            
                // Новая форма
                this.Width = this.Height = 300;
                this.Left = this.Top = 100;
                this.Title = "Triangle";

                // Переходим к компоновке
                DockPanel panel = new DockPanel();
                Line myLine = new Line();
                myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
                myLine.X1 = 1;
                myLine.X2 = 50;
                myLine.Y1 = 1;
                myLine.Y2 = 50;
                myLine.HorizontalAlignment = HorizontalAlignment.Left;
                myLine.VerticalAlignment = VerticalAlignment.Center;
                myLine.StrokeThickness = 2;
                IAddChild container = panel;

                container.AddChild(myLine);

                container = this;
                container.AddChild(panel);
          

        }

       
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Side a=new Side(new Figures.Point(1,1), new Figures.Point(1, 2));
            Side b = new Side(new Figures.Point(1, 5), new Figures.Point(1, 6));
            Side c = new Side(new Figures.Point(1, 6), new Figures.Point(1, 8));
            CreateTriangle CreatorOfTriangles=new CreateTriangle();
            Figures.Figure triangle = CreatorOfTriangles.Create(a, b, c);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ShowTriangleWindow showTr=new ShowTriangleWindow();
            showTr.Show();
        }
    }
}
