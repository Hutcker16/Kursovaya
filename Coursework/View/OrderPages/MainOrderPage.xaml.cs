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

namespace Coursework.View.OrderPages
{
    /// <summary>
    /// Логика взаимодействия для MainOrderPage.xaml
    /// </summary>
    public partial class MainOrderPage : Page
    {
        public MainOrderPage()
        {
            InitializeComponent();
            DataWarehouseInfo.ItemsSource = Connect.DB.Заказы.ToList();
        }

        private void BtnUpdateTovar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
