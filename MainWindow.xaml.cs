using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
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
        int num, index, index2;
        DateTime data1, data2;
        string eng, rus, stroka, vrem;
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
            using (StreamReader sw = new StreamReader("test.txt"))
            {
                String line;
                while ((line = sw.ReadLine()) != null)
                {
                    num++;
                }
            }
            eng = TextBox1.Text;
            rus = TextBox2.Text;
            data1 = DateTime.Today;
            stroka = num.ToString() + '|' + eng + '|' + rus + '|' + data1.ToShortDateString() + '|' + fgot + '|' 
                + fgot1 + '|' + den1 + '|' + den3 + '|' + den7 + '|' + den21 + '|' + den50 + '|';
            using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Append, FileAccess.Write)))
            {
                sw.WriteLine(stroka);
                sw.Close();
            }
            using (StreamReader sw = new StreamReader("test.txt"))
            {
                stroka = sw.ReadLine();
                index = stroka.IndexOf('|');
                num = Convert.ToInt32(stroka.Substring(0, index-1));
                TextBlock1.Text = num.ToString();
                stroka = stroka.Remove(0, index+1);
                index = stroka.IndexOf('|');
                eng = stroka.Substring(0, index);
                TextBlock1.Text = eng;
                sw.Close();

            }
                /* Сброс */
                num = 0;
        }
    }
}
