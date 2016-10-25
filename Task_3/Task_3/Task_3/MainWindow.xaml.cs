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
using GCDLibrary;
using System.Diagnostics;

namespace Task_3
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

        private void FindGDC_Click(object sender, RoutedEventArgs e)
        {
            long elapsedTime;
            try
            {
                richTextBox.AppendText("GCD by Euclide of the " + number1.Text + " and " + number2.Text + " is " +
                                       GCDAlgoritms.GCDByEuclide(Int32.Parse(number1.Text), Int32.Parse(number2.Text),
                                           out elapsedTime) + "elapsed time: " + Convert.ToString(TimeSpan.FromTicks(elapsedTime).TotalMilliseconds) + "\n");
                richTextBox.AppendText("GCD by Stein of the " + number1.Text + " and " + number2.Text + " is " +
                                       GCDAlgoritms.GCDByStein(Int32.Parse(number1.Text), Int32.Parse(number2.Text),
                                           out elapsedTime) + "elapsed time: " + TimeSpan.FromTicks(elapsedTime).TotalMilliseconds.ToString() + "\n");

            }
            catch (OverflowException)
            {
                richTextBox.AppendText("input data is not correct\n");
            }

        }
    }
}
