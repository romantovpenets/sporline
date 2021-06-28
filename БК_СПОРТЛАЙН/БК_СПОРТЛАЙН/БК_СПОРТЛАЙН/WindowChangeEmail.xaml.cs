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
using System.Net.Mail;
using System.Net.Sockets;
namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для WindowChangeEmail.xaml
    /// </summary>
    public partial class WindowChangeEmail : Window
    {
        TcpClient tcpClient;
        int a = 0;
        int gn=0;
        int k = 0;
        public WindowChangeEmail(int g,int kod)
        {
            gn = g;
            k = kod;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var connect = new Connect())
            {

                List<USER> prt = connect.Users.ToList();
                bool ch = true;
                foreach (var p in prt)
                {
                    if (p.Email_user != pass_Copy.Text)
                    {
                    }
                    else
                    {
                        ch = false;  
                    }
                    
                }
                if (ch == true)
                {

                    MailAddress from = new MailAddress("bk_sportline@mail.ru", " Букмекерская контора SportLine");
                    MailAddress to = new MailAddress(pass_Copy.Text);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Запрос на изменения почты";
                    a = 0;
                    Random rd = new Random();
                    a = rd.Next(100000, 999999);
                    m.Body = "<h2>Здравствуйте, вы запросили изменение вашего e-mail. Данный e-mail будет привязан с вашему игровому счету! Ваш код для изменения: </h2>" + a;
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                    smtp.Credentials = new System.Net.NetworkCredential("bk_sportline@mail.ru", "romantovpenets");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    pass_Copy.IsReadOnly = true;
                    ls.Visibility = Visibility.Visible;
                    pass_Copy1.Visibility = Visibility.Visible;
                }
                else
                {

                    pass_Copy.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    pass_Copy.Clear();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(k) == pass.Text)
            {
                bss.Visibility = Visibility.Visible;
                lss.Visibility = Visibility.Visible;
                pass_Copy.Visibility = Visibility.Visible;
                pass.IsReadOnly = true;
            }
            else
            {
                pass.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                pass.Clear();
            }
        }

        private void pass_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pass.Background = new SolidColorBrush(Color.FromRgb(2, 2, 2));
            pass.Background.Opacity = 0.25;
        }

        private void pass_Copy_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pass_Copy.Background = new SolidColorBrush(Color.FromRgb(2, 2, 2));
            pass_Copy.Background.Opacity = 0.25;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(a) == pass_Copy1.Text)
            {
                using (var connect = new Connect())
                {

                    List<USER> prt = connect.Users.ToList();
                    foreach (var p in prt)
                    {
                        if(p.GameN==gn)
                        {
                            p.Email_user = pass_Copy.Text;
                            connect.SaveChanges();
                            Window11 a = new Window11(gn);
                            a.Show();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                pass_Copy1.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                pass_Copy1.Clear();
            }
        }

        private void pass_Copy1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pass_Copy1.Background = new SolidColorBrush(Color.FromRgb(2, 2, 2));
            pass_Copy1.Background.Opacity = 0.25;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window11 a = new Window11(gn);
            a.Show();
            this.Close();
        }
    }
}
