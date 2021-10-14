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
            if (txbHo.Text.Trim() == "" || txbTen.Text.Trim()=="")
            {
                txbHo.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            if (txbTen.Text.Trim() == "")
            {
                txbTen.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            if (txbTenDangNhap.Text.Trim() == "")
            {
                txbTenDangNhap.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            if (txbEmail.Text.Trim() == "")
            {
                txbEmail.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            if (txbMatKhau.Password.Trim() == "")
            {
                txbMatKhau.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            if (txbNhapLaiMatKhau.Password.Trim() == "")
            {
                txbNhapLaiMatKhau.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            if (txbNgaySinh.SelectedDate.ToString() == "")
            {
                txbNgaySinh.BorderBrush = (Brush)bc.ConvertFrom("#F6416C");
                isFulFill = false;
            }
            
            if (isFulFill)
            {
                InputCode ip = new InputCode();
                ip.Show();
            }    
        }
    }
}
