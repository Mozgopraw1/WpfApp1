using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num, data;
        char[] eng, rus;
        Boolean fgot = false, fgot1 = false, den1=false, den3=false, den7=false, den21=false, den50=false;

        public MainWindow()
        {
                InitializeComponent();
                
            FileStream file1 = new FileStream("test.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1, Encoding.Unicode);
            StreamWriter writer = new StreamWriter(file1, Encoding.UTF8);


            writer.Close();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            FileStream file1 = new FileStream("test.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1, Encoding.Unicode);
            StreamWriter writer = new StreamWriter(file1, Encoding.UTF8);
            writer.WriteLine(TextBox1.Text);
            writer.Close();
        }
    }
}
