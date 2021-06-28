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
    /// Логика взаимодействия для WindowChangePassword.xaml
    /// </summary>
    public partial class WindowChangePassword : Window
    {

        int gn = 0;
        public WindowChangePassword()
        {
            InitializeComponent();
        }
        public WindowChangePassword(int n)
        {
            InitializeComponent();
            gn = n;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var connect = new Connect())
            {

                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if(gn==p.GameN)
                    {
                        if (p.Password_user == pass.Password)
                        {
                            if (pass_Copy.Password == pass_Copy1.Password & pass_Copy.Password !="")
                            {
                                p.Password_user = pass_Copy.Password;
                                connect.SaveChanges();
                                Window11 w = new Window11(gn);
                                w.Show();
                                this.Close();
                            }
                            else
                            {
                                pass_Copy1.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                                pass_Copy1.Clear();
                                pass_Copy.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                                pass_Copy.Clear();
                            }
                        }
                        else
                        {
                            pass.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                            pass.Clear();
                        }

                    }
                }
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

        private void pass_Copy1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pass_Copy1.Background = new SolidColorBrush(Color.FromRgb(2, 2, 2));

            pass_Copy1.Background.Opacity = 0.25;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window11 w = new Window11(gn);
            w.Show();
            this.Close();
        }
    }
}
