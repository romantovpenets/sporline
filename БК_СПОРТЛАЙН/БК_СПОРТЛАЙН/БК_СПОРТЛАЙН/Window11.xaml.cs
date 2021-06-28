using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        int gn;
        string emaill;
        int a = 0;
        public Window11(int n)
        {
            InitializeComponent();
            gn = n;
            using (var connect = new Connect())
            {

                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.GameN == gn)
                    {
                        fio.Text = p.FIO_user;
                        chet.Text = Convert.ToString(p.GameN);
                        email.Text = p.Email_user;
                        tel.Text = p.Phone_user;
                        emaill = p.Email_user;
                        pass.Password = p.Password_user;
                        nomerpasp.Text = p.PasportNumber_user;
                        iden.Text = p.IdentifNumber_user;
                        mesto.Text=p.MestoVIdachi_user;
                    }

                }
            }
        }
        private void bv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bv_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //пароль
            WindowChangePassword w = new WindowChangePassword(gn);
            w.Show();
            this.Close();
            
        }

        private void Label_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
                MailAddress from = new MailAddress("bk_sportline@mail.ru", " Букмекерская контора SportLine");
                MailAddress to = new MailAddress(emaill);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Запрос на изменения почты";
                a = 0;
                Random rd = new Random();
                a = rd.Next(100000, 999999);
                m.Body = "<h2>Здравствуйте, вы запросили изменение вашего e-mail. Данный e-mail будет отвязан от вашего игрового счета! Ваш код для изменения: </h2>" + a;
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new System.Net.NetworkCredential("bk_sportline@mail.ru", "romantovpenets");
                smtp.EnableSsl = true;
                smtp.Send(m);
                WindowChangeEmail w = new WindowChangeEmail(gn,a);
                w.Show();
                this.Close();
        }
    }
}
