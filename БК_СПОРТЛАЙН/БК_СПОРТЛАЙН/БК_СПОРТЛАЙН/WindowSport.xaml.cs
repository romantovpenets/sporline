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

namespace БК_СПОРТЛАЙН
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class WindowSport : Window
    {
        string vid = "";
        int ccount = 0;
        int gn = 0;
        float bl = 0;
        int ch = 0;
        int nomer = 0;
        public WindowSport(int a, float b, int c)
        {
            
            InitializeComponent();
            b = Convert.ToInt32(b);
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += timer_Tick;
            timer.Start();
            bl = b;
            gn = a;

            ll.Content = a;
            lll.Content = b;

            Grid[] gr = new Grid[10] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            for (int i1 = 0; i1 < 10; i1++)
            {
                gr[i1].Visibility = Visibility.Hidden;
            }
            Label[] lbVremya = new Label[10] { vremya1, vremya2, vremya3, vremya4, vremya5, vremya6, vremya7, vremya8, vremya9, vremya10 };
            Label[] lbTeamOne = new Label[10] { teamOneP1, teamOneP2, teamOneP3, teamOneP4, teamOneP5, teamOneP6, teamOneP7, teamOneP8, teamOneP9, teamOneP10 };
            Label[] lbTeamTwo = new Label[10] { teamTwoP1, teamTwoP2, teamTwoP3, teamTwoP4, teamTwoP5, teamTwoP6, teamTwoP7, teamTwoP8, teamTwoP9, teamTwoP10 };
            Label[] kfP1 = new Label[10] { KfPOne1, KfPOne2, KfPOne3, KfPOne4, KfPOne5, KfPOne6, KfPOne7, KfPOne8, KfPOne9, KfPOne10 };
            Label[] kfPX = new Label[10] { KfPNikto1, KfPNikto2, KfPNikto3, KfPNikto4, KfPNikto5, KfPNikto6, KfPNikto7, KfPNikto8, KfPNikto9, KfPNikto10 };
            Label[] kbP2 = new Label[10] { KfPTwo1, KfPTwo2, KfPTwo3, KfPTwo4, KfPTwo5, KfPTwo6, KfPTwo7, KfPTwo8, KfPTwo9, KfPTwo10 };

            nomer = c;
            using (var connect = new Connect())
            {
                if (c == 1)
                {
                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                    int count = 0;
                    foreach (var p in prt)
                    {

                        if (p.vid_sport != "DOTA 2" & p.vid_sport != "LoL" & p.vid_sport != "CS:GO" & p.vid_sport != "CoL" & p.vid_sport != "Valorant" & p.vid_sport != "FIFA")
                        {
                            count++;
                        }

                    }
                    if (count > 10)
                    {
                        count = 10;
                    }
                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;

                    foreach (var p in prt)
                    {
                        if (p.vid_sport !="DOTA 2" & p.vid_sport != "LoL" & p.vid_sport != "CS:GO" & p.vid_sport != "CoL" & p.vid_sport != "Valorant" & p.vid_sport != "FIFA" )
                        {

                            if (ccc < ccount + 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                            ccc++;
                        }
                    }
                    ccount = ccount + 10;
                }
                else if (c==2)
                {
                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                    int count = 0;
                    foreach (var p in prt)
                    {

                        if (p.vid_sport == "DOTA 2" | p.vid_sport == "LoL" | p.vid_sport == "CS:GO" | p.vid_sport == "CoL" | p.vid_sport == "Valorant" | p.vid_sport == "FIFA")
                        {
                            count++;
                        }

                    }
                    if (count > 10)
                    {
                        count = 10;
                    }
                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;

                    foreach (var p in prt)
                    {
                        if (p.vid_sport == "DOTA 2" | p.vid_sport == "LoL" | p.vid_sport == "CS:GO" | p.vid_sport == "CoL" | p.vid_sport == "Valorant" | p.vid_sport == "FIFA")
                        {

                            if (ccc < ccount + 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                            ccc++;
                        }
                    }
                    ccount = ccount + 10;
                }
               
            }


        }
        public WindowSport(int a, float b, string c)
        {
            
            InitializeComponent();
            vid = c;
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += timer_Tick;
            timer.Start();
            bl = b;
            gn = a;

            ll.Content = a;
            lll.Content = b;

            Grid[] gr = new Grid[10] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            for (int i1 = 0; i1 < 10; i1++)
            {
                gr[i1].Visibility = Visibility.Hidden;
            }
            Label[] lbVremya = new Label[10] { vremya1, vremya2, vremya3, vremya4, vremya5, vremya6, vremya7, vremya8, vremya9, vremya10 };
            Label[] lbTeamOne = new Label[10] { teamOneP1, teamOneP2, teamOneP3, teamOneP4, teamOneP5, teamOneP6, teamOneP7, teamOneP8, teamOneP9, teamOneP10 };
            Label[] lbTeamTwo = new Label[10] { teamTwoP1, teamTwoP2, teamTwoP3, teamTwoP4, teamTwoP5, teamTwoP6, teamTwoP7, teamTwoP8, teamTwoP9, teamTwoP10 };
            Label[] kfP1 = new Label[10] { KfPOne1, KfPOne2, KfPOne3, KfPOne4, KfPOne5, KfPOne6, KfPOne7, KfPOne8, KfPOne9, KfPOne10 };
            Label[] kfPX = new Label[10] { KfPNikto1, KfPNikto2, KfPNikto3, KfPNikto4, KfPNikto5, KfPNikto6, KfPNikto7, KfPNikto8, KfPNikto9, KfPNikto10 };
            Label[] kbP2 = new Label[10] { KfPTwo1, KfPTwo2, KfPTwo3, KfPTwo4, KfPTwo5, KfPTwo6, KfPTwo7, KfPTwo8, KfPTwo9, KfPTwo10 };


            using (var connect = new Connect())
            {

                List<stavka> prt = connect.staavki.ToList();
                prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                int count = 0;
                foreach (var p in prt)
                {

                    if (p.vid_sport == vid)
                    {
                        count++;
                    }

                }
                if (count > 10)
                {
                    count = 10;
                }
                for (int i1 = 0; i1 < count; i1++)
                {
                    gr[i1].Visibility = Visibility.Visible;
                }
                int i = 0;
                int ccc = 0;
                foreach (var p in prt)
                {
                    if (c == p.vid_sport)
                    {

                        if (ccc < ccount + 10)
                        {
                            lbVremya[i].Content = p.vremya;
                            lbTeamOne[i].Content = p.nameT1;
                            lbTeamTwo[i].Content = p.nameT2;
                            kfP1[i].Content = p.kfP1;
                            kfPX[i].Content = p.kfX;
                            kbP2[i].Content = p.kfP2;
                            i++;

                        }
                        ccc++;
                    }
                }
                ccount = ccount + 10;
            }


        }
        

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            bluuur.Visibility = Visibility.Hidden;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            vremya.Content = DateTime.Now.ToString("dd MMMM yyyy\n    HH:mm:ss");

        }
        void timer_Tick1(object sender, EventArgs e)
        {
            vremya.Content = DateTime.Now.ToString("dd MMMM yyyy\n    HH:mm:ss");

        }
        private void Window_Activated(object sender, EventArgs e)
        {
            bluuur.Visibility = Visibility.Hidden;
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

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Label_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
            Grid[] gr = new Grid[10] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            
            Label[] lbVremya = new Label[10] { vremya1, vremya2, vremya3, vremya4, vremya5, vremya6, vremya7, vremya8, vremya9, vremya10 };
            Label[] lbTeamOne = new Label[10] { teamOneP1, teamOneP2, teamOneP3, teamOneP4, teamOneP5, teamOneP6, teamOneP7, teamOneP8, teamOneP9, teamOneP10 };
            Label[] lbTeamTwo = new Label[10] { teamTwoP1, teamTwoP2, teamTwoP3, teamTwoP4, teamTwoP5, teamTwoP6, teamTwoP7, teamTwoP8, teamTwoP9, teamTwoP10 };
            Label[] kfP1 = new Label[10] { KfPOne1, KfPOne2, KfPOne3, KfPOne4, KfPOne5, KfPOne6, KfPOne7, KfPOne8, KfPOne9, KfPOne10 };
            Label[] kfPX = new Label[10] { KfPNikto1, KfPNikto2, KfPNikto3, KfPNikto4, KfPNikto5, KfPNikto6, KfPNikto7, KfPNikto8, KfPNikto9, KfPNikto10 };
            Label[] kbP2 = new Label[10] { KfPTwo1, KfPTwo2, KfPTwo3, KfPTwo4, KfPTwo5, KfPTwo6, KfPTwo7, KfPTwo8, KfPTwo9, KfPTwo10 };
            if (nomer==1)
            {
                using (var connect = new Connect())
                {

                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya))); 
                    int count = 0;
                    foreach (var p in prt)
                    {

                        if (p.vid_sport != "DOTA 2" & p.vid_sport != "LoL" & p.vid_sport != "CS:GO" & p.vid_sport != "CoL" & p.vid_sport != "Valorant" & p.vid_sport != "FIFA")
                        {
                            count++;
                        }

                    }
                    count = count - ccount;
                    if (count < 1)
                    {
                        goto aa;
                    }
                    ch++;
                    

                    if (count == 0)
                    {

                        goto aa;
                    }
                    for (int i1 = 0; i1 < 10; i1++)
                    {
                        gr[i1].Visibility = Visibility.Hidden;
                    }
                    if (count > 10)
                    {
                        count = 10;
                    }

                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;
                    foreach (var p in prt)
                    {

                        if (p.vid_sport != "DOTA 2" & p.vid_sport != "LoL" & p.vid_sport != "CS:GO" & p.vid_sport != "CoL" & p.vid_sport != "Valorant" & p.vid_sport != "FIFA")
                        {
                            if (ccc >= ccount & ccc < ccount + 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                             ccc++;
                        }
                       
                    }
                    ccount = ccount + 10;
                aa:;

                }
            }
            else if(nomer==2)
            {
                using (var connect = new Connect())
                {

                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                    int count = 0;
                    foreach (var p in prt)
                    {

                        if (p.vid_sport == "DOTA 2" | p.vid_sport == "LoL" | p.vid_sport == "CS:GO" | p.vid_sport == "CoL" | p.vid_sport == "Valorant" | p.vid_sport == "FIFA")
                        {
                            count++;
                        }


                    }
                    count = count - ccount;
                    if (count < 1)
                    {
                        goto aa;
                    }
                    ch++;


                    if (count == 0)
                    {

                        goto aa;
                    }
                    for (int i1 = 0; i1 < 10; i1++)
                    {
                        gr[i1].Visibility = Visibility.Hidden;
                    }
                    if (count > 10)
                    {
                        count = 10;
                    }

                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;
                    foreach (var p in prt)
                    {

                        if (p.vid_sport == "DOTA 2" | p.vid_sport == "LoL" | p.vid_sport == "CS:GO" | p.vid_sport == "CoL" | p.vid_sport == "Valorant" | p.vid_sport == "FIFA")
                        {
                            if (ccc >= ccount & ccc < ccount + 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;
                            }
                            ccc++;
                        }
                        
                    }
                    ccount = ccount + 10;
                aa:;

                }
            }
            else
            {
                
                
                using (var connect = new Connect())
                {
                    
                   
                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                    int count = 0;
                    foreach(var p in prt)
                    {
                        if(p.vid_sport==vid)
                        {
                            count++;
                        }
                    }
                    count = count - ccount;
                    if (count < 1)
                    {
                        goto aa;
                    }
                    ch++;
                    foreach (var p in prt)
                    {

                    }

                    if (count == 0)
                    {

                        goto aa;
                    }
                    for (int i1 = 0; i1 < 10; i1++)
                    {
                        gr[i1].Visibility = Visibility.Hidden;
                    }
                    if (count > 10)
                    {
                        count = 10;
                    }

                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;
                    foreach (var p in prt)
                    {
                        if (p.vid_sport == vid)
                        {
                            if (ccc >= ccount & ccc < ccount + 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                            ccc++;
                        }
                    }
                    ccount = ccount + 10;
                aa:;
                
                }
            }
        }

        private void Label_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Grid[] gr = new Grid[10] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };

            Label[] lbVremya = new Label[10] { vremya1, vremya2, vremya3, vremya4, vremya5, vremya6, vremya7, vremya8, vremya9, vremya10 };
            Label[] lbTeamOne = new Label[10] { teamOneP1, teamOneP2, teamOneP3, teamOneP4, teamOneP5, teamOneP6, teamOneP7, teamOneP8, teamOneP9, teamOneP10 };
            Label[] lbTeamTwo = new Label[10] { teamTwoP1, teamTwoP2, teamTwoP3, teamTwoP4, teamTwoP5, teamTwoP6, teamTwoP7, teamTwoP8, teamTwoP9, teamTwoP10 };
            Label[] kfP1 = new Label[10] { KfPOne1, KfPOne2, KfPOne3, KfPOne4, KfPOne5, KfPOne6, KfPOne7, KfPOne8, KfPOne9, KfPOne10 };
            Label[] kfPX = new Label[10] { KfPNikto1, KfPNikto2, KfPNikto3, KfPNikto4, KfPNikto5, KfPNikto6, KfPNikto7, KfPNikto8, KfPNikto9, KfPNikto10 };
            Label[] kbP2 = new Label[10] { KfPTwo1, KfPTwo2, KfPTwo3, KfPTwo4, KfPTwo5, KfPTwo6, KfPTwo7, KfPTwo8, KfPTwo9, KfPTwo10 };
            if (nomer==1)
            {
                using (var connect = new Connect())
                {
                    if (ch == 0)
                    {
                        goto aa;
                    }
                    ch--;
                    if (ccount == 10)
                    {
                        goto aa;
                    }
                    
                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));

                    for (int i1 = 0; i1 < 10; i1++)
                    {
                        gr[i1].Visibility = Visibility.Hidden;
                    }
                    int count = 10;

                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;

                    foreach (var p in prt)
                    {
                        if (p.vid_sport != "DOTA 2" & p.vid_sport != "LoL" & p.vid_sport != "CS:GO" & p.vid_sport != "CoL" & p.vid_sport != "Valorant" & p.vid_sport != "FIFA")
                        {
                            if (ccc >= ccount - 20 & ccc < ccount - 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                            ccc++;
                        }
                        
                    }
                    ccount = ccount - 10;
                aa:;

                }
            }
            else if (nomer==2)
            {
                using (var connect = new Connect())
                {
                    if (ch == 0)
                    {
                        goto aa;
                    }
                    ch--;
                    if (ccount == 10)
                    {
                        goto aa;
                    }

                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                    for (int i1 = 0; i1 < 10; i1++)
                    {
                        gr[i1].Visibility = Visibility.Hidden;
                    }
                    int count = 10;

                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;

                    foreach (var p in prt)
                    {
                        if (p.vid_sport == "DOTA 2" | p.vid_sport == "LoL" | p.vid_sport == "CS:GO" | p.vid_sport == "CoL" | p.vid_sport == "Valorant" | p.vid_sport == "FIFA")
                        {
                            if (ccc >= ccount - 20 & ccc < ccount - 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                            ccc++;
                        }

                    }
                    ccount = ccount - 10;
                aa:;

                }
            }
            else
            {
                using (var connect = new Connect())
                {
                    if (ccount == 10)
                    {
                        goto aa;
                    }
                    if (ch == 0)
                    {
                        goto aa;
                    }
                    ch--;
                    List<stavka> prt = connect.staavki.ToList();
                    prt.Sort((a1, b1) => Convert.ToDateTime(a1.vremya).CompareTo(Convert.ToDateTime(b1.vremya)));
                    for (int i1 = 0; i1 < 10; i1++)
                    {
                        gr[i1].Visibility = Visibility.Hidden;
                    }
                    int count = 10;

                    for (int i1 = 0; i1 < count; i1++)
                    {
                        gr[i1].Visibility = Visibility.Visible;
                    }
                    int i = 0;
                    int ccc = 0;

                    foreach (var p in prt)
                    {
                        if (p.vid_sport == vid)
                        {
                            if (ccc >= ccount - 20 & ccc < ccount - 10)
                            {
                                lbVremya[i].Content = p.vremya;
                                lbTeamOne[i].Content = p.nameT1;
                                lbTeamTwo[i].Content = p.nameT2;
                                kfP1[i].Content = p.kfP1;
                                kfPX[i].Content = p.kfX;
                                kbP2[i].Content = p.kfP2;
                                i++;

                            }
                            ccc++;
                        }

                    }
                    ccount = ccount - 10;
                aa:;

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Теннис");
            a.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Баскетбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Хоккей");
            a.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Волейбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "UFC");
            a.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Австралийский футбол");
            a.Show();
            this.Close();
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Американский футбол");
            a.Show();
            this.Close();
            
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бадбинтон");
            a.Show();
            this.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бейсбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бильярд");
            a.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Бокс");
            a.Show();
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
           
                WindowSport a = new WindowSport(gn, bl, "Водное поло");
            a.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Гандбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Дартс");
            a.Show();
            this.Close();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Единаборства");
            a.Show();
            this.Close();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Настольный теннис");
            a.Show();
            this.Close();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Регби");
            a.Show();
            this.Close();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Флорбол");
            a.Show();
            this.Close();
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Футзал");
            a.Show();
            this.Close();
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "CS:GO");
            a.Show();
            this.Close();
            
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "DOTA 2");
            a.Show();
            this.Close();
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "LoL");
            a.Show();
            this.Close();
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Valorant");
            a.Show();
            this.Close();
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "CoL");
            a.Show();
            this.Close();
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "FIFA");
            a.Show();
            this.Close();
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            WindowSport a = new WindowSport(gn, bl, "Футбол");
            a.Show();
            this.Close();
        }

        private void KfPTwo1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn,Convert.ToString(teamOneP1.Content), Convert.ToString(vremya1.Content), Convert.ToString(KfPTwo1.Content));
            w.ShowDialog();
        }

        private void KfPTwo2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn,Convert.ToString(teamOneP2.Content), Convert.ToString(vremya2.Content), Convert.ToString(KfPTwo2.Content));
            w.ShowDialog();
        }

        private void KfPTwo3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP3.Content), Convert.ToString(vremya3.Content), Convert.ToString(KfPTwo3.Content));
            w.ShowDialog();
        }

        private void KfPTwo4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP4.Content), Convert.ToString(vremya4.Content), Convert.ToString(KfPTwo4.Content));
            w.ShowDialog();
        }

        private void KfPTwo5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn,Convert.ToString(teamOneP5.Content), Convert.ToString(vremya5.Content), Convert.ToString(KfPTwo5));
            w.ShowDialog();
        }

        private void KfPTwo6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP6.Content), Convert.ToString(vremya6.Content), Convert.ToString(KfPTwo6.Content));
            w.ShowDialog();
        }

        private void KfPTwo7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP7.Content), Convert.ToString(vremya7.Content), Convert.ToString(KfPTwo7.Content));
            w.ShowDialog();
        }

        private void KfPTwo8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP8.Content), Convert.ToString(vremya8.Content), Convert.ToString(KfPTwo8.Content));
            w.ShowDialog();
        }

        private void KfPTwo9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP9.Content), Convert.ToString(vremya9.Content), Convert.ToString(KfPTwo9.Content));
            w.ShowDialog();
        }

        private void KfPTwo10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP10.Content), Convert.ToString(vremya10.Content), Convert.ToString(KfPTwo10.Content));
            w.ShowDialog();
        }

        private void KfPOne1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP1.Content), Convert.ToString(vremya1.Content), Convert.ToString(KfPOne1.Content));
            w.ShowDialog();
        }

        private void KfPOne2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP2.Content), Convert.ToString(vremya2.Content), Convert.ToString(KfPOne2.Content));
            w.ShowDialog();
        }

        private void KfPOne3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP3.Content), Convert.ToString(vremya3.Content), Convert.ToString(KfPOne3.Content));
            w.ShowDialog();
        }

        private void KfPOne4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP4.Content), Convert.ToString(vremya4.Content), Convert.ToString(KfPOne4.Content));
            w.ShowDialog();
        }

        private void KfPOne5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP5.Content), Convert.ToString(vremya5.Content), Convert.ToString(KfPOne5.Content));
            w.ShowDialog();
        }

        private void KfPOne6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP6.Content), Convert.ToString(vremya6.Content), Convert.ToString(KfPOne6.Content));
            w.ShowDialog();
        }

        private void KfPOne7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP7.Content), Convert.ToString(vremya7.Content), Convert.ToString(KfPOne7.Content));
            w.ShowDialog();
        }

        private void KfPOne8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP8.Content), Convert.ToString(vremya8.Content), Convert.ToString(KfPOne8.Content));
            w.ShowDialog();
        }

        private void KfPOne9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP9.Content), Convert.ToString(vremya9.Content), Convert.ToString(KfPOne9.Content));
            w.ShowDialog();
        }

        private void KfPOne10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP10.Content), Convert.ToString(vremya10.Content), Convert.ToString(KfPOne10.Content));
            w.ShowDialog();
        }

        private void KfPNikto1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP1.Content), Convert.ToString(vremya1.Content), Convert.ToString(KfPNikto1.Content));
            w.ShowDialog();
        }

        private void KfPNikto2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP2.Content), Convert.ToString(vremya2.Content), Convert.ToString(KfPNikto2.Content));
            w.ShowDialog();
        }

        private void KfPNikto3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP3.Content), Convert.ToString(vremya3.Content), Convert.ToString(KfPNikto3.Content));
            w.ShowDialog();
        }

        private void KfPNikto4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP4.Content), Convert.ToString(vremya4.Content), Convert.ToString(KfPNikto4.Content));
            w.ShowDialog();
        }

        private void KfPNikto5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP5.Content), Convert.ToString(vremya5.Content), Convert.ToString(KfPNikto5.Content));
            w.ShowDialog();
        }

        private void KfPNikto6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP6.Content), Convert.ToString(vremya6.Content), Convert.ToString(KfPNikto6.Content));
            w.ShowDialog();
        }

        private void KfPNikto7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP7.Content), Convert.ToString(vremya7.Content), Convert.ToString(KfPNikto7.Content));
            w.ShowDialog();
        }

        private void KfPNikto8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP8.Content), Convert.ToString(vremya8.Content), Convert.ToString(KfPNikto8.Content));
            w.ShowDialog();
        }

        private void KfPNikto9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP9.Content), Convert.ToString(vremya9.Content), Convert.ToString(KfPNikto9.Content));
            w.ShowDialog();
        }

        private void KfPNikto10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bluuur.Visibility = Visibility.Visible;
            stavkaWin w = new stavkaWin(gn, Convert.ToString(teamOneP10.Content), Convert.ToString(vremya10.Content), Convert.ToString(KfPNikto10.Content));
            w.ShowDialog();
        }
    }
}
