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
using ClassLibrary1;

namespace Task_5
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
            Vectors masOfVec = new Vectors();
            for (int i = 0; i < masOfVec.Length - 2; i++)
            //{
            //    try
            //    {
            //        ClassLibrary1.Vector vec = masOfVec[i] + masOfVec[i + 1];
            //        richTextBox.AppendText(vec.ToString()+"\n");
            //    }
            //    catch (Exception ex)
            //    {
                    
            //        richTextBox.AppendText(ex.Message);
            //    }
            //}
                foreach (var var in masOfVec.GetVectors(2))
                {
                    try
                    {
                        richTextBox.AppendText("Operation + : ");
                        ClassLibrary1.Vector vec = masOfVec[i] + masOfVec[i + 1];
                        richTextBox.AppendText(vec.ToString() + "\n");
                        richTextBox.AppendText("Operation - : ");
                        vec = masOfVec[i]- masOfVec[i + 1];
                        richTextBox.AppendText(vec.ToString() + "\n");
                        richTextBox.AppendText("Operation * : ");
                        double result = masOfVec[i] * masOfVec[i + 1];
                        richTextBox.AppendText("result = "+result+ "\n");
                        richTextBox.AppendText("Operation ^ : ");
                        result = masOfVec[i] ^ masOfVec[i + 1];
                        richTextBox.AppendText("angle is :"+result + "\n");

                    }
                    catch (Exception ex)
                    {

                        richTextBox.AppendText(ex.Message+"\n");
                    }
                }
        }
    }
}
