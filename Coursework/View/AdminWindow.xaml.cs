using Coursework.Core;
using Coursework.View.DostavkaPages;
using Coursework.View.InfoOrderPages;
using Coursework.View.OrderPages;
using Coursework.View.StaffPages;
using Coursework.View.TovarPages;
using Coursework.View.WarehousePages;
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

namespace Coursework.View
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            Connect.MyFrame = AdminFrame;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

              //  throw;
            }
        }

        private void BtnStaff_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainStaffPage());
        }

        private void BtnWarehouse_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainWarehousePage());
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainDostavkaPage());
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainOrderPage());
        }

        private void BtnInfoOrder_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainInfoOrderPage());
        }

        private void BtnTovar_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainTovarPage());
        }
    }
}
