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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        int gn;
        float bl;
        public Window9()
        {
            InitializeComponent();
        }

        public Window9(int n, float b)
        {
            gn = n;
            bl = b;
            InitializeComponent();

        }
        private void bv_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void TextBox_PreviewKeyDown_1(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;

        }

        private void TextBox_PreviewTextInput_2(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;


        }

        private void TextBox_PreviewKeyDown_2(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void TextBox_PreviewKeyDown_3(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void TextBox_PreviewTextInput_3(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;

        }

        private void TextBox_PreviewTextInput_4(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0))
                e.Handled = true;
        }

        private void TextBox_PreviewTextInput_5(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void TextBox_PreviewKeyDown_4(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void bv_Click(object sender, RoutedEventArgs e)
        {
            using (var connect = new Connect())
            {
                float bal=0;
                List<USER> prt = connect.Users.ToList();
                foreach (var p in prt)
                {
                    if (p.GameN == gn)
                    {
                        bal = p.balanc_user;
                    }

                }
                if (tb.Text == "" | Convert.ToInt32(tb.Text) > bal  | tb.Text=="0")
                {
                    tb.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    tb.Clear();
                }
                if (tn.Text == "" | tn.Text.Length<16)
                {
                    tn.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    tn.Clear();
                }
                if (tnam.Text == "" )
                {
                    tnam.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    tnam.Clear();
                }
                if (ty.Text == "" | tn.Text.Length < 2)
                {
                    ty.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    ty.Clear();
                }
                if (tm.Text == "" | tn.Text.Length < 2)
                {
                    tm.Background = new SolidColorBrush(Color.FromRgb(220, 69, 69));
                    tm.Clear();
                }

                if (tm.Text != "" & ty.Text != "" & tnam.Text != "" & tn.Text != "" & tb.Text != "" )
                {

                   
                    foreach (var p in prt)
                    {
                        if (p.GameN == gn)
                        {
                            p.balanc_user = p.balanc_user - float.Parse(tb.Text);
                            HistoryFinansy a = new HistoryFinansy(p.GameN, "Вывод", tb.Text, tn.Text, DateTime.Now.ToString());
                            connect.historyFinansies.Add(a);
                            connect.SaveChanges();
                            Window10 win = new Window10();
                            win.Show();
                            this.Close();


                        }

                    }
                }
            }
        }

        private void tn_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tn.Background = new SolidColorBrush(Color.FromRgb(32, 21, 41));
   
            tn.Background.Opacity = 0.5;
        }

        private void tm_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tm.Background = new SolidColorBrush(Color.FromRgb(32, 21, 41));

            tm.Background.Opacity = 0.5;
        }

        private void ty_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ty.Background = new SolidColorBrush(Color.FromRgb(32, 21, 41));
           
            ty.Background.Opacity = 0.5;
        }
        private void tb_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb.Background = new SolidColorBrush(Color.FromRgb(43, 17, 66));

            tb.Background.Opacity = 0.5;
        }

        private void tnam_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tnam.Background = new SolidColorBrush(Color.FromRgb(32, 21, 41));

            tnam.Background.Opacity = 0.5;
        }

        private void tn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
