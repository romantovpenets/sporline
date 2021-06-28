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
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        int gn = 0;
        float bl = 0;
        int neraz = 0;
        public Window5(int a, float b)
        {
            InitializeComponent();

            using (var connect = new Connect())
            {
                List<HistoryStavok> prt4 = connect.historyStavoks.ToList();

                foreach (var p in prt4)
                {
                    if (p.autor_stavki == a & p.status_stavki == "В игре")
                    {
                        neraz = neraz + Convert.ToInt32(p.summa_stavki);
                    }
                }
            }
            ner.Content = neraz;

            b = Convert.ToInt32(b);
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            bl = b;
            gn = a;
            Show_historyAll(gn);
            ll.Content = a;
            lll.Content = b;
            llll.Content = b;

            using (var connect = new Connect())
            {
                DateTime noww = new DateTime();
                noww = DateTime.Now;

                List<stavka> prt3 = connect.staavki.ToList();
                foreach (var p1 in prt3)
                {
                    DateTime stavka = new DateTime();
                    stavka = Convert.ToDateTime(p1.vremya);
                    if ((stavka - noww).TotalHours < 0)
                    {
                        p1.vid_sport = "-";
                        connect.SaveChanges();
                    }
                }
                SqlConnectionStringBuilder connectt = new SqlConnectionStringBuilder();
                connectt.InitialCatalog = "SportLine4";
                connectt.DataSource = @"DESKTOP-0G6AU5C\SQLEXPRESS";
                connectt.ConnectTimeout = 30;
                connectt.IntegratedSecurity = true;
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = connectt.ConnectionString;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"Delete  stavkas where [vid_sport]='-'";
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }










                List<HistoryStavok> prt1 = connect.historyStavoks.ToList();
                foreach (var p1 in prt1)
                {
                    if (gn == p1.autor_stavki & p1.status_stavki == "В игре")
                    {
                        DateTime stavka = new DateTime();
                        stavka = Convert.ToDateTime(p1.vremya_stavki);
                        
                        if ((stavka - noww).TotalHours < -1)
                        {
                            Random rnd = new Random();
                            int chh = rnd.Next(1, 101);
                            int raznica = Convert.ToInt32(100.0 / Convert.ToDouble(p1.kf_stavki));
                            if (chh > raznica)
                            {
                                p1.status_stavki = "Проиграл";
                                connect.SaveChanges();
                            }
                            else
                            {
                                p1.status_stavki = "Выиграл";
                                List<USER> prt2 = connect.Users.ToList();
                                foreach (var p in prt2)
                                {
                                    if (gn == p.GameN)
                                    {
                                        p.balanc_user = p.balanc_user + Convert.ToInt32(float.Parse(p1.kf_stavki) * Convert.ToInt32(p1.summa_stavki));
                                        connect.SaveChanges();
                                    }
                                }
                            }




                        }
                    }
                }
            }
        }
        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
           
        }
        void timer_Tick(object sender, EventArgs e)
        {
            vremya.Content = DateTime.Now.ToString("dd MMMM yyyy\n    HH:mm:ss");

        }
        private void Window_Activated(object sender, EventArgs e)
        {
            bbbb.Visibility = Visibility.Hidden;

            l1_Copy.Visibility = Visibility.Visible;
            l1_Copy1.Visibility = Visibility.Visible;
            l1_Copy2.Visibility = Visibility.Visible;
            l1_Copy3.Visibility = Visibility.Visible;
            l1_Copy4.Visibility = Visibility.Visible;
            l1_Copy5.Visibility = Visibility.Visible;
            
            l1.Visibility = Visibility.Hidden;
            l2.Visibility = Visibility.Hidden;
            l3.Visibility = Visibility.Hidden;
            l4.Visibility = Visibility.Hidden;
            Show_historyAll(gn);
            using (var connect = new Connect())
            {

                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.GameN == gn)
                    {
                        lll.Content = Convert.ToInt32(p.balanc_user);
                        llll.Content = Convert.ToInt32(p.balanc_user);
                        
                    }

                }
            }
           
        }
       

        private void sportB_MouseEnter(object sender, MouseEventArgs e)
        {
            sportlist.Visibility = Visibility.Visible;
            sportB.Visibility = Visibility.Visible;
        }

        private void sportB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sport.IsFocused != true)
            {
                sportlist.Visibility = Visibility.Hidden;
                sportB.Visibility = Visibility.Hidden;
            }
        
        }

        private void sport_MouseEnter(object sender, MouseEventArgs e)
        {
            sportlist.Visibility = Visibility.Visible;
            sportB.Visibility = Visibility.Visible;
        }
     private void sport_MouseLeave(object sender, MouseEventArgs e)
        {
            if(sportB.IsFocused!=true)
            {
                sportlist.Visibility = Visibility.Hidden;
                sportB.Visibility = Visibility.Hidden;
            }
        }

        private void sportlist_MouseEnter(object sender, MouseEventArgs e)
        {
            sportlist.Visibility = Visibility.Visible;
            sportB.Visibility = Visibility.Visible;
        }

        private void sportlist_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sportB.IsFocused != true & sport.IsFocused)
            {
                sportlist.Visibility = Visibility.Hidden;
                sportB.Visibility = Visibility.Hidden;
            }
        }

        private void cyberlist_MouseEnter(object sender, MouseEventArgs e)
        {
            cyberlist.Visibility = Visibility.Visible;
            cyberB.Visibility = Visibility.Visible;
        }

        private void cyberlist_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sportB.IsFocused != true & sport.IsFocused)
            {
                cyberlist.Visibility = Visibility.Hidden;
                cyberB.Visibility = Visibility.Hidden;
            }
        }

        private void cyberB_MouseEnter(object sender, MouseEventArgs e)
        {
          
            cyberlist.Visibility = Visibility.Visible;
            cyberB.Visibility = Visibility.Visible;
        }

        private void cyberB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sport.IsFocused != true)
            {
                cyberlist.Visibility = Visibility.Hidden;
                cyberB.Visibility = Visibility.Hidden;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            
            cyberlist.Visibility = Visibility.Visible;
            cyberB.Visibility = Visibility.Visible;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sportB.IsFocused != true)
            {
                cyberlist.Visibility = Visibility.Hidden;
                cyberB.Visibility = Visibility.Hidden;
            }
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            sportlist.Visibility = Visibility.Hidden;
            sportB.Visibility = Visibility.Hidden;
            cyberlist.Visibility = Visibility.Hidden;
            cyberB.Visibility = Visibility.Hidden;
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
           this.Close();
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bbbb.Visibility = Visibility.Visible;
            Window9 win = new Window9(gn, bl);
            win.ShowDialog();
        }

        private void Button_Click_3_1(object sender, RoutedEventArgs e)
        {

            bbbb.Visibility = Visibility.Visible;
            Window7 win = new Window7(gn,bl);
            win.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }

        private void Label_Initialized(object sender, EventArgs e)
        {

        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            bbbb.Visibility = Visibility.Visible;
            Window11 win = new Window11(gn);
            win.ShowDialog();
        }
        private void Show_tranz(int i)
        {
            using (var connect = new Connect())
            {
                List<HistoryFinansy> prt = connect.historyFinansies.ToList();
                prt.Sort((a, b) => b.vremya.CompareTo(a.vremya));
                panel_Images.Children.Clear();
               
    
                foreach (var p in prt)
                {
                    if (p.gameNumber == i)
                    {
                        Button b = new Button();

                        Button c = new Button();
                        Button d = new Button();
                        Button e = new Button();
                        StackPanel c1 = new StackPanel();

                        c1.Width = 1500;
                        c1.Orientation = Orientation.Horizontal;
                        b.Width = 360;
                        b.Height = 40;
                        c.Width = 250;
                        c.Height = 40;
                        d.Width = 428;
                        d.Height = 40;
                        e.Width = 320;
                        e.Height = 40;
  
                        b.FontFamily = new FontFamily("Yu Gothic UI Light");
                        c.FontFamily = new FontFamily("Yu Gothic UI Light");
                        d.FontFamily = new FontFamily("Yu Gothic UI Light");
                        e.FontFamily = new FontFamily("Yu Gothic UI Light");
                        b.Content = p.vremya;
                        c.Content = p.nomercard;
                        d.Content = p.vid_popolnenia;
                        e.Content = p.sum;
                        b.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        c.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        d.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        e.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                       
                        b.BorderBrush.Opacity = 0.1;
                        c.BorderBrush.Opacity = 0.1;
                        d.BorderBrush.Opacity = 0.1;
                        e.BorderBrush.Opacity = 0.1;
                       
                        b.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        c.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        d.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        e.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        
                        b.Opacity = 0.7;
                        c.Opacity = 0.7;
                        d.Opacity = 0.7;
                        e.Opacity = 0.7;
                        
                        b.HorizontalContentAlignment = HorizontalAlignment.Center;
                        c.HorizontalContentAlignment = HorizontalAlignment.Center;
                        d.HorizontalContentAlignment = HorizontalAlignment.Center;
                        e.HorizontalContentAlignment = HorizontalAlignment.Center;
                       
                        b.FontSize = 20;
                        c.FontSize = 20;
                        d.FontSize = 20;
                        e.FontSize = 20;
                       
                        c1.Children.Add(b);
                        c1.Children.Add(c);
                        c1.Children.Add(d);
                        c1.Children.Add(e);
                       
                        panel_Images.Children.Add(c1);
                    }

                }
            }
        }
        private void Show_historyAll(int i)
        {
            using (var connect = new Connect())
            {
                List<HistoryStavok> prt = connect.historyStavoks.ToList();
                prt.Sort((b1, a1) => Convert.ToDateTime(a1.vremya_stavki).CompareTo(Convert.ToDateTime(b1.vremya_stavki)));

                panel_Images.Children.Clear();


                foreach (var p in prt)
                {
                    if (p.autor_stavki == i)
                    {
                        Button b = new Button();
                        Button c = new Button();
                        Button d = new Button();
                        Button e = new Button();
                        Button f = new Button();
                        Button g = new Button();
                        StackPanel c1 = new StackPanel();
                        
                        c1.Width = 1500;
                        c1.Orientation = Orientation.Horizontal;
                        b.Width = 200;
                        b.Height = 40;
                        c.Width = 415;
                        c.Height = 40;
                        d.Width = 210;
                        d.Height = 40;
                        e.Width = 160;
                        e.Height = 40;
                        f.Width = 138;
                        f.Height = 40;
                        g.Width = 235;
                        g.Height = 40;
                        
                        b.FontFamily = new FontFamily("Yu Gothic UI Light");
                        c.FontFamily = new FontFamily("Yu Gothic UI Light");
                        d.FontFamily = new FontFamily("Yu Gothic UI Light");
                        e.FontFamily = new FontFamily("Yu Gothic UI Light");
                        f.FontFamily = new FontFamily("Yu Gothic UI Light");
                        g.FontFamily = new FontFamily("Yu Gothic UI Light");
                       

                       
                            b.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            c.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            d.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            e.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            f.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            g.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        
                        b.Content = p.vremya_stavki;
                        c.Content = p.name_stavki;
                        d.Content = p.vibor_stavki;
                        e.Content = p.kf_stavki;
                        f.Content = p.summa_stavki;
                        g.Content = p.status_stavki;
                        
                        b.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        c.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        d.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        e.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        f.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        g.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        b.BorderBrush.Opacity = 0.1;
                        c.BorderBrush.Opacity = 0.1;
                        d.BorderBrush.Opacity = 0.1;
                        e.BorderBrush.Opacity = 0.1;
                        f.BorderBrush.Opacity = 0.1;
                        g.BorderBrush.Opacity = 0.1;
                        b.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        c.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        d.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        e.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        f.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        g.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        b.Opacity = 0.7;
                        c.Opacity = 0.7;
                        d.Opacity = 0.7;
                        e.Opacity = 0.7;
                        f.Opacity = 0.7;
                        g.Opacity = 0.7;
                        b.HorizontalContentAlignment = HorizontalAlignment.Center;
                        c.HorizontalContentAlignment = HorizontalAlignment.Center;
                        d.HorizontalContentAlignment = HorizontalAlignment.Center;
                        e.HorizontalContentAlignment = HorizontalAlignment.Center;
                        f.HorizontalContentAlignment = HorizontalAlignment.Center;
                        g.HorizontalContentAlignment = HorizontalAlignment.Center;
                        b.FontSize = 20;
                        c.FontSize = 20;
                        d.FontSize = 20;
                        e.FontSize = 20;
                        f.FontSize = 20;
                        g.FontSize = 20;
                        c1.Children.Add(b);
                        c1.Children.Add(c);
                        c1.Children.Add(d);
                        c1.Children.Add(e);
                        c1.Children.Add(f);
                        c1.Children.Add(g);
                        panel_Images.Children.Add(c1);
                       
                        
                       
                    }

                }
            }
        }
        private void Show_historyActiv(int i)
        {
            using (var connect = new Connect())
            {
                List<HistoryStavok> prt = connect.historyStavoks.ToList();
                prt.Sort((b1, a1) => Convert.ToDateTime(a1.vremya_stavki).CompareTo(Convert.ToDateTime(b1.vremya_stavki)));

                panel_Images.Children.Clear();


                foreach (var p in prt)
                {
                    if (p.autor_stavki == i & p.status_stavki == "В игре")
                    {
                        
                        Button b = new Button();
                        Button c = new Button();
                        Button d = new Button();
                        Button e = new Button();
                        Button f = new Button();
                        Button g = new Button();
                        StackPanel c1 = new StackPanel();

                        c1.Width = 1500;
                        c1.Orientation = Orientation.Horizontal;
                        b.Width = 200;
                        b.Height = 40;
                        c.Width = 415;
                        c.Height = 40;
                        d.Width = 210;
                        d.Height = 40;
                        e.Width = 160;
                        e.Height = 40;
                        f.Width = 138;
                        f.Height = 40;
                        g.Width = 235;
                        g.Height = 40;

                        b.FontFamily = new FontFamily("Yu Gothic UI Light");
                        c.FontFamily = new FontFamily("Yu Gothic UI Light");
                        d.FontFamily = new FontFamily("Yu Gothic UI Light");
                        e.FontFamily = new FontFamily("Yu Gothic UI Light");
                        f.FontFamily = new FontFamily("Yu Gothic UI Light");
                        g.FontFamily = new FontFamily("Yu Gothic UI Light");


                        if (p.status_stavki == "Выигрыш")
                        {
                            b.Foreground = new SolidColorBrush(Color.FromRgb(108, 187, 95));
                            c.Foreground = new SolidColorBrush(Color.FromRgb(108, 187, 95));
                            d.Foreground = new SolidColorBrush(Color.FromRgb(108, 187, 95));
                            e.Foreground = new SolidColorBrush(Color.FromRgb(108, 187, 95));
                            f.Foreground = new SolidColorBrush(Color.FromRgb(108, 187, 95));
                            g.Foreground = new SolidColorBrush(Color.FromRgb(108, 187, 95));
                        }
                        else if (p.status_stavki == "Проигрыш")
                        {
                            b.Foreground = new SolidColorBrush(Color.FromRgb(201, 78, 78));
                            c.Foreground = new SolidColorBrush(Color.FromRgb(201, 78, 78));
                            d.Foreground = new SolidColorBrush(Color.FromRgb(201, 78, 78));
                            e.Foreground = new SolidColorBrush(Color.FromRgb(201, 78, 78));
                            f.Foreground = new SolidColorBrush(Color.FromRgb(201, 78, 78));
                            g.Foreground = new SolidColorBrush(Color.FromRgb(201, 78, 78));

                        }
                        else
                        {
                            b.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            c.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            d.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            e.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            f.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            g.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));

                        }
                        b.Content = p.vremya_stavki;
                        c.Content = p.name_stavki;
                        d.Content = p.vibor_stavki;
                        e.Content = p.kf_stavki;
                        f.Content = p.summa_stavki;
                        g.Content = p.status_stavki;

                        b.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

                        c.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        d.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        e.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        f.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        g.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        b.BorderBrush.Opacity = 0.1;
                        c.BorderBrush.Opacity = 0.1;
                        d.BorderBrush.Opacity = 0.1;
                        e.BorderBrush.Opacity = 0.1;
                        f.BorderBrush.Opacity = 0.1;
                        g.BorderBrush.Opacity = 0.1;
                        b.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        c.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        d.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        e.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        f.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        g.Background = new SolidColorBrush(Color.FromRgb(25, 11, 35));
                        b.Opacity = 0.7;
                        c.Opacity = 0.7;
                        d.Opacity = 0.7;
                        e.Opacity = 0.7;
                        f.Opacity = 0.7;
                        g.Opacity = 0.7;
                        b.HorizontalContentAlignment = HorizontalAlignment.Center;
                        c.HorizontalContentAlignment = HorizontalAlignment.Center;
                        d.HorizontalContentAlignment = HorizontalAlignment.Center;
                        e.HorizontalContentAlignment = HorizontalAlignment.Center;
                        f.HorizontalContentAlignment = HorizontalAlignment.Center;
                        g.HorizontalContentAlignment = HorizontalAlignment.Center;
                        b.FontSize = 20;
                        c.FontSize = 20;
                        d.FontSize = 20;
                        e.FontSize = 20;
                        f.FontSize = 20;
                        g.FontSize = 20;
                        c1.Children.Add(b);
                        c1.Children.Add(c);
                        c1.Children.Add(d);
                        c1.Children.Add(e);
                        c1.Children.Add(f);
                        c1.Children.Add(g);
                        panel_Images.Children.Add(c1);


                    }

                }
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            l1_Copy.Visibility = Visibility.Hidden;
            l1_Copy1.Visibility = Visibility.Hidden;
            l1_Copy2.Visibility = Visibility.Hidden;
            l1_Copy3.Visibility = Visibility.Hidden;
            l1_Copy4.Visibility = Visibility.Hidden;
            l1_Copy5.Visibility = Visibility.Hidden;
           
            l1.Visibility = Visibility.Visible;
            l2.Visibility = Visibility.Visible;
            l3.Visibility = Visibility.Visible;
            l4.Visibility = Visibility.Visible;
            Show_tranz(gn);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            l1_Copy.Visibility = Visibility.Visible;
            l1_Copy1.Visibility = Visibility.Visible;
            l1_Copy2.Visibility = Visibility.Visible;
            l1_Copy3.Visibility = Visibility.Visible;
            l1_Copy4.Visibility = Visibility.Visible;
            l1_Copy5.Visibility = Visibility.Visible;
            l1.Visibility = Visibility.Hidden;
            l2.Visibility = Visibility.Hidden;
            l3.Visibility = Visibility.Hidden;
            l4.Visibility = Visibility.Hidden;
            Show_historyAll(gn);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            l1_Copy.Visibility = Visibility.Visible;
            l1_Copy1.Visibility = Visibility.Visible;
            l1_Copy2.Visibility = Visibility.Visible;
            l1_Copy3.Visibility = Visibility.Visible;
            l1_Copy4.Visibility = Visibility.Visible;
            l1_Copy5.Visibility = Visibility.Visible;
            l1.Visibility = Visibility.Hidden;
            l2.Visibility = Visibility.Hidden;
            l3.Visibility = Visibility.Hidden;
            l4.Visibility = Visibility.Hidden;
            Show_historyActiv(gn);
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            glavnoeWindow w = new glavnoeWindow(gn,bl);
            w.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Window5 w = new Window5(gn,bl);
            w.Show();
            this.Close();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            using (var connect = new Connect())
            {

                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.GameN == gn)
                    {
                        lll.Content = p.balanc_user;
                        llll.Content = p.balanc_user;
                    }

                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Футбол");
            a.Show();
            this.Close();

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Теннис");
            a.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Баскетбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Хоккей");
            a.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

            WindowSport a = new WindowSport(gn, bl, "Волейбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "UFC");
            a.Show();
            this.Close();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Австралийский футбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Американский футбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бадбинтон");
            a.Show();
            this.Close();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бейсбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бильярд");
            a.Show();
            this.Close();
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бокс");
            a.Show();
            this.Close();
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Водное поло");
            a.Show();
            this.Close();
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Гандбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Дартс");
            a.Show();
            this.Close();
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Единаборства");
            a.Show();
            this.Close();
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Настольный теннис");
            a.Show();
            this.Close();
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Регби");
            a.Show();
            this.Close();
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Флорбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Футзал");
            a.Show();
            this.Close();
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "CS:GO");
            a.Show();
            this.Close();
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "DOTA 2");
            a.Show();
            this.Close();
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "LoL");
            a.Show();
            this.Close();
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Valorant");
            a.Show();
            this.Close();
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "FIFA");
            a.Show();
            this.Close();
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "CoL");
            a.Show();
            this.Close();
        }

        private void sport_Copy_Click(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, 1);
            a.Show();
            this.Close();
        }

        private void cyber_Copy_Click(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, 2);
            a.Show();
            this.Close();
        }
    }
}
