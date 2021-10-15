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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SignUp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DialogHost_DialogClosing(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            bool isFulFill = true;
            if (txbHo.Text.Trim() == "")
            {
                txbHo.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbHo.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (txbTen.Text.Trim() == "")
            {
                txbTen.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbTen.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (txbTenDangNhap.Text.Trim() == "")
            {
                txbTenDangNhap.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbTenDangNhap.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (txbEmail.Text.Trim() == "")
            {
                txbEmail.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbEmail.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (txbMatKhau.Password.Trim() == "")
            {
                txbMatKhau.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbMatKhau.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (txbNhapLaiMatKhau.Password.Trim() == "")
            {
                txbNhapLaiMatKhau.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbNhapLaiMatKhau.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (txbNgaySinh.SelectedDate.ToString() == "")
            {
                txbNgaySinh.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            else
                txbNgaySinh.BorderBrush = (Brush)bc.ConvertFrom("#FF35A0FE");
            if (isFulFill)
            {
                InputCode ip = new InputCode();
                ip.Show();
            }    
        }
    }
}
