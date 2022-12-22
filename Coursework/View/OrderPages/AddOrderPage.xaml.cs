using Coursework.Core;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coursework.View.OrderPages
{
    /// <summary>
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public AddOrderPage()
        {
            InitializeComponent();
        }

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            Connect.DB.Заказы.Add(new Model.Заказы
            {
               ID_Client = Convert.ToInt32(TxbClient.Text),
               ID_Work = Convert.ToInt32(TxbClient.Text),
               Дата_размещения = Convert.ToDateTime(TxbClient.Text),
               Номер_заказа = Convert.ToInt32(TxbNumber.Text),
               Адрес = TxbAddres.Text,
               Город = TxbCity.Text,
               Регион = TxbRegion.Text,
               ID_Доставки = Convert.ToInt32(TxbDostavka.Text),
               Стоимость = Convert.ToDecimal(TxbPrice.Text),
        });
            Connect.DB.SaveChanges();
            MessageBox.Show("Новый заказ добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Connect.MyFrame.Navigate(new MainWarehousePage());
        }

        private void ToggleButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
