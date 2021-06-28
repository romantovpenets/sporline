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
using Microsoft.Win32;
using System.Net.Sockets;
using FakeItEasy;

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
   
    public partial class Window1 : Window
    {
        TcpClient tcpClient;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string s1, string s2, string s5, string s6, string s7, string s8, string s9, string s10)
        {
            
            InitializeComponent();
            t1.Text = s1;
            t2.Text = s2;
            t5.Text = s5;
            t6.Text = s6;
            t7.Text = s7;
            t8.Text = s8;
            t9.Text = s9;
            t10.Text = s10;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                MainWindow win3 = new MainWindow();
                win3.Show();
                this.Close();
            
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                f.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
               
                Window1 win3 = new Window1();
                win3.Show();
                this.Close();
            }
            
        }

        private void button1_click2(object sender, RoutedEventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                f.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                Window3 win = new Window3(t1.Text,t2.Text,t5.Text,t6.Text,t7.Text,t8.Text,t9.Text,t10.Text);
                win.Show();
                this.Hide();
            }

        }
        private void zar_click(object sender, RoutedEventArgs e)
        {
            if (chekbox.IsChecked == false)
            {
                button_zar.IsEnabled = false;
            }
            else
            {
                button_zar.IsEnabled = true;
            }
        }

        private void Button_Click_zar(object sender, RoutedEventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                 f.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                using (var connect = new Connect())
                {
                    if(t1.Text == "")
                    {
                        t1.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        t1.Clear();
                    }
                    if(t2.Text=="")
                    {
                        t2.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        t2.Clear();
                    }
                    if (t3.Password == "" | t3.Password !=t4.Password)
                    {
                        t3.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        t4.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        t3.Clear();
                        t4.Clear();
                    }
                    if (t3.Password == "" | t3.Password != t4.Password)
                    {
                        t3.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        t4.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        t3.Clear();
                        t4.Clear();
                    }
                    if (t5.Text=="")
                    {
                        t5.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        
                        t5.Clear();
                    }
                    if (t6.Text == "")
                    {
                        t6.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));

                        t6.Clear();
                    }
                    if (t7.Text == "")
                    {
                        t7.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));

                        t7.Clear();
                    }
                    if (t8.Text == "")
                    {
                        t8.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));

                        t8.Clear();
                    }
                    if (t9.Text == "")
                    {
                        t9.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));

                        t9.Clear();
                    }
                    if (t10.Text == "")
                    {
                        t10.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));

                        t10.Clear();
                    }
                    if (t1.Text !=""  & t2.Text != "" & t3.Password != "" & t4.Password != "" & t5.Text != "" & t6.Text != "" & t7.Text != "" & t8.Text != "" & t9.Text!="" & t10.Text != "" & t3.Password==t4.Password)
                    
                    {
                        Random rnd = new Random();
                    a: int a = rnd.Next(100000, 999999);
                        List<USER> prt = connect.Users.ToList();
                        foreach (var p in prt)
                        {
                            if (p.GameN == a)
                            {
                                goto a;
                            }
                        }

                        // int gn,string email, string fio, string phone,string pasport, string ind, string mesto,string password, float balanc
                        USER b = new USER(a, t2.Text, t5.Text + " " + t6.Text + " " + t7.Text, t1.Text, t8.Text, t9.Text, t10.Text, t3.Password, 0.00F);

                        connect.Users.Add(b);
                        connect.SaveChanges();
                        glavnoeWindow win = new glavnoeWindow(a, 0.0F);
                        win.Show();
                        this.Close();
                    }
                   
                }
               
            }         
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t2.Focus();
            if (e.Key == Key.Down)
                t2.Focus();

        }

        private void t2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t3.Focus();

            if (e.Key == Key.Up)
                t1.Focus();

            if (e.Key == Key.Down)
                t3.Focus();
        }

        private void t3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t4.Focus();
            if (e.Key == Key.Up)
                t2.Focus();
            if (e.Key == Key.Down)
                t4.Focus();
        }

        private void t4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t5.Focus();
            if (e.Key == Key.Up)
                t3.Focus();
            if (e.Key == Key.Down)
                t5.Focus();
        }

        private void t5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t6.Focus();
            if (e.Key == Key.Up)
                t4.Focus();
            if (e.Key == Key.Down)
                t6.Focus();
        }

        private void t6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t7.Focus();
            if (e.Key == Key.Up)
                t5.Focus();
            if (e.Key == Key.Down)
                t7.Focus();
        }

        private void t7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t8.Focus();
            if (e.Key == Key.Up)
                t6.Focus();
            if (e.Key ==Key.Up)
                t8.Focus();
        }


        private void t9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t10.Focus();
            if (e.Key == Key.Up)
                t8.Focus();
            if (e.Key == Key.Down)
                t10.Focus();
        }

        private void t10_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void t8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                t9.Focus();
            if (e.Key == Key.Up)
                t7.Focus();
            if (e.Key == Key.Down)
                t9.Focus();
        }

        private void t1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
           
        }

        private void t1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void t5_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text,0))
                e.Handled = true;
            
        }

        private void t5_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
                e.Handled = true;
        }

        private void t6_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void t6_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0))
                e.Handled = true;
        }

        private void t7_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0))
                e.Handled = true;
        }

        private void t7_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            f.Visibility = Visibility.Hidden;
        }

        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void t1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t1.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t1.Background.Opacity = 0.3;
        }

        private void t2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t2.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t2.Background.Opacity = 0.3;
        }

        private void t3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t3.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t3.Background.Opacity = 0.3;
        }

        private void t4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t4.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t4.Background.Opacity = 0.3;
        }

        private void t5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t5.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t5.Background.Opacity = 0.3;
        }

        private void t6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t6.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t6.Background.Opacity = 0.3;
        }

        private void t7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t7.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t7.Background.Opacity = 0.3;
        }

        private void t8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t8.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t8.Background.Opacity = 0.3;
        }

        private void t9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t9.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t9.Background.Opacity = 0.3;
        }

        private void t10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            t10.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            t10.Background.Opacity = 0.3;
        }
    }
}
