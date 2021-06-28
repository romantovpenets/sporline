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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        TcpClient tcpClient;
        public Window6()
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
            }
            if (tcpClient.Connected)
            {
                this.Close();
               
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Window w in App.Current.Windows)
                w.Close();
        }
    }
}
