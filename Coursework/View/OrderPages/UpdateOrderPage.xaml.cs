using Coursework.Core;
using Coursework.Model;
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

namespace Coursework.View.OrderPages
{
    /// <summary>
    /// Логика взаимодействия для UpdateOrderPage.xaml
    /// </summary>
    public partial class UpdateOrderPage : Page
    {
        private Заказы _order;
        public UpdateOrderPage(object o)
        {
            InitializeComponent();
            _order = (o as Button).DataContext as Заказы;

            TxbClient.Text = Convert.ToString(_order.ID_Client);
            TxbWork.Text = Convert.ToString(_order.ID_Work);
            TxbData.Text = Convert.ToString(_order.Дата_размещения);
            TxbNumber.Text = Convert.ToString(_order.Номер_заказа);
            TxbAddres.Text = _order.Адрес;
            TxbCity.Text = _order.Город;
            TxbRegion.Text = _order.Регион;
            TxbNumberTel.Text = _order.Телефон;
            TxbDostavka.Text = Convert.ToString(_order.ID_Доставки);
            TxbPrice.Text = Convert.ToString(_order.Стоимость);
        }
        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainTovarPage());
        }
        private void BtnOrderUpdate_Click(object sender, RoutedEventArgs e)
        {
            _order.ID_Client = Convert.ToInt32(TxbClient.Text);
            _order.ID_Work = Convert.ToInt32(TxbClient.Text);
            _order.Дата_размещения = Convert.ToDateTime(TxbClient.Text);
            _order.Номер_заказа = Convert.ToInt32(TxbNumber.Text);
            _order.Адрес = TxbAddres.Text;
            _order.Город = TxbCity.Text;
            _order.Регион = TxbRegion.Text;
            _order.Телефон = TxbNumberTel.Text;
            _order.ID_Доставки = Convert.ToInt32(TxbDostavka.Text);
            _order.Стоимость = Convert.ToDecimal(TxbPrice.Text);
            Connect.DB.SaveChanges();

            MessageBox.Show("Информация была обновлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Connect.MyFrame.Navigate(new MainTovarPage());
        }

        private void BtnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(Convert.ToString(_order.ID_Client), "Удалить заказ?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Connect.DB.Заказы.Remove(_order);
                Connect.DB.SaveChanges();

                MessageBox.Show("Заказ был удален", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Connect.MyFrame.Navigate(new MainTovarPage());
            }
        }

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new AddOrderPage());
        }
    }
}
