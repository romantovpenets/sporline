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
using System.Net.Sockets;

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        TcpClient tcpClient;
        public Window2()
        {
            
            InitializeComponent();
            this.tt.PreviewTextInput += new TextCompositionEventHandler(tt_PreviewTextInput);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                f2.Visibility = Visibility.Visible;
                Window1 win = new Window1();
                win.ShowDialog();
                this.Close();
            }
            if (tcpClient.Connected)
            {
                Window1 win = new Window1();
                win.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                f2.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                if (tt.Text == "")
                {
                    tt.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    tt.Clear();
                }

                using (var connect = new Connect())
                {
                    string a11 = "";
                    float a111 = 0;
                    int a1111 = 0;
                    List<USER> prt = connect.Users.ToList();
                    foreach (var p in prt)
                    {
                        if (Convert.ToString(p.GameN) == tt.Text) 
                        {
                            a11 = p.Password_user;
                            a111 = p.balanc_user;
                            a1111 = p.GameN;

                        }
                    }
                    if (tt2.Password == "" | tt2.Password != a11)
                    {
                        tt2.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                       
                        tt2.Clear();
                      
                    }
                    if (tt2_Copy.Text == "" | tt2_Copy.Text != a11)
                    {
                        tt2_Copy.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                        tt2_Copy.Clear();
                    }
                    if (tt2.Password != "" & tt.Text != "" & tt2.Password == a11 & tt.Text!="0")
                    {
                        glavnoeWindow win = new glavnoeWindow(a1111,a111);
                        win.Show();
                        this.Close();
                    }
                    else if(tt2.Password != "" & tt.Text != "" & tt2.Password == a11 & tt.Text == "0")
                    {
                        adminWin win = new adminWin();
                        win.Show();
                        this.Close();
                    }
                    if (tt2_Copy.Text != "" & tt.Text != "" & tt2_Copy.Text == a11 &  tt.Text != "0")
                    {
                        glavnoeWindow win = new glavnoeWindow(a1111, a111);
                        win.Show();
                        this.Close();
                    }
                    else if(tt2_Copy.Text != "" & tt.Text != "" & tt2_Copy.Text == a11 & tt.Text == "0")
                    {
                        adminWin win = new adminWin();
                        win.Show();
                        this.Close();
                    }

                }
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                f2.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                Window4 win = new Window4();
                win.Show();
                this.Close();
            }

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
               
        }

        private void tt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                tt2.Focus();

          
        }

        private void tt_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tt2.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            tt2.Background.Opacity = 0.3;
        }

        private void tt2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tt2.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            tt2_Copy.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            tt2.Background.Opacity = 0.3;
            tt2_Copy.Background.Opacity = 0.3;

        }

        private void tt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!Char.IsDigit(e.Text, 0))
                e.Handled = true; 
        }

        private void tt_PreviewKeyDown(object sender, KeyEventArgs e)
        {
        
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            f2.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tt2.Password = tt2_Copy.Text;
            glaz.Visibility = Visibility.Hidden;
            glaz_Copy.Visibility = Visibility.Visible;
            tt2.Visibility = Visibility.Visible;
            tt2_Copy.Visibility = Visibility.Hidden;
        }

        private void glaz_Copy_Click(object sender, RoutedEventArgs e)
        {
            tt2_Copy.Text = tt2.Password;
            glaz_Copy.Visibility = Visibility.Hidden;
            glaz.Visibility = Visibility.Visible;
            tt2_Copy.Visibility = Visibility.Visible;
            tt2.Visibility = Visibility.Hidden;
           
        }

        private void tt2_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void tt_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void tt2_Copy_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tt2_Copy.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            tt2.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            tt2.Background.Opacity = 0.3;
            tt2_Copy.Background.Opacity = 0.3;
        }
    }
}
