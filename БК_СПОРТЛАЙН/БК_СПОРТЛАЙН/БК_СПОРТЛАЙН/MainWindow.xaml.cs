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
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Threading;

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        TcpClient tcpClient;
        public MainWindow()
        {
            InitializeComponent();
            

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
                ff.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                Window2 win = new Window2();

                win.Show();
                this.Close();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("64.233.161.101", 443);
            }
            catch (SocketException)
            {
                ff.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                Window1 win1 = new Window1();
                win1.Show();
                this.Close();
            }
            
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        
        }

        private void Window_Activated(object sender, EventArgs e)
        {
           
            ff.Visibility = Visibility.Hidden;
        }

        
    }
}
