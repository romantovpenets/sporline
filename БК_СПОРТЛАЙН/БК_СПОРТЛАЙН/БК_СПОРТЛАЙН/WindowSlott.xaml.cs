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

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class WindowSlott : Window
    {
        int gn;
        int ccounnt = 0;
        float bl;
        int ccount = 0;
        public WindowSlott(int gn1, float blq)
        {
            InitializeComponent();
            gn = gn1;
            bl = blq;
            balance.Content = bl;
        }
        private void Rectangle_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b1.IsEnabled = false;
            r1_Copy1.IsEnabled = false;
            r1_Copy2.IsEnabled = false;
            bb.IsEnabled = false;
            lst.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            l11.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            l12.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            l13.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            lst.Content = "УДАЧИ!";
            float itog = 0;
           
            if (Convert.ToInt32(balance.Content) - Convert.ToInt32(tb1.Text) < 0)
            {
                lst.Content = "Недостаточно средств!";
                bb.IsEnabled = true;
                r1_Copy2.IsEnabled = true;
                r1_Copy1.IsEnabled = true;
                b1.IsEnabled = true;

            }
            else
            {

                using (var connect = new Connect())
                {

                    List<USER> prt = connect.Users.ToList();
                    foreach (var p in prt)
                    {
                        if (gn == p.GameN)
                        {
                            p.balanc_user = p.balanc_user - float.Parse(tb1.Text);
                            balance.Content = p.balanc_user;
                            connect.SaveChanges();
                        }
                    }
                }
                Random rnd = new Random();
                System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
                timer1.Tick += new EventHandler(timer_Tick1);
                timer1.Interval = TimeSpan.FromMilliseconds(25);
                timer1.Start();
                void timer_Tick1(object sender1, EventArgs e1)
                    {

                        ccount++;
                        if (ccount < 30)
                        {
                           
                            int a = 0;
                            a = rnd.Next(0, 11);
                            if (a == 1)
                            {
                                l11.Content = "🂫";
                            }
                            else if (a == 2)
                            {
                                l11.Content = "🃝";
                            }
                            else if (a == 3)
                            {

                                l11.Content = "🂾";
                            }
                            else if (a == 4)
                            {
                                l11.Content = "🂵";
                            }
                            else if (a == 5)
                            {
                                l11.Content = "🂶";
                            }
                            else if (a == 6)
                            {
                                l11.Content = "🂷";
                            }
                            else if (a == 7)
                            {
                                l11.Content = "🂸";
                            }
                            else if (a == 8)
                            {
                                l11.Content = "🂹";
                            }
                            else if (a == 9)
                            {
                                l11.Content = "🂺";
                            }
                            else if (a == 10)
                            {
                                l11.Content = 7;
                            }

                            int b = rnd.Next(0, 11);
                            if (b == 1)
                            {
                                l12.Content = "🂫";
                            }
                            else if (b == 2)
                            {
                                l12.Content = "🃝";
                            }
                            else if (b == 3)
                            {

                                l12.Content = "🂾";
                            }
                            else if (b == 4)
                            {
                                l12.Content = "🂵";
                            }
                            else if (b == 5)
                            {
                                l12.Content = "🂶";
                            }
                            else if (b == 6)
                            {
                                l12.Content = "🂷";
                            }
                            else if (b == 7)
                            {
                                l12.Content = "🂸";
                            }
                            else if (b == 8)
                            {
                                l12.Content = "🂹";
                            }
                            else if (b == 9)
                            {
                                l12.Content = "🂺";
                            }
                            else if (b == 10)
                            {
                                l12.Content = 7;
                            }
                            int c = rnd.Next(0, 11);
                            if (c == 1)
                            {
                                l13.Content = "🂫";
                            }
                            else if (c == 2)
                            {
                                l13.Content = "🃝";
                            }
                            else if (c == 3)
                            {

                                l13.Content = "🂾";
                            }
                            else if (c == 4)
                            {
                                l13.Content = "🂵";
                            }
                            else if (c == 5)
                            {
                                l13.Content = "🂶";
                            }
                            else if (c == 6)
                            {
                                l13.Content = "🂷";
                            }
                            else if (c == 7)
                            {
                                l13.Content = "🂸";
                            }
                            else if (c == 8)
                            {
                                l13.Content = "🂹";
                            }
                            else if (c == 9)
                            {
                                l13.Content = "🂺";
                            }
                            else if (c == 10)
                            {
                            l13.Content = 7;
                            }
                        }
                        if (ccount > 29 & ccount < 66)
                        {

                            int b = rnd.Next(0, 11);
                            if (b == 1)
                            {
                                l12.Content = "🂫";
                            }
                            else if (b == 2)
                            {
                                l12.Content = "🃝";
                            }
                            else if (b == 3)
                            {
                                l12.Content = "🂾";
                            }
                            else if (b == 4)
                            {
                                l12.Content = "🂵";
                            }
                            else if (b == 5)
                            {
                                l12.Content = "🂶";
                            }
                            else if (b == 6)
                            {
                                l12.Content = "🂷";
                            }
                            else if (b == 7)
                            {
                                l12.Content = "🂸";
                            }
                            else if (b == 8)
                            {
                                l12.Content = "🂹";
                            }
                            else if (b == 9)
                            {
                                l12.Content = "🂺";
                            }
                            else if (b == 10)
                            {
                                l12.Content = 7;
                            }
                            int c = rnd.Next(0, 11);
                            if (c == 1)
                            {
                                l13.Content = "🂫";
                            }
                            else if (c == 2)
                            {
                                l13.Content = "🃝";
                            }
                            else if (c == 3)
                            {

                                l13.Content = "🂾";
                            }
                            else if (c == 4)
                            {
                                l13.Content = "🂵";
                            }
                            else if (c == 5)
                            {
                                l13.Content = "🂶";
                            }
                            else if (c == 6)
                            {
                                l13.Content = "🂷";
                            }
                            else if (c == 7)
                            {
                                l13.Content = "🂸";
                            }
                            else if (c == 8)
                            {
                                l13.Content = "🂹";
                            }
                            else if (c == 9)
                            {
                                l13.Content = "🂺";
                            }
                            else if (c == 10)
                            {

                                l13.Content = 7;
                            }
                        }
                        if (ccount > 65 & ccount < 100)
                        {

                            int c = rnd.Next(0, 11);
                            if (c == 1)
                            {
                                l13.Content = "🂫";
                               

                            }
                            else if (c == 2)
                            {
                                l13.Content = "🃝";
                                
                            }
                            else if (c == 3)
                            {

                                l13.Content = "🂾";
                               
                            }
                            else if (c == 4)
                            {
                                l13.Content = "🂵";
                               
                            }
                            else if (c == 5)
                            {
                                l13.Content = "🂶";
                                
                            }
                            else if (c == 6)
                            {
                                l13.Content = "🂷";
                              
                            }
                            else if (c == 7)
                            {
                                l13.Content = "🂸";
                               
                            }
                            else if (c == 8)
                            {
                                l13.Content = "🂹";
                               
                            }
                            else if (c == 9)
                            {
                                l13.Content = "🂺";
                                
                            }
                            else if (c == 10)
                            {


                                l13.Content = "7";
                               
                            }
                        }
                    if (ccount == 100)
                    {
                        ccount = 0;
                       
                        if (l11.Content == l12.Content & l13.Content == l12.Content)
                        {
                            System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
                            timer2.Tick += new EventHandler(timer_Tick2);
                            timer2.Interval = TimeSpan.FromMilliseconds(80);
                            timer2.Start();
                            void timer_Tick2(object sender2, EventArgs e2)
                            {

                                
                                if (Convert.ToString(l11.Content) == "7")
                                {
                                   
                                    ccounnt++;
                                    lst.Content = "Вы СОРВАЛИ ДЖЕКПОТ!\nВаш выигрыш: " + Convert.ToInt32(tb1.Text) * 1000 + " рублей";
                                    itog = Convert.ToInt32(tb1.Text) * 1000;
                                    lst.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                    lst.Opacity = 0.7;
                                    if (ccounnt % 2 == 0)
                                    {
                                        l11.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                        l12.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                        l13.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                        // lst.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                    }
                                    else
                                    {
                                        l11.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        l12.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        l13.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        // 

                                    }
                                    if (ccounnt == 30)
                                    {
                                        using (var connect = new Connect())
                                        {
                                            List<USER> prt1 = connect.Users.ToList();
                                            foreach (var p1 in prt1)
                                            {             
                                                if (gn == p1.GameN)
                                                {
                                                    p1.balanc_user = p1.balanc_user + itog;
                                                    balance.Content = p1.balanc_user;
                                                    connect.SaveChanges();
                                                }
                                            }
                                        }
                                        ccounnt = 0;

                                        timer2.Stop();
                                    }


                                }
                                else if(Convert.ToString(l11.Content) == "🂫" | Convert.ToString(l11.Content) == "🃝"| Convert.ToString(l11.Content) == "🂾" )
                                {
                                    lst.Content = "Вы выиграли!\nВаш выигрыш: " + Convert.ToInt32(tb1.Text) * 300 + " рублей";
                                    lst.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                    itog = Convert.ToInt32(tb1.Text) * 300;
                                    lst.Opacity = 0.7;
                                    ccounnt++;
                                    if (ccounnt % 2 == 0)
                                    {
                                        l11.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                        l12.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                        l13.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                        //lst.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                    }
                                    else
                                    {
                                        l11.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        l12.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        l13.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));


                                    }
                                    if (ccounnt == 20)
                                    {
                                        using (var connect = new Connect())
                                        {
                                            List<USER> prt1 = connect.Users.ToList();
                                            foreach (var p1 in prt1)
                                            {
                                                if (gn == p1.GameN)
                                                {
                                                    p1.balanc_user = p1.balanc_user + itog;
                                                    balance.Content = p1.balanc_user;
                                                    connect.SaveChanges();
                                                }
                                            }
                                        }
                                        ccounnt = 0;
                                        timer2.Stop();
                                    }
                                }
                                else
                                {
                                    lst.Content = "Вы выиграли!\nВаш выигрыш: " + Convert.ToInt32(tb1.Text) * 100 + " рублей";
                                    lst.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                    itog = Convert.ToInt32(tb1.Text) * 100;
                                    lst.Opacity = 0.7;
                                    ccounnt++;
                                    if (ccounnt % 2 == 0)
                                    {
                                        l11.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                        l12.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                        l13.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                                        //lst.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                    }
                                    else
                                    {
                                        l11.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        l12.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                        l13.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));


                                    }
                                    if (ccounnt == 20)
                                    {
                                        using (var connect = new Connect())
                                        {
                                            List<USER> prt1 = connect.Users.ToList();
                                            foreach (var p1 in prt1)
                                            {
                                                if (gn == p1.GameN)
                                                {
                                                    p1.balanc_user = p1.balanc_user + itog;
                                                    balance.Content = p1.balanc_user;
                                                    connect.SaveChanges();
                                                }
                                            }
                                        }
                                        ccounnt = 0;
                                        timer2.Stop();
                                    }
                                }    
                            }


                        }
                        else if (l11.Content == l12.Content)
                        {

                            if (Convert.ToString(l11.Content) == "7")
                            {
                                lst.Content = "Вы выиграли!\nВаш выигрыш: " + Convert.ToInt32(tb1.Text) * 50 + " рублей";
                                itog = Convert.ToInt32(tb1.Text) * 50;
                                lst.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                                lst.Opacity = 0.7;
                                ccounnt++;
                                l11.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                                l12.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                            }
                            else if(Convert.ToString(l11.Content) == "🂫" | Convert.ToString(l11.Content) == "🃝" | Convert.ToString(l11.Content) == "🂾")
                            {
                                lst.Content = "Вы выиграли!\nВаш выигрыш: " + Convert.ToInt32(tb1.Text) * 10 + " рублей";
                                itog = Convert.ToInt32(tb1.Text) * 10;
                                lst.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                                lst.Opacity = 0.7;
                                ccounnt++;
                                l11.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                                l12.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                            }
                            else
                            {
                                lst.Content = "Вы выиграли!\nВаш выигрыш: " + Convert.ToInt32(tb1.Text) * 3 + " рублей";
                                itog = Convert.ToInt32(tb1.Text) * 3;
                                lst.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                                lst.Opacity = 0.7;
                                ccounnt++;
                                l11.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                                l12.Foreground = new SolidColorBrush(Color.FromRgb(160, 222, 160));
                            }
                            using (var connect = new Connect())
                            {
                                List<USER> prt1 = connect.Users.ToList();
                                foreach (var p1 in prt1)
                                {
                                    if (gn == p1.GameN)
                                    {
                                        p1.balanc_user = p1.balanc_user + itog;
                                        balance.Content = p1.balanc_user;
                                        connect.SaveChanges();
                                    }
                                }
                            }
                            ccounnt = 0;
                        }
                        else
                        {

                            lst.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            lst.Content = "Повезет в следующий раз!";
                            ccounnt = 0;


                        }

                        bb.IsEnabled = true;
                        r1_Copy2.IsEnabled = true;
                        r1_Copy1.IsEnabled = true;
                        b1.IsEnabled = true;
                        timer1.Stop();

                    }
                    
                }
                

            }




        }

        private void r1_Copy2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tb1.Text == "99")
                {

            }
            else
            {
               
                int a = Convert.ToInt32(tb1.Text) + 1;
                tb1.Text = Convert.ToString(a);
                l1.Content = 3 * Convert.ToInt32(tb1.Text);
                l2.Content = 10 * Convert.ToInt32(tb1.Text);
                l3.Content = 50 * Convert.ToInt32(tb1.Text);
                l4.Content = 100 * Convert.ToInt32(tb1.Text);
                l5.Content = 300 * Convert.ToInt32(tb1.Text);
                l6.Content = 1000 * Convert.ToInt32(tb1.Text);





            }

        }

        private void tb1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0))
                e.Handled = true;
        }

        private void tb1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void r1_Copy1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tb1.Text == "1")
            {

            }
            else
            {
                int a = Convert.ToInt32(tb1.Text) - 1;
                tb1.Text = Convert.ToString(a);
                l1.Content = 3 * Convert.ToInt32(tb1.Text);
                l2.Content = 10 * Convert.ToInt32(tb1.Text);
                l3.Content = 50 * Convert.ToInt32(tb1.Text);
                l4.Content = 100 * Convert.ToInt32(tb1.Text);
                l5.Content = 300 * Convert.ToInt32(tb1.Text);
                l6.Content = 1000 * Convert.ToInt32(tb1.Text);
            }
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            this.Close();
           
        }
    }
}
