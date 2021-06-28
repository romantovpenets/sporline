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
    public partial class glavnoeWindow : Window
    {
        int gn = 0;
        float bl = 0;
        

        public glavnoeWindow(int a, float b)
        {

            InitializeComponent();

            











            b = Convert.ToInt32(b);
            gn = a;
            using (var connect = new Connect())
            {
                List<USER> prt1 = connect.Users.ToList();
                foreach (var p1 in prt1)
                {
                    if (gn == p1.GameN)
                    {
                        bl = p1.balanc_user;
                        lll.Content = Convert.ToInt32(b);
                    }
                }
            }

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            ll.Content = a;

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
                        
                        if((stavka-noww).TotalHours<-1)
                        {
                            Random rnd = new Random();
                            int chh = rnd.Next(1, 101);
                            int raznica = Convert.ToInt32(100.0 / Convert.ToDouble(p1.kf_stavki));
                            if(chh>raznica)
                            {
                                p1.status_stavki = "Проиграл";
                                connect.SaveChanges();
                            }
                            else
                            {
                                p1.status_stavki = "Выиграл";
                                List<USER> prt2 = connect.Users.ToList();
                                foreach(var p in prt2)
                                {
                                    if(gn==p.GameN)
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
            using (var connect = new Connect())
            {
                List<HistoryStavok> prt1 = connect.historyStavoks.ToList();
                prt1.Sort((b1, a1) => Convert.ToInt32(a1.summa_stavki).CompareTo(Convert.ToInt32(b1.summa_stavki)));


                Label[] sob = new Label[3] { sob1, sob2, sob3 };
                Label[] st = new Label[3] { st1, st2, st3 };
                Label[] kf = new Label[3] { kf1, kf2, kf3 };
                Label[] summa = new Label[3] { summa1, summa2, summa3 };
                int i = 0;
                foreach (var p1 in prt1)
                {
                    if (p1.status_stavki == "Выиграл")
                    {
                        sob[i].Content = p1.name_stavki;
                        st[i].Content = p1.vibor_stavki;
                        kf[i].Content = p1.kf_stavki;
                        summa[i].Content = Convert.ToInt32(p1.summa_stavki) * float.Parse(p1.kf_stavki);
                    }

                    if (i == 2)
                    {
                        break;
                    }
                    i++;
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
            using (var connect = new Connect())
            {

                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.GameN == gn)
                    {
                        lll.Content = Convert.ToInt32(p.balanc_user);
                        bl = Convert.ToInt32(p.balanc_user);
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
            if (sportB.IsFocused != true)
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
        private void sport_Copy_Click(object sender, RoutedEventArgs e)
        {
            WindowSport window = new WindowSport(gn,bl,1);
            window.Show();
            this.Close();
        }

        private void cyber_Copy_Click(object sender, RoutedEventArgs e)
        {
            WindowSport window = new WindowSport(gn, bl,2);
            window.Show();
            this.Close();
        }

     
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window5 w = new Window5(gn, bl);
            w.Show();
            this.Close();
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            glavnoeWindow w = new glavnoeWindow(gn, bl);
            w.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            r1.Visibility = Visibility.Hidden;
            r2.Visibility = Visibility.Visible;
            b1.Visibility = Visibility.Hidden;
            b1_1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Visible;
            b2_2.Visibility = Visibility.Visible;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            r3.Visibility = Visibility.Hidden;
            r1.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Hidden;
            b3_3.Visibility = Visibility.Hidden;
            b1.Visibility = Visibility.Visible;
            b1_1.Visibility = Visibility.Visible;
        }

        private void b3_3_Click(object sender, RoutedEventArgs e)
        {
            r3.Visibility = Visibility.Hidden;
            r2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Hidden;
            b3_3.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Visible;
            b2_2.Visibility = Visibility.Visible;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            r2.Visibility = Visibility.Hidden;
            r3.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Hidden;
            b2_2.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Visible;
            b3_3.Visibility = Visibility.Visible;
        }

        private void b2_2_Click(object sender, RoutedEventArgs e)
        {
            r2.Visibility = Visibility.Hidden;
            r1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Hidden;
            b2_2.Visibility = Visibility.Hidden;
            b1.Visibility = Visibility.Visible;
            b1_1.Visibility = Visibility.Visible;
        }

        private void b1_1_Click(object sender, RoutedEventArgs e)
        {
            r1.Visibility = Visibility.Hidden;
            r3.Visibility = Visibility.Visible;
            b1.Visibility = Visibility.Hidden;
            b1_1.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Visible;
            b3_3.Visibility = Visibility.Visible;
        }

        private void s1_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
        {
            e.Handled = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bbbb.Visibility = Visibility.Visible;
            WindowSlott w = new WindowSlott(gn,bl);
            w.ShowDialog();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            bbbb.Visibility = Visibility.Visible;
            whellWin w = new whellWin(gn,bl);
            w.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Футбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Теннис");
            a.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Баскетбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Хоккей");
            a.Show();
            this.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Волейбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "UFC");
            a.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Австралийский футбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Американский футбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бадбинтон");
            a.Show();
            this.Close();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бейсбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бильярд");
            a.Show();
            this.Close();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бокс");
            a.Show();
            this.Close();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Водное поло");
            a.Show();
            this.Close();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Гандбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Дартс");
            a.Show();
            this.Close();
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Единаборства");
            a.Show();
            this.Close();
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Настольный теннис");
            a.Show();
            this.Close();
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Регби");
            a.Show();
            this.Close();
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Флорбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Футзал");
            a.Show();
            this.Close();
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "CS:GO");
            a.Show();
            this.Close();
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "DOTA 2");
            a.Show();
            this.Close();
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {

            WindowSport a = new WindowSport(gn, bl, "LoL");
            a.Show();
            this.Close();
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Valorant");
            a.Show();
            this.Close();
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "CoL");
            a.Show();
            this.Close();
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "FIFA");
            a.Show();
            this.Close();
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Букмекерская контора — это игорное заведение, занимающееся приемом ставок. Букмекер оценивает вероятность того или иного исхода события и на каждый из возможных исходов выставляет коэффициент — числовое значение, на которое умножается ставка в случае успеха. Главное направление работы большинства букмекерских контор — прием ставок на спортивные события.При этом количество предлагаемых для ставок видов спорта может достигать 30 и включать в себя не только популярные футбол, теннис, баскетбол и хоккей, но и что - то более «экзотичное» вроде гольфа, дартса или крикета.Ставками на спорт все не ограничивается: некоторые букмекерские конторы предлагают угадать исход знаковых событий в том числе из мира политики и культуры. Какие ставки на спорт предлагают букмекеры Для того чтобы получить выигрыш в букмекерской конторе, необходимо сделать ставку на любой из предлагаемых результатов, который в итоге окажется верным. Букмекеры предлагают разнообразные результаты событий и большое многообразие видов ставок.Так, в футбольном матче можно сделать ставку на победу той или иной команды(ставки на исход), на суммарное количество голов в матче или же на количество голов одной команды(ставки на тотал), на разницу мячей(ставки с форой).Тоталы очков, геймов и заброшенных шайб имеют место в баскетболе, теннисе и хоккее соответственно. В целом же круг результатов, доступных для ставок, достаточно широк, о других видах ставок можно прочитать в других статьях нашей Школы Ставок. Кроме того, игрок букмекерской конторы может делать ставки на конкретное событие как до его начала(pre - match), так и по ходу игры(live).В случае с live - ставками важна скорость принятия решений, ведь котировки меняются гораздо быстрее в зависимости от хода матча, текущего результата и времени до окончания встречи. Совокупность предлагаемых событий со всем исходами и соответствующими им коэффициентами называется букмекерской линией.Так что все возможные ставки до игры стоит искать в разделе «линия» на сайте букмекера. Каждому конкретному исходу в линии букмекерская контора присваивает коэффициент, который и определяет размер предполагаемого выигрыша. Размер выплаты, которую игрок получит от букмекера в случае выигрыша ставки, определить несложно: достаточно просто умножить поставленную сумму на коэффициент. Обратите внимание, что размер выплаты и прибыль по ставке — это не одно и то же! Чтобы определить прибыль, необходимо от суммы выплаты отнять размер своей ставки — так мы получим сумму чистой прибыли, которую принесла выигравшая ставка.");

      }
    }
}
