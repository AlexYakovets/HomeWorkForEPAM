using Microsoft.Win32;
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
using StringRegex;

namespace Task_1_1_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string verifypattern = @"\b[0-9]{2}[.][0-9]{4}[,][0-9]{2}[.][0-9]{4}\b";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ConvertFromFile_Click(object sender, RoutedEventArgs e)
        {
            string fileName = ChoseFile.Text;
            if (fileName != "")
            {foreach (string s in StringRegexConvert.DoReplaceFromFile(fileName))
                {
                    richTextBox.AppendText(s+"\n");
                }
            }
        }

        private void ChangeDirectory_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Текстовый файл(*.TXT;*.DOC;*.DOCX)|*.TXT;*.DOC;*.DOCX";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = false;
            if (myDialog.ShowDialog() == true)
            {
                ChoseFile.Text = myDialog.FileName;
            }
        }

        private void ConvertString_Click(object sender, RoutedEventArgs e)
        {
            string str = textBox.Text;
            if (StringRegexConvert.IsMatchPattern(ref str, verifypattern))
            {
                StringRegexConvert.DoReplace(ref str);
                richTextBox.AppendText(str + "\n");
            }
            else richTextBox.AppendText("This string not correct"+"\n");
        }
    }
}
