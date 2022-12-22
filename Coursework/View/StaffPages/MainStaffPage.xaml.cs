using Coursework.Core;
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

namespace Coursework.View.StaffPages
{
    /// <summary>
    /// Логика взаимодействия для MainStaffPage.xaml
    /// </summary>
    public partial class MainStaffPage : Page
    {
        public MainStaffPage()
        {
            InitializeComponent();
            DataStaffInfo.ItemsSource = Connect.DB.Сотрудники.ToList();
        }

        private void BtnUpdateStaffInfo_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new UpdateStaffPage(sender));
        }

    }
}
