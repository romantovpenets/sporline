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
    /// Логика взаимодействия для stavkaWin.xaml
    /// </summary>
    public partial class stavkaWin : Window
    {
        string teamOne;
        string vremya;
        string kff;
        string namematch;
        string viborr1;
        int gn;
        public stavkaWin(int l,string to, string v, string k)
        {
            //prt.Sort((a1, b1) => b1.vremya.CompareTo(a1.vremya));
            InitializeComponent();
            teamOne = to;
            
            vremya = v;
            kff = k;
            kf.Content = kff; 
            using (var connect = new Connect())
            {
                gn = l;

                List<stavka> prt = connect.staavki.ToList();
                prt.Sort((a1, b1) => a1.vremya.CompareTo(b1.vremya));
                foreach(var p in prt)
                {
                    
                    
                    if(teamOne == p.nameT1 & vremya == p.vremya & float.Parse(kff) == p.kfP1) 
                    {
                        nameteam.Content = "ПОБЕДА: " + p.nameT1;
                        namematch = p.nameT1 + " - " + p.nameT2;


                    }
                    else if(teamOne == p.nameT1 & vremya == p.vremya & float.Parse(kff) == p.kfP2)
                    {
                        nameteam.Content = "ПОБЕДА: "+p.nameT2;
                        namematch = p.nameT1 + " - " + p.nameT2;
                    }
                    else
                        if(teamOne == p.nameT1 & vremya == p.vremya & float.Parse(kff) == p.kfX)
                    {
                        nameteam.Content = "НИЧЬЯ";
                        namematch = p.nameT1 + " - " + p.nameT2;
                    }
                    viborr1 = Convert.ToString(nameteam.Content);
                    
                }



            }
        }

        private void Border_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void summ_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void summ_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void summ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Convert.ToString(itog.Content) == "")
            {
                itog.Content = 0;
            }
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void summ_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToString(summ.Text) == "")
            {
                itog.Content = "0";
            }
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void summ_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            string a3 = "";
            if (Convert.ToString(summ.Text) == "")
            {
                itog.Content = "0";
            }
            else
            {
                itog.Content = Convert.ToDecimal(Convert.ToString(float.Parse(summ.Text) * float.Parse(kff)));
                
                 
            }


            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var connect = new Connect())
            {
                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.GameN == gn)
                    {
                        if (p.balanc_user >= float.Parse(Convert.ToString(summ.Text)) & summ.Text !="" & summ.Text !="0" & summ.Text != "Неверная сумма!")
                        {
                            p.balanc_user = p.balanc_user - float.Parse(Convert.ToString(summ.Text));
                            connect.SaveChanges();
                            HistoryStavok a = new HistoryStavok(gn, namematch, viborr1, kff, vremya, Convert.ToString(summ.Text), "В игре");
                            connect.historyStavoks.Add(a);
                            connect.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            

                            summ.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                            
                            summ.Text = "Неверная сумма!";
                        }
                    }
                }
            }
                
            
        }

        private void summ_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            summ.Clear();
            summ.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            summ.Background.Opacity = 0.5;
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
