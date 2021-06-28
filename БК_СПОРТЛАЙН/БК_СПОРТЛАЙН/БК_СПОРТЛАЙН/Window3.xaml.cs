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
using System.Windows.Shapes;
using System.IO;
using System.Net.Sockets;
namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        string t1;
        string t2;
        string t5;
        string t6;
        string t7;
        string t8;
        string t9;
        string t10;

        public Window3()
        {
            InitializeComponent();
        }
        public Window3(string s1, string s2, string s5, string s6, string s7, string s8, string s9, string s10)
        {
           
            InitializeComponent();
            t1 = s1;
            t2 = s2;
            t5 = s5;
            t6 = s6;
            t7 = s7;
            t8 = s8;
            t9 = s9;
            t10 = s10;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
                this.Close();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                Window1 win = new Window1(t1,t2,t5,t6,t7,t8,t9,t10);
                win.Show();
                this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
        }
    }
}
