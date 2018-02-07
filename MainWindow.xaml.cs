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
        int num, index, ploh, i = 0;
        DateTime data1, data2;
        string eng, rus, stroka, vrem;
        Boolean fgot = false, fgot1 = false, den1 = false, den3 = false, den7 = false, den21 = false, den50 = false;




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
                + fgot1 + '|' + den1 + '|' + den3 + '|' + den7 + '|' + den21 + '|' + den50 + '|' + ploh + '|';
            using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Append, FileAccess.Write)))
            {
                sw.WriteLine(stroka);
                sw.Close();
            }
            using (StreamReader sw = new StreamReader("test.txt"))
            {
                stroka = sw.ReadLine();
                index = stroka.IndexOf('|');
                vrem = stroka.Substring(0, index);
                num = Convert.ToInt32(vrem);
                stroka = stroka.Remove(0, index + 1);
                index = stroka.IndexOf('|');
                eng = stroka.Substring(0, index);
                TextBlock1.Text = "Слово добавлено: " + eng;
                sw.Close();

            }
            /* Сброс */
            num = 0;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            while (i < 1)
            {
                using (StreamReader sw = new StreamReader("test.txt"))
                {
                    stroka = sw.ReadLine();
                    index = stroka.IndexOf('|');
                    vrem = stroka.Substring(0, index);
                    num = Convert.ToInt32(vrem);
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    eng = stroka.Substring(0, index);
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    rus = stroka.Substring(0, index);
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    data1 = Convert.ToDateTime(stroka.Substring(0, index));
                    TextBlock2.Text = Convert.ToString(data1.ToShortDateString());   // Дата
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    fgot = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    fgot1 = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    den1 = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    den3 = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    den7 = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    den21 = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    den50 = Convert.ToBoolean(stroka.Substring(0, index));
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    vrem = stroka.Substring(0, index);
                    ploh = Convert.ToInt32(vrem);
                    sw.Close();
                    TextBlock1.Text = "1111";
                    data2 = DateTime.Today;
                    if (den50 == false)
                    {
                        if (data2 >= data1.AddDays(50))
                        {
                            fgot = true;
                        }
                    }
                    else

                    if (den21 == false)
                    {
                        if (data2 >= data1.AddDays(21))
                        {
                            fgot = true;
                        }
                    }
                    else

                    if (den7 == false)
                    {
                        if (data2 >= data1.AddDays(7))
                        {
                            fgot = true;
                        }
                    }
                    else

                    if (den3 == false)
                    {
                        if (data2 >= data1.AddDays(3))
                        {
                            fgot = true;
                        }
                    }
                    else

                    if (den1 == false)
                    {
                        if (data2 >= data1.AddDays(1))
                        {
                            fgot = true;
                        }
                    }
                    if (fgot == true)
                    {
                        TextBlock1.Text = eng;
                        i++;
                    }
                    else
                    {
                        TextBlock1.Text = "Не найдено слово для проверки";
                        i++;
                    }
                }


            }
        }
    }
}
