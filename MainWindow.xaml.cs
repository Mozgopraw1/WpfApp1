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
        int num, index, ploh, i = 0, ii = 0, a, b, c, d, v, flagknop = 0, sbrosprov = 0, vrem1, but2flag;
        int NewSlov, Day1Slov, Day3Slov, Day7Slov, Day21Slov, Day50Slov; // TZ 2
        int NoLucky; // Флаг повторной не сдачи слов.

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            flagknop = 1;
            sbrosprov = 1;
            i = 0;
        }

        private void SlovaSeg_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sw = new StreamReader("test.txt", Encoding.Default))
            {
                ii = 0;

                while ((stroka = sw.ReadLine()) != null)
                {


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
                    data2 = DateTime.Today;
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    vrem = stroka.Substring(0, index);
                    NoLucky = Convert.ToInt32(vrem);

                    flagknop = 1;
                    if (sbrosprov == 1)
                    { i = 0;

                    }
                    sbrosprov = 0;
                    if (i == num)
                    {
                        i++;
                        if (ChangeDay.Text == "New")
                        {
                            if (den1 == false)
                            {
                                if (data2 == data1)
                                {
                                    fgot = true;
                                    a = 0; b = 0; c = 0; d = 0; v = 0;
                                }
                            }
                        }
                        if (ChangeDay.Text == "Day 1")
                        {
                            if (den3 == false)
                                if (den1 == true)
                                {
                                    if (data2 == data1)
                                    {
                                        fgot = true;
                                        a = 1; b = 0; c = 0; d = 0; v = 0;
                                    }
                                }
                        }
                        if (ChangeDay.Text == "Day 3")
                        {
                            if (den7 == false)
                                if (den3 == true)
                                {
                                    if (data2 == data1)
                                    {
                                        fgot = true;
                                        a = 0; b = 1; c = 0; d = 0; v = 0;
                                    }
                                }
                        }
                        if (ChangeDay.Text == "Day 7")
                        {
                            if (den21 == false)
                                if (den7 == true)
                                {
                                    if (data2 == data1)
                                    {
                                        fgot = true;
                                        a = 0; b = 0; c = 1; d = 0; v = 0;
                                    }
                                }
                        }
                        if (ChangeDay.Text == "Day 21")
                        {
                            if (den50 == false)
                                if (den21 == true)
                                {
                                    if (data2 == data1)
                                    {
                                        fgot = true;
                                        a = 0; b = 0; c = 0; d = 1; v = 0;
                                    }
                                }
                        }
                        if (ChangeDay.Text == "Day 50")
                        {
                            if (den50 == true)
                            {
                                fgot = true;
                                a = 0; b = 0; c = 0; d = 0; v = 1;
                            }
                        }
                    }
                    if (fgot == true)
                    {
                        TextBlock1.Text = eng;
                        sw.Close();
                        ii++;
                        break;
                    }
                } // Вроде работает, нужен тест
                if (ii == 0)
                {
                    vrem1 = num;
                    vrem1++;
                    i = 0;

                    TextBlock1.Text = "Не найдено слов на проверку из: " + vrem1;
                }
            }
        }


        DateTime data1, data2, data3;
        string eng, rus, stroka, vrem, slovoeng, slovorus;
        Boolean fgot = false, fgot1 = false, den1 = false, den3 = false, den7 = false, den21 = false, den50 = false;

        private void Net_Click(object sender, RoutedEventArgs e)
        {
            if (but2flag == 1)
            {
                but2flag = 0;
                if (flagknop == 0)
                {
                    string[] lines = System.IO.File.ReadAllLines("test.txt", Encoding.Default);
                    fgot = false;
                    if (a == 1)
                    {
                        data1 = DateTime.Today;
                    }
                    else
                    if (b == 1)
                    {
                        data1 = DateTime.Today;
                    }
                    else
                    if (c == 1)
                    {
                        data1 = DateTime.Today;
                    }
                    else
                    if (d == 1)
                    {
                        data1 = DateTime.Today;
                    }
                    else
                    if (v == 1)
                    {
                        data1 = DateTime.Today;
                    }
                    stroka = lines[num];
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
                    stroka = stroka.Remove(0, index + 1);
                    ploh++;
                    index = stroka.IndexOf('|');
                    vrem = stroka.Substring(0, index);
                    NoLucky = Convert.ToInt32(vrem);
                    NoLucky++;
                    data1 = DateTime.Today;
                    if (NoLucky >= 2)
                    {
                        if (a == 1) { NoLucky = 0; }
                        else if (b == 1)
                        {
                            den1 = false;
                            NoLucky = 0;
                        }
                        else if (c == 1)
                        {
                            den3 = false;
                            NoLucky = 0;
                        }
                        else if (d == 1)
                        {
                            den7 = false;
                            NoLucky = 0;
                        }
                        else if (v == 1)
                        {
                            den21 = false;
                            NoLucky = 0;
                        }
                    }
                    stroka = num.ToString() + '|' + eng + '|' + rus + '|' + data1.ToShortDateString() + '|' + fgot + '|'
                        + fgot1 + '|' + den1 + '|' + den3 + '|' + den7 + '|' + den21 + '|' + den50 + '|' + ploh + '|' + NoLucky + '|';
                    lines[num] = stroka;
                    string file1 = "test.txt";
                    File.WriteAllLines(file1, lines, Encoding.Default);
                    a = 0; b = 0; c = 0; d = 0; v = 0;
                    TextBlock2.Text = "Повторений: " + ploh;
                    TextBlock1.Text = eng + " - " + rus;
                }
                if (flagknop == 1)
                {
                    string[] lines = System.IO.File.ReadAllLines("test.txt", Encoding.Default);
                    fgot = false;
                    stroka = lines[num];
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
                    ploh++;
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    vrem = stroka.Substring(0, index);
                    NoLucky = Convert.ToInt32(vrem);
                    stroka = num.ToString() + '|' + eng + '|' + rus + '|' + data1.ToShortDateString() + '|' + fgot + '|'
                        + fgot1 + '|' + den1 + '|' + den3 + '|' + den7 + '|' + den21 + '|' + den50 + '|' + ploh + '|' + NoLucky + '|';
                    lines[num] = stroka;
                    string file1 = "test.txt";
                    File.WriteAllLines(file1, lines, Encoding.Default);
                    TextBlock2.Text = "Повторений: " + ploh;
                    TextBlock1.Text = eng + " - " + rus;
                }
            } else { TextBlock2.Text = "Сначала подтвердите слово"; }
        }

        private void Da_Click(object sender, RoutedEventArgs e)
        {

            if (but2flag == 1)
            {
                but2flag = 0;
                if (flagknop == 0)
                {
                    string[] lines = System.IO.File.ReadAllLines("test.txt", Encoding.Default);
                    fgot = false;
                    if (a == 1)
                    {
                        den1 = true;
                        data1 = DateTime.Today;
                        ploh++;
                    }
                    else
                    if (b == 1)
                    {
                        den3 = true;
                        data1 = DateTime.Today;
                        ploh++;
                    }
                    else
                    if (c == 1)
                    {
                        den7 = true;
                        data1 = DateTime.Today;
                        ploh++;
                    }
                    else
                    if (d == 1)
                    {
                        den21 = true;
                        data1 = DateTime.Today;
                        ploh++;
                    }
                    else
                    if (v == 1)
                    {
                        den50 = true;
                        data1 = DateTime.Today;
                        ploh++;
                    }

                    stroka = num.ToString() + '|' + eng + '|' + rus + '|' + data1.ToShortDateString() + '|' + fgot + '|'
                        + fgot1 + '|' + den1 + '|' + den3 + '|' + den7 + '|' + den21 + '|' + den50 + '|' + ploh + '|' + NoLucky + '|';
                    lines[num] = stroka;

                    string file1 = "test.txt";
                    File.WriteAllLines(file1, lines, Encoding.Default);
                    a = 0; b = 0; c = 0; d = 0; v = 0;
                    TextBlock2.Text = "Слово прошло проверку";
                }
                if (flagknop == 1)
                {
                    TextBlock2.Text = "Слово прошло проверку";
                }
            } else { TextBlock2.Text = "Сначала подтвердите слово"; }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            slovoeng = TextBlock1.Text;
            slovorus = TextBox2.Text;
            TextBlock2.Text = rus;
            but2flag = 1;
        }

        public MainWindow()
        {
            InitializeComponent();

            using (StreamReader sw = new StreamReader("test.txt", Encoding.Default))
            {
                while ((stroka = sw.ReadLine()) != null)
                {


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
                    data2 = DateTime.Today;
                    
                    if (den1 == false)
                        NewSlov++;
                    if (den1 == true & den3 == false)
                        Day1Slov++;
                    if (den3 == true & den7 == false)
                        Day3Slov++;
                    if (den7 == true & den21 == false)
                        Day7Slov++;
                    if (den21 == true & den50 == false)
                        Day21Slov++;
                    if (den50 == true)
                        Day50Slov++;
                    NewText.Text = "Новых слов: " + NewSlov;
                    Day1Text.Text = "Day1: " + Day1Slov;
                    Day3Text.Text = "Day3: " + Day3Slov;
                    Day7Text.Text = "Day7: " + Day7Slov;
                    Day21Text.Text = "Day21: " + Day21Slov;
                    Day50Text.Text = "Day50: " + Day50Slov;
                }
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sw = new StreamReader("test.txt"))
            {
                String line;
                num = 0;
                while ((line = sw.ReadLine()) != null)
                {
                    num++;
                }
            }
            eng = TextBox1.Text;
            rus = TextBox2.Text;
            data1 = DateTime.Today;
            fgot = false;
            fgot1 = false;
            den1 = false;
            den3 = false;
            den7 = false;
            den21 = false;
            den50 = false;
            ploh = 1;
            stroka = num.ToString() + '|' + eng + '|' + rus + '|' + data1.ToShortDateString() + '|' + fgot + '|'
                + fgot1 + '|' + den1 + '|' + den3 + '|' + den7 + '|' + den21 + '|' + den50 + '|' + ploh + '|' + NoLucky + '|';
            using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Append, FileAccess.Write), Encoding.Default))
            {
                sw.WriteLine(stroka);
                sw.Close();
            }
            TextBlock1.Text = "Слово добавлено: " + eng;
            TextBlock2.Text = " ";
            num = 0;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            using (StreamReader sw = new StreamReader("test.txt", Encoding.Default))
            {
                ii = 0;

                while ((stroka = sw.ReadLine()) != null)
                {


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
                    data2 = DateTime.Today;
                    stroka = stroka.Remove(0, index + 1);
                    index = stroka.IndexOf('|');
                    vrem = stroka.Substring(0, index);
                    NoLucky = Convert.ToInt32(vrem);
                    flagknop = 0;
                    if (den1 == false)
                    {
                        data1 = data1.AddDays(1);
                        if (data2 >= data1)
                        {
                            fgot = true;
                            a = 1; b = 0; c = 0; d = 0; v = 0;
                        }
                    }
                    else
                    if (den3 == false)
                    {
                        data1 = data1.AddDays(3);
                        if (data2 >= data1)
                        {
                            fgot = true;
                            a = 0; b = 1; c = 0; d = 0; v = 0;
                        }
                    }
                    else
                    if (den7 == false)
                    {
                        data1 = data1.AddDays(7);
                        if (data2 >= data1)
                        {
                            fgot = true;
                            a = 0; b = 0; c = 1; d = 0; v = 0;
                        }
                    }
                    else
                    if (den21 == false)
                    {
                        data1 = data1.AddDays(21);
                        if (data2 >= data1)
                        {
                            fgot = true;
                            a = 0; b = 0; c = 0; d = 1; v = 0;
                        }
                    }
                    else
                    if (den50 == false)
                    {
                        data1 = data1.AddDays(50);
                        if (data2 >= data1)
                        {
                            fgot = true;
                            a = 0; b = 0; c = 0; d = 0; v = 1;
                        }
                    }
                    if (fgot == true)
                    {
                        TextBlock1.Text = eng;
                        ii++;
                        sw.Close();
                        break;
                    }
                }
                if (ii == 0)
                {
                    num++;
                    TextBlock1.Text = "Не найдено слов на проверку из: " + num;
                }
            }
        }
    }


}

