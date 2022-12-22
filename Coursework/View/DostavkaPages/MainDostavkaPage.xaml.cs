using Coursework.Core;
using Coursework.View.StaffPages;
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

namespace Coursework.View.DostavkaPages
{
    /// <summary>
    /// Логика взаимодействия для MainDostavkaPage.xaml
    /// </summary>
    public partial class MainDostavkaPage : Page
    {
        public MainDostavkaPage()
        {
            InitializeComponent();
            DataStaffInfo.ItemsSource = Connect.DB.Доставка.ToList();
        }

        private void BtnMainDostavka_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new UpdateStaffPage(sender));
        }
    }
}
