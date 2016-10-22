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
                if (Double.TryParse(inputN.Text, out n))throw new FormatException();
                if (Double.TryParse(inputA.Text, out A))throw new FormatException();
                if (Double.TryParse(inputEps.Text, out eps))throw new FormatException();
                result=AlternativeMath.SqrtByNewton(n, A, eps);
                richTextBox.AppendText("result of MyMath:"+ result + ",result of Math.Pow:"+Math.Pow(A,1/n)+"\n");
            }
            catch (FormatException)
            {
                richTextBox.AppendText("input data is not numeral");
            }


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                label2.Content = textBox.Text + "in binary code : " + AlternativeMath.ToBinaryCode(Convert.ToInt32(textBox.Text));
            }
            catch(ArgumentOutOfRangeException) { label2.Content = "entered number shouldn't be less than 0"; }
            catch(FormatException) { label2.Content = "input data is not numeral"; }
        }
    }
}
