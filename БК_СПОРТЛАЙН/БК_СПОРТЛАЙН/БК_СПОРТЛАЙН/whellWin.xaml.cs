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
    public partial class whellWin : Window
    {
        int gn;
        float bl;
        public whellWin( int g, float b)
        {
            InitializeComponent();
           
            balance1.Content = b;
            b1.IsEnabled = false;
            gn = g;
            bl = b;
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void b3_s_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            g1.IsEnabled = true;
            b3_s.Visibility = Visibility.Visible;
            b2_s.Visibility = Visibility.Hidden;
            b_s1.Visibility = Visibility.Hidden;
        }

        private void Border_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            g1.IsEnabled = true;
            b3_s.Visibility = Visibility.Hidden;
            b2_s.Visibility = Visibility.Visible;
            b_s1.Visibility = Visibility.Hidden;
        }

        private void Border_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            g1.IsEnabled = true;
            b3_s.Visibility = Visibility.Hidden;
            b2_s.Visibility = Visibility.Hidden;
            b_s1.Visibility = Visibility.Visible;
        }

       

        private void Border_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Border_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
          
        }

        private void Border_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
           
        }
       
        private void b_20_1_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

            b_20_1.Visibility = Visibility.Hidden;
        }

        private void b_20_2_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            b_20_2.Visibility = Visibility.Hidden;
        }

        private void b_20_3_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            b_20_3.Visibility = Visibility.Hidden;
        }

        private void b_20_4_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            b_20_4.Visibility = Visibility.Hidden;
        }

        private void b_20_5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_5.Visibility = Visibility.Hidden;
        }

        private void b_20_6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_6.Visibility = Visibility.Hidden;
        }

        private void b_20_7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_7.Visibility = Visibility.Hidden;
        }

        private void b_20_8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_8.Visibility = Visibility.Hidden;
        }

        private void b_20_9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_9.Visibility = Visibility.Hidden;
        }

        private void b_20_10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_10.Visibility = Visibility.Hidden;
        }

        private void b_20_11_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_11.Visibility = Visibility.Hidden;
        }

        private void b_20_12_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_12.Visibility = Visibility.Hidden;
        }

        private void b_20_13_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_13.Visibility = Visibility.Hidden;
        }

        private void b_20_14_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_14.Visibility = Visibility.Hidden;
        }

        private void b_20_15_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_15.Visibility = Visibility.Hidden;
        }

        private void b_20_16_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_16.Visibility = Visibility.Hidden;
        }

        private void b_20_17_PreviewMouseLeftButtonDown (object sender, MouseButtonEventArgs e)
        {

            b_20_17.Visibility = Visibility.Hidden;
        }

        private void b_20_18_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            b_20_18.Visibility = Visibility.Hidden;
        }

        private void b_20_19_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_19.Visibility = Visibility.Hidden;
        }

        private void b_20_20_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_20.Visibility = Visibility.Hidden;
        }

        private void b_20_21_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_21.Visibility = Visibility.Hidden;
        }

        private void b_20_22_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_22.Visibility = Visibility.Hidden;
        }

        private void b_20_23_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_23.Visibility = Visibility.Hidden;
        }

        private void b_20_24_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_24.Visibility = Visibility.Hidden;
        }

        private void b_20_25_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_25.Visibility = Visibility.Hidden;
        }

        private void b_20_26_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_26.Visibility = Visibility.Hidden;

        }

        private void b_20_27_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_27.Visibility = Visibility.Hidden;
        }

        private void b_20_28_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_28.Visibility = Visibility.Hidden;

        }

        private void b_20_29_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_29.Visibility = Visibility.Hidden;
        }

        private void b_20_30_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_30.Visibility = Visibility.Hidden;
        }

        private void b_20_31_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_31.Visibility = Visibility.Hidden;
        }

        private void b_20_32_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_32.Visibility = Visibility.Hidden;
        }

        private void b_20_33_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_33.Visibility = Visibility.Hidden;
        }

        private void b_20_34_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_34.Visibility = Visibility.Hidden;
        }

        private void b_20_35_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_35.Visibility = Visibility.Hidden;
        }

        private void b_20_36_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_20_36.Visibility = Visibility.Hidden;
        }

        private void b20_k_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_k.IsEnabled = true;
            b20_k.Visibility = Visibility.Hidden;
        }

        private void Border_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            b_ch.IsEnabled = true;
            b20_ch.Visibility = Visibility.Hidden;
        }
        private void Label_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_4.Visibility = Visibility.Visible;
            }
            else if(b2_s.Visibility==Visibility.Visible)
            {
                b_50_4.Visibility = Visibility.Visible;
            }
            else if(b3_s.Visibility==Visibility.Visible)
            {
                b_100_4.Visibility = Visibility.Visible;
            }
        }
        private void Label_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_2.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_2.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_2.Visibility = Visibility.Visible;
            }
           
        }

        private void Label_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_1.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_1.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_1.Visibility = Visibility.Visible;
            }
          

        }

        private void Label_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_3.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_3.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_3.Visibility = Visibility.Visible;
            }
           
        }


        private void Label_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_5.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_5.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_5.Visibility = Visibility.Visible;
            }
           
        }

        private void Label_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_6.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_6.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_6.Visibility = Visibility.Visible;
            }
           
        }

        private void Label_PreviewMouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
           
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_7.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_7.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_7.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
           
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_8.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_8.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_8.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_9.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_9.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_9.Visibility = Visibility.Visible;
            }
            
        }

        private void Label_PreviewMouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_10.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_10.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_10.Visibility = Visibility.Visible;
            }
           
        }

        private void Label_PreviewMouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_11.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_11.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_11.Visibility = Visibility.Visible;
            }
           
        }

        private void Label_PreviewMouseLeftButtonDown_12(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_12.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_12.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_12.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_13(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_13.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_13.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_13.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_14.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_14.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_14.Visibility = Visibility.Visible;
            }
            
        }

        private void Label_PreviewMouseLeftButtonDown_15(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_15.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_15.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_15.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_16(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_16.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_16.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_16.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_17(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_17.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_17.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_17.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_18(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_18.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_18.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_18.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_19(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_19.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_19.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_19.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_20(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_20.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_20.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_20.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_21(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_21.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_21.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_21.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_22(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_22.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_22.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_22.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_23(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_23.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_23.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_23.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_24(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_24.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_24.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_24.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_25(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_25.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_25.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_25.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_26(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_26.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_26.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_26.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_27(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_27.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_27.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_27.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_28(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_28.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_28.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_28.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_29(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_29.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_29.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_29.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_30(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_30.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_30.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_30.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_31(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_31.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_31.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_31.Visibility = Visibility.Visible;
            }

        }

        private void Label_PreviewMouseLeftButtonDown_32(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_32.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_32.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_32.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_33(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_33.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_33.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_33.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_34(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_34.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_34.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_34.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_35(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_35.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_35.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_35.Visibility = Visibility.Visible;
            }
        }

        private void Label_PreviewMouseLeftButtonDown_36(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b_20_36.Visibility = Visibility.Visible;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b_50_36.Visibility = Visibility.Visible;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b_100_36.Visibility = Visibility.Visible;
            }
        }
        private void b_k_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b20_k.Visibility = Visibility.Visible;
                b_k.IsEnabled = false;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b50_k.Visibility = Visibility.Visible;
                b_k.IsEnabled = false;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b100_k.Visibility = Visibility.Visible;
                b_k.IsEnabled = false;
            }
            
        }

        private void b_ch_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (b_s1.Visibility == Visibility.Visible)
            {
                b20_ch.Visibility = Visibility.Visible;
                b_ch.IsEnabled = false;
            }
            else if (b2_s.Visibility == Visibility.Visible)
            {
                b50_ch.Visibility = Visibility.Visible;
                b_ch.IsEnabled = false;
            }
            else if (b3_s.Visibility == Visibility.Visible)
            {
                b100_ch.Visibility = Visibility.Visible;
                b_ch.IsEnabled = false;
            }
        }

        private void b_50_1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_1.Visibility = Visibility.Hidden;
        }

        private void b_50_2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_2.Visibility = Visibility.Hidden;
        }

        private void b_50_3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_3.Visibility = Visibility.Hidden;
        }

        private void b_50_4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_4.Visibility = Visibility.Hidden;
        }

        private void b_50_5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_5.Visibility = Visibility.Hidden;
        }

        private void b_50_6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_6.Visibility = Visibility.Hidden;
        }

        private void b_50_7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_7.Visibility = Visibility.Hidden;
        }

        private void b_50_8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_8.Visibility = Visibility.Hidden;
        }

        private void b_50_9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_9.Visibility = Visibility.Hidden;
        }

        private void b_50_10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_10.Visibility = Visibility.Hidden;
        }

        private void b_50_11_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_11.Visibility = Visibility.Hidden;
        }

        private void b_50_12_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_12.Visibility = Visibility.Hidden;
        }

        private void b_50_13_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_13.Visibility = Visibility.Hidden;
        }

        private void b_50_14_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_14.Visibility = Visibility.Hidden;

        }

        private void b_50_15_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_15.Visibility = Visibility.Hidden;
        }

        private void b_50_16_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_16.Visibility = Visibility.Hidden;
        }

        private void b_50_17_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_17.Visibility = Visibility.Hidden;
        }

        private void b_50_18_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_18.Visibility = Visibility.Hidden;
        }

        private void b_50_19_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_19.Visibility = Visibility.Hidden;
        }

        private void b_50_20_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_20.Visibility = Visibility.Hidden;
        }

        private void b_50_21_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_21.Visibility = Visibility.Hidden;
        }

        private void b_50_22_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_22.Visibility = Visibility.Hidden;
        }

        private void b_50_23_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_23.Visibility = Visibility.Hidden;
        }

        private void b_50_24_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_24.Visibility = Visibility.Hidden;
        }

        private void b_50_25_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_25.Visibility = Visibility.Hidden;
        }

        private void b_50_26_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_26.Visibility = Visibility.Hidden;
        }

        private void b_50_27_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_27.Visibility = Visibility.Hidden;
        }

        private void b_50_28_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_28.Visibility = Visibility.Hidden;
        }

        private void b_50_29_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_29.Visibility = Visibility.Hidden;
        }

        private void b_50_30_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_30.Visibility = Visibility.Hidden;
        }

        private void b_50_31_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_31.Visibility = Visibility.Hidden;
        }

        private void b_50_32_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_32.Visibility = Visibility.Hidden;
        }

        private void b_50_33_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_33.Visibility = Visibility.Hidden;
        }

        private void b_50_34_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_34.Visibility = Visibility.Hidden;
        }

        private void b_50_35_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_35.Visibility = Visibility.Hidden;
        }

        private void b_50_36_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_50_36.Visibility = Visibility.Hidden;
        }

        private void b50_ch_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b50_ch.Visibility = Visibility.Hidden;
            b_ch.IsEnabled = true;
        }

        private void b50_k_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b50_k.Visibility = Visibility.Hidden;
            b_k.IsEnabled = true;
        }

        private void b_100_1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_1.Visibility = Visibility.Hidden;
        }

        private void b_100_2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_2.Visibility = Visibility.Hidden;
        }

        private void b_100_3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_3.Visibility = Visibility.Hidden;
        }

        private void b_100_4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_4.Visibility = Visibility.Hidden;
        }

        private void b_100_5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_5.Visibility = Visibility.Hidden;
        }

        private void b_100_6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_6.Visibility = Visibility.Hidden;
        }

        private void b_100_7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_7.Visibility = Visibility.Hidden;
        }

        private void b_100_8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_8.Visibility = Visibility.Hidden;
        }

        private void b_100_9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_9.Visibility = Visibility.Hidden;
        }

        private void b_100_10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_10.Visibility = Visibility.Hidden;
        }

        private void b_100_11_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_11.Visibility = Visibility.Hidden;

        }

        private void b_100_12_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_12.Visibility = Visibility.Hidden;
        }

        private void b_100_13_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_13.Visibility = Visibility.Hidden;
        }

        private void b_100_14_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_14.Visibility = Visibility.Hidden;
        }

        private void b_100_15_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_15.Visibility = Visibility.Hidden;
        }

        private void b_100_16_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_16.Visibility = Visibility.Hidden;
        }

        private void b_100_17_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_17.Visibility = Visibility.Hidden;
        }

        private void b_100_18_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_18.Visibility = Visibility.Hidden;

        }

        private void b_100_19_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_19.Visibility = Visibility.Hidden;
        }

        private void b_100_20_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_20.Visibility = Visibility.Hidden;
        }

        private void b_100_21_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_21.Visibility = Visibility.Hidden;
        }

        private void b_100_22_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_22.Visibility = Visibility.Hidden;
        }

        private void b_100_23_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_23.Visibility = Visibility.Hidden;
        }

        private void b_100_24_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_24.Visibility = Visibility.Hidden;
        }

        private void b_100_25_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_25.Visibility = Visibility.Hidden;
        }

        private void b_100_26_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_26.Visibility = Visibility.Hidden;
        }

        private void b_100_27_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_27.Visibility = Visibility.Hidden;
        }

        private void b_100_28_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_28.Visibility = Visibility.Hidden;
        }

        private void b_100_29_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_29.Visibility = Visibility.Hidden;
        }

        private void b_100_30_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_30.Visibility = Visibility.Hidden;
        }

        private void b_100_31_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_31.Visibility = Visibility.Hidden;
        }

        private void b_100_32_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_32.Visibility = Visibility.Hidden;
        }

        private void b_100_33_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_33.Visibility = Visibility.Hidden;
        }

        private void b_100_34_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_34.Visibility = Visibility.Hidden;
        }

        private void b_100_35_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_35.Visibility = Visibility.Hidden;
        }

        private void b_100_36_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b_100_36.Visibility = Visibility.Hidden;
        }

        private void b100_ch_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b100_ch.Visibility = Visibility.Hidden;
            b_ch.IsEnabled = true;
        }

        private void b100_k_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b100_k.Visibility = Visibility.Hidden;
            b_k.IsEnabled = true;
        }

      
        private void b1_Copy1_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            bss.Visibility = Visibility.Visible;
            b1_Copy2.IsEnabled = true;
            b1.IsEnabled = true;
            b1_Copy1.IsEnabled = false;
        }

        private void b1_Copy2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b1_Copy2.IsEnabled = false;
            b1_Copy1.IsEnabled = true;
            bss.Visibility = Visibility.Hidden;
            b1.IsEnabled = false;
        }

        private void b1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b1.IsEnabled = false;
            l_summavin.Visibility = Visibility.Hidden;
            l_proig.Visibility = Visibility.Hidden;
            l_viig.Visibility = Visibility.Hidden;
            n5_5_Copy.Visibility = Visibility.Hidden;
            n37.Visibility = Visibility.Hidden;
            l_chislo1.Visibility = Visibility.Hidden;
            int count_20 = 0;
            b1_Copy1.IsEnabled = false;
            b1_Copy2.IsEnabled = false;
            int count_50 = 0;
            int count_100 = 0;
            int sum = 0;
            Border[] mas_20 = new Border[38] { b_20_1, b_20_2, b_20_3, b_20_4, b_20_5, b_20_6, b_20_7, b_20_8, b_20_9, b_20_10, b_20_11, b_20_12, b_20_13, b_20_14, b_20_15, b_20_16, b_20_17, b_20_18, b_20_19, b_20_20, b_20_21, b_20_22, b_20_23, b_20_24, b_20_25, b_20_26, b_20_27, b_20_28, b_20_29, b_20_30, b_20_31, b_20_32, b_20_33, b_20_34, b_20_35, b_20_36, b20_ch, b20_k };
            Border[] mas_50 = new Border[38] { b_50_1, b_50_2, b_50_3, b_50_4, b_50_5, b_50_6, b_50_7, b_50_8, b_50_9, b_50_10, b_50_11, b_50_12, b_50_13, b_50_14, b_50_15, b_50_16, b_50_17, b_50_18, b_50_19, b_50_20, b_50_21, b_50_22, b_50_23, b_50_24, b_50_25, b_50_26, b_50_27, b_50_28, b_50_29, b_50_30, b_50_31, b_50_32, b_50_33, b_50_34, b_50_35, b_50_36, b50_ch, b50_k };
            Border[] mas_100 = new Border[38] { b_100_1, b_100_2, b_100_3, b_100_4, b_100_5, b_100_6, b_100_7, b_100_8, b_100_9, b_100_10, b_100_11, b_100_12, b_100_13, b_100_14, b_100_15, b_100_16, b_100_17, b_100_18, b_100_19, b_100_20, b_100_21, b_100_22, b_100_23, b_100_24, b_100_25, b_100_26, b_100_27, b_100_28, b_100_29, b_100_30, b_100_31, b_100_32, b_100_33, b_100_34, b_100_35, b_100_36, b100_ch, b100_k };
            for (int i1 = 0; i1 < 38; i1++)
            {
                if (mas_20[i1].Visibility == Visibility.Visible)
                {
                    count_20++;
                }
                else if (mas_50[i1].Visibility == Visibility.Visible)
                {
                    count_50++;
                }
                else if (mas_100[i1].Visibility == Visibility.Visible)
                {
                    count_100++;
                }
                else
                {
                    continue;
                }
            }
            sum = count_20 * 20;
            sum = sum + (count_50 * 50);
            sum = sum + (count_100 * 100);
            if (sum == 0)
            {
                l_chislo1_Copy.Visibility = Visibility.Visible;
                b1.IsEnabled = false;
                b1_Copy2.IsEnabled = false;
                b1_Copy1.IsEnabled = true;
                bss.Visibility = Visibility.Hidden;
                Label[] mas = new Label[36] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29, n30, n31, n32, n33, n34, n35, n36 };
                for (int i1 = 1; i1 < 37; i1++)
                {
                    if (i1 == 2 | i1 == 4 | i1 == 5 | i1 == 7 | i1 == 10 | i1 == 12 | i1 == 13 | i1 == 15 | i1 == 18 | i1 == 20 | i1 == 21 | i1 == 23 | i1 == 26 | i1 == 28 | i1 == 29 | i1 == 31 | i1 == 34 | i1 == 36)
                    {
                        mas[i1 - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i1 - 1].Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                        mas[i1 - 1].Background.Opacity = 0.6;

                    }
                    else
                    {
                        mas[i1 - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i1 - 1].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        mas[i1 - 1].Background.Opacity = 0.6;

                    }
                }
            }
            else if(Convert.ToInt32(balance1.Content)-sum<0)
            {
                l_chislo1_Copy1.Visibility = Visibility.Visible;
                b1.IsEnabled = false;
                b1.Visibility = Visibility.Hidden;
                b1_Copy2.IsEnabled = false;
                b1_Copy1.IsEnabled = true;
                for (int i1 = 0; i1 < 38; i1++)
                {
                    mas_20[i1].Visibility = Visibility.Hidden;
                    mas_50[i1].Visibility = Visibility.Hidden;
                    mas_100[i1].Visibility = Visibility.Hidden;
                }
                b_k.IsEnabled = true;
                b_ch.IsEnabled = true;
                bss.Visibility = Visibility.Hidden;
                Label[] mas = new Label[36] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29, n30, n31, n32, n33, n34, n35, n36 };
                for (int i1 = 1; i1 < 37; i1++)
                {
                    if (i1 == 2 | i1 == 4 | i1 == 5 | i1 == 7 | i1 == 10 | i1 == 12 | i1 == 13 | i1 == 15 | i1 == 18 | i1 == 20 | i1 == 21 | i1 == 23 | i1 == 26 | i1 == 28 | i1 == 29 | i1 == 31 | i1 == 34 | i1 == 36)
                    {
                        mas[i1 - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i1 - 1].Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                        mas[i1 - 1].Background.Opacity = 0.6;

                    }
                    else
                    {
                        mas[i1 - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i1 - 1].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        mas[i1 - 1].Background.Opacity = 0.6;

                    }
                }
            }
            else
            {
                b1.IsEnabled = false;
                l_chislo1_Copy1.Visibility = Visibility.Hidden;
                l_chislo1_Copy.Visibility = Visibility.Hidden;
                using (var connect = new Connect())
                {
                    List<USER> prt1 = connect.Users.ToList();
                    foreach (var p1 in prt1)
                    {
                        if (gn == p1.GameN)
                        {
                            
                                p1.balanc_user = p1.balanc_user - sum;
                                balance1.Content = p1.balanc_user;
                                connect.SaveChanges();

                        }
                    }
                }
                int[] masItog_20 = new int[count_20];
                for (int i1 = 0; i1 < count_20; i1++)
                {
                    masItog_20[i1] = 0;
                }
                int[] masItog_50 = new int[count_50];
                for (int i1 = 0; i1 < count_50; i1++)
                {
                    masItog_50[i1] = 0;
                }
                int[] masItog_100 = new int[count_100];
                for (int i1 = 0; i1 < count_100; i1++)
                {
                    masItog_100[i1] = 0;
                }
                int j = 0;
                int j1 = 0;
                int j2 = 0;

                for (int i1 = 0; i1 < 38; i1++)
                {
                    if (mas_20[i1].Visibility == Visibility.Visible)
                    {
                        masItog_20[j] = i1 + 1;
                        j++;
                    }
                    else if (mas_50[i1].Visibility == Visibility.Visible)
                    {
                        masItog_50[j1] = i1 + 1;
                        j1++;
                    }
                    else if (mas_100[i1].Visibility == Visibility.Visible)
                    {
                        masItog_100[j2] = i1 + 1;
                        j2++;
                    }
                    else
                    {
                        continue;
                    }
                }

                Label[] mas = new Label[36] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29, n30, n31, n32, n33, n34, n35, n36 };
                for (int i1 = 1; i1 < 37; i1++)
                {
                    if (i1 == 2 | i1 == 4 | i1 == 5 | i1 == 7 | i1 == 10 | i1 == 12 | i1 == 13 | i1 == 15 | i1 == 18 | i1 == 20 | i1 == 21 | i1 == 23 | i1 == 26 | i1 == 28 | i1 == 29 | i1 == 31 | i1 == 34 | i1 == 36)
                    {
                        mas[i1 - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i1 - 1].Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                        mas[i1 - 1].Background.Opacity = 0.6;

                    }
                    else
                    {
                        mas[i1 - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i1 - 1].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        mas[i1 - 1].Background.Opacity = 0.6;

                    }
                }

                System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

                Random rnd = new Random();
                int a = rnd.Next(110, 150);


                int i = 1;
                int n = 4;
                timer.Interval = TimeSpan.FromMilliseconds(n);
                int count = 0;
                timer.Tick += timer_Tick;
                timer.Start();
                void timer_Tick(object sender2, EventArgs e2)
                {
                    count++;
                    if (i == 36)
                    {
                        mas[i - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        mas[i - 1].Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                        mas[i - 1].Background.Opacity = 0.6;
                        mas[0].Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                        mas[0].Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        i = 1;
                    }
                    else
                    {
                        if (i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36)
                        {
                            mas[i - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            mas[i - 1].Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            mas[i - 1].Background.Opacity = 0.6;

                            mas[i].Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                            mas[i].Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        }
                        else
                        {
                            mas[i - 1].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            mas[i - 1].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                            mas[i - 1].Background.Opacity = 0.6;

                            mas[i].Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                            mas[i].Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        }
                        i++;




                    }
                    if (a - count < 80)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(10);
                    }
                    if (a - count < 60)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(13);
                    }
                    if (a - count < 50)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(17);
                    }
                    if (a - count < 40)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(20);
                    }
                    if (a - count < 35)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(23);
                    }
                    if (a - count < 30)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(25);
                    }
                    if (a - count < 25)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(30);
                    }
                    if (a - count < 20)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(35);
                    }
                    if (a - count < 15)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(40);
                    }
                    if (a - count < 14)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(45);
                    }
                    if (a - count < 13)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(50);
                    }
                    if (a - count < 12)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(55);
                    }
                    if (a - count < 11)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(60);
                    }
                    if (a - count < 10)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(70);
                    }
                    if (a - count < 9)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(80);
                    }
                    if (a - count < 8)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(90);
                    }
                    if (a - count < 7)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(110);
                    }
                    if (a - count < 6)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(160);
                    }
                    if (a - count < 5)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(200);
                    }
                    if (a - count < 4)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(240);
                    }
                    if (a - count < 3)
                    {
                        timer.Interval = TimeSpan.FromMilliseconds(300);
                    }

                    if (a - count < 2)
                    {
                        int a1 = rnd.Next(0, 2);
                        if (a1 == 1)
                        {
                            timer.Interval = TimeSpan.FromMilliseconds(1000);
                        }
                        else
                        {
                            timer.Interval = TimeSpan.FromMilliseconds(600);
                        }
                       
                    }
                    if (count == a)
                    {
                       
                        if ((i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36))
                        {
                            n37.Content = i;
                            n37.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            n37.Background.Opacity = 0.7;

                        }
                        else if ((i == 1 | i == 2 | i == 3 | i == 6 | i == 8 | i == 9 | i == 11 | i == 14 | i == 16 | i == 17 | i == 19 | i == 22 | i == 24 | i == 25 | i == 27 | i == 30 | i == 32 | i == 33 | i == 35))
                        {
                            n37.Content = i;
                            n37.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                            n37.Background.Opacity = 0.7;

                        }

                        if ((i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36))
                        {
                            n37.Content = i;
                            n37.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            n37.Background.Opacity = 0.7;

                        }
                        else if ((i == 1 | i == 2 | i == 3 | i == 6 | i == 8 | i == 9 | i == 11 | i == 14 | i == 16 | i == 17 | i == 19 | i == 22 | i == 24 | i == 25 | i == 27 | i == 30 | i == 32 | i == 33 | i == 35))
                        {
                            n37.Content = i;
                            n37.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                            n37.Background.Opacity = 0.7;

                        }

                        if ((i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36))
                        {
                            n37.Content = i;
                            n37.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            n37.Background.Opacity = 0.7;

                        }
                        else if ((i == 1 | i == 2 | i == 3 | i == 6 | i == 8 | i == 9 | i == 11 | i == 14 | i == 16 | i == 17 | i == 19 | i == 22 | i == 24 | i == 25 | i == 27 | i == 30 | i == 32 | i == 33 | i == 35))
                        {
                            n37.Content = i;
                            n37.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                            n37.Background.Opacity = 0.7;

                        }
                        l_chislo1.Visibility = Visibility.Visible;
                        n5_5_Copy.Visibility = Visibility.Visible;
                        n37.Visibility = Visibility.Visible;

                        int WIN = 0;
                        for (int i1 = 0; i1 < count_20; i1++)
                        {
                            if (masItog_20[i1] == i)
                            {
                                int k = 20 * 36;
                                WIN = WIN + k;
                            }
                        }
                        for (int i1 = 0; i1 < count_50; i1++)
                        {
                            if (masItog_50[i1] == i)
                            {
                                int k = 50 * 36;
                                WIN = WIN + k;
                            }
                        }
                        for (int i1 = 0; i1 < count_100; i1++)
                        {
                            if (masItog_100[i1] == i)
                            {
                                int k = 100 * 36;
                                WIN = WIN + k;
                            }
                        }
                        if ((i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36) & b20_k.Visibility == Visibility.Visible)
                        {
                            int k = 2 * 20;
                            WIN = WIN + k;
                        }
                        else if ((i == 1 | i == 2 | i == 3 | i == 6 | i == 8 | i == 9 | i == 11 | i == 14 | i == 16 | i == 17 | i == 19 | i == 22 | i == 24 | i == 25 | i == 27 | i == 30 | i == 32 | i == 33 | i == 35) & b20_ch.Visibility == Visibility.Visible)
                        {
                            int k = 2 * 20;
                            WIN = WIN + k;
                        }

                        if ((i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36) & b50_k.Visibility == Visibility.Visible)
                        {
                            int k = 2 * 50;
                            WIN = WIN + k;
                        }
                        else if ((i == 1 | i == 2 | i == 3 | i == 6 | i == 8 | i == 9 | i == 11 | i == 14 | i == 16 | i == 17 | i == 19 | i == 22 | i == 24 | i == 25 | i == 27 | i == 30 | i == 32 | i == 33 | i == 35) & b50_ch.Visibility == Visibility.Visible)
                        {
                            int k = 2 * 50;
                            WIN = WIN + k;
                        }
                        if ((i == 2 | i == 4 | i == 5 | i == 7 | i == 10 | i == 12 | i == 13 | i == 15 | i == 18 | i == 20 | i == 21 | i == 23 | i == 26 | i == 28 | i == 29 | i == 31 | i == 34 | i == 36) & b100_k.Visibility == Visibility.Visible)
                        {
                            int k = 2 * 100;
                            WIN = WIN + k;
                        }
                        else if ((i == 1 | i == 2 | i == 3 | i == 6 | i == 8 | i == 9 | i == 11 | i == 14 | i == 16 | i == 17 | i == 19 | i == 22 | i == 24 | i == 25 | i == 27 | i == 30 | i == 32 | i == 33 | i == 35) & b100_ch.Visibility == Visibility.Visible)
                        {
                            int k = 2 * 100;
                            WIN = WIN + k;
                        }
                        if (WIN > 0)
                        {
                            using (var connect = new Connect())
                            {
                                List<USER> prt1 = connect.Users.ToList();
                                foreach (var p1 in prt1)
                                {
                                    if (gn == p1.GameN)
                                    {
                                            p1.balanc_user = p1.balanc_user + WIN;
                                        
                                        
                                            balance1.Content = p1.balanc_user;
                                             bl = p1.balanc_user;
                                            connect.SaveChanges();

                                    }
                                }
                            }
                            l_viig.Visibility = Visibility.Visible;
                            l_summavin.Content = WIN + " BYN";
                            l_summavin.Visibility = Visibility.Visible;
                        }
                        else
                        {

                            l_proig.Visibility = Visibility.Visible;
                        }

                        b1_Copy1.IsEnabled = true;
                        b1_Copy2.IsEnabled = false;

                        for(int i1=0;i1<38;i1++)
                        {
                            mas_20[i1].Visibility = Visibility.Hidden;
                            mas_50[i1].Visibility = Visibility.Hidden;
                            mas_100[i1].Visibility = Visibility.Hidden;
                        }
                        b_k.IsEnabled = true;
                        b_ch.IsEnabled = true;
                        bss.Visibility = Visibility.Hidden;

                        timer.Stop();
                    }
                }
                
            }
        }
        private void bb_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
