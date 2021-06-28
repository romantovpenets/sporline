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
    /// Логика взаимодействия для adminWin.xaml
    /// </summary>
    public partial class adminWin : Window
    {
        public adminWin()
        {
            InitializeComponent();
            vid.Items.Add("Футбол");
            vid.Items.Add("Теннис");
            vid.Items.Add("Баскетбол");
            vid.Items.Add("Хоккей");
            vid.Items.Add("Волейбол");
            vid.Items.Add("UFC");
            vid.Items.Add("Австралийский футбол");
            vid.Items.Add("Американский футбол");
            vid.Items.Add("Бадбинтон");
            vid.Items.Add("Бейсбол");
            vid.Items.Add("Бокс");
            vid.Items.Add("Водное поло");
            vid.Items.Add("Гандбол");
            vid.Items.Add("Дартс");
            vid.Items.Add("Единаборства");
            vid.Items.Add("Настольный теннис");
            vid.Items.Add("Регби");
            vid.Items.Add("Флорбол");
            vid.Items.Add("Футзал");
            vid.Items.Add("DOTA 2");
            vid.Items.Add("LoL");
            vid.Items.Add("CS:GO");
            vid.Items.Add("Valorant");
            vid.Items.Add("CoL");
            vid.Items.Add("FIFA");
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            using (var connect = new Connect())
            {

                stavka c = new stavka(vid.SelectedItem.ToString(), float.Parse(kf1.Text), float.Parse(kfx.Text), float.Parse(kf2.Text),date.Text, name1.Text, name2.Text);
                connect.staavki.Add(c);
                connect.SaveChanges();

            }
            formess.Visibility = Visibility.Visible;
            kAdd w = new kAdd();
            w.ShowDialog();
            
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            glavnoeWindow a = new glavnoeWindow(0, 99999);
            a.Show();
            this.Close();
        }

        private void Label_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }

        private void Label_GotFocus(object sender, RoutedEventArgs e)
        {
            formess.Visibility = Visibility.Hidden;
        }

        private void formess_GotFocus(object sender, RoutedEventArgs e)
        {
            formess.Visibility = Visibility.Hidden;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            formess.Visibility = Visibility.Hidden;
        }

        private void Label_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }

        private void Label_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            
            
        }
    }
}
