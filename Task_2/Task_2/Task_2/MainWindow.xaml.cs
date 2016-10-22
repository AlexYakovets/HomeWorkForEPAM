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
using MyMath;

namespace Task_2
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double n, A, eps,result;
            try
            {
                if (Double.TryParse(inputN.Text, out n) == false) new FormatException();
                if (Double.TryParse(inputA.Text, out A) == false) new FormatException();
                if (Double.TryParse(inputEps.Text, out eps) == false) new FormatException();
                result=AlternativeMath.SqrtByNewton(n, A, eps);
                richTextBox.AppendText(result + "\n");
            }
            catch (FormatException)
            {
                richTextBox.AppendText("input data is not numeral");
            }


        }
    }
}
