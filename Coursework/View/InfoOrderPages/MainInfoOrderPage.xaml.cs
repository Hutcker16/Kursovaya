using Coursework.Core;
using Coursework.View.TovarPages;
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

namespace Coursework.View.InfoOrderPages
{
    /// <summary>
    /// Логика взаимодействия для MainInfoOrderPage.xaml
    /// </summary>
    public partial class MainInfoOrderPage : Page
    {
        public MainInfoOrderPage()
        {
            InitializeComponent();
            DataWarehouseInfo.ItemsSource = Connect.DB.Сведения_о_заказе.ToList();
        }

        private void BtnUpdateInfoOrtder_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new UpdateInfoOrderPage(sender));
        }
    }
}
