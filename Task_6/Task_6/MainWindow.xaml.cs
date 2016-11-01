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
using Classes;

namespace Task_6
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
            int n;
            n = Convert.ToInt32(textBox.Text);
            ProgramConverter[] array = new ProgramConverter[n];
            for (int i = 0; i < n/2; i++)
            {
                array[i]=new ProgramConverter();
            }
            for (int i = n / 2; i < n ; i++)
            {
                array[i] = new ProgramHelper(); 
            }

        }
    }
}
