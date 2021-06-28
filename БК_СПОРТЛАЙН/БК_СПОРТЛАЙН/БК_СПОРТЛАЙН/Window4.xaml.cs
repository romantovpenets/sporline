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
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Mail;
using System.Net.Sockets;
namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    /// 
    
    public partial class Window4 : Window
    {
        int gn = 0;
        float bl=0;
        TcpClient tcpClient;
        static object locker = new object();
        private int a;
        public Window4()
        {
            InitializeComponent();
            this.textbox_sss.PreviewTextInput += new TextCompositionEventHandler(textbox_sss_PreviewTextInput);
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
                f1.Visibility = Visibility.Visible;
                Window6 win = new Window6();
                win.ShowDialog();
            }
            if (tcpClient.Connected)
            {
                buttonS.Visibility = Visibility.Hidden;
                borderS.Visibility = Visibility.Hidden;
                borderS2.Visibility = Visibility.Hidden;
                labelS.Visibility = Visibility.Hidden;
                bboorder.Visibility = Visibility.Hidden;
                border_sss.Visibility = Visibility.Visible;
                border_sss1.Visibility = Visibility.Visible;
                textbox_sss.Visibility = Visibility.Visible;
                button_sss.Visibility = Visibility.Visible;
                MailAddress from = new MailAddress("bk_sportline@mail.ru", " Букмекерская контора SportLine");
                MailAddress to = new MailAddress(texett.Text);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Запрос на восстановление пароля";
                Random rd = new Random();
                a = rd.Next(100000, 999999);
                m.Body = "<h2>Здравствуйте, вы запросили восстановление пароля вашего аккаунта. Ваш код для доступа к аккаунту: </h2>" + a;
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("bk_sportline@mail.ru", "romantovpenets");
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
          
            
        }

       
        private void button1_click2(object sender, RoutedEventArgs e)
        {
            using (var connect = new Connect())
            {
                bool n = false;
                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.Email_user == Convert.ToString(texett.Text))
                    {
                        n = true;
                        gn = p.GameN;
                        bl = p.balanc_user;
                    }
                }

                if(n==true)
                {

                    bbord.IsEnabled = false;
                    texett.IsReadOnly = true;
                    butttton.IsEnabled = false;
                    border_sss.Visibility = Visibility.Hidden;
                    border_sss1.Visibility = Visibility.Hidden;
                    textbox_sss.Visibility = Visibility.Hidden;
                    button_sss.Visibility = Visibility.Hidden;
                    buttonS.Visibility = Visibility.Visible;
                    borderS.Visibility = Visibility.Visible;
                    borderS2.Visibility = Visibility.Visible;
                    labelS.Visibility = Visibility.Visible;
                    bboorder.Visibility = Visibility.Visible;
                }
                else
                {
                    texett.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    texett.Text = "АККАУНТ НЕ НАЙДЕН";
                }
            }
            
            



        }
        private void button1_click_3(object sender, RoutedEventArgs e)
        {
            
                tcpClient = new TcpClient();
                try
                {
                    tcpClient.Connect("64.233.161.101", 443);
                }
                catch (SocketException)
                {
                    f1.Visibility = Visibility.Visible;
                    Window6 win = new Window6();
                    win.ShowDialog();
                }
            if (tcpClient.Connected)
            {
                if (textbox_sss.Text == "")
                {
                    textbox_sss.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    textbox_sss.Text = "ВВЕДИТЕ КОД";
                }
                else if (a == Convert.ToInt32(textbox_sss.Text))
                {
                    glavnoeWindow win = new glavnoeWindow(gn,bl);
                    win.Show();
                    this.Close();
                }
                else
                {
                    textbox_sss.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    textbox_sss.Text = "НЕВЕРНЫЙ КОД";
                }
                
            }

            
            
        }

        private void button3_click(object sender, RoutedEventArgs e)
        {
            
                Window2 win = new Window2();
                win.Show();
                this.Close();

        }

        private void textbox_sss_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textbox_sss.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            textbox_sss.Background.Opacity = 0.5;
            textbox_sss.Clear();
        }

        private void textbox_sss_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void textbox_sss_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            f1.Visibility = Visibility.Hidden;
        }

        private void texett_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            texett.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            texett.Clear();
            texett.Background.Opacity = 0.5;
        }
    }
}
