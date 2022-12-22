using Coursework.Core;
using Coursework.Model;
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

namespace Coursework.View.WarehousePages
{
    /// <summary>
    /// Логика взаимодействия для UpdateWarehousePage.xaml
    /// </summary>
    public partial class UpdateWarehousePage : Page
    {
        private Клиенты _client;
        public UpdateWarehousePage(object o)
        {
            InitializeComponent();

            _client = (o as Button).DataContext as Клиенты;

            TxbNameKom.Text = _client.Название_Компании;
            TxbName.Text = _client.Имя;
            TxbSurName.Text = _client.Фамилия;
            TxbAddres.Text = _client.Адрес;
            TxbCite.Text = _client.Город;
            TxbRegion.Text = _client.Регион;
            TxbNumber.Text = _client.Телефон;
        }

        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainWarehousePage());
        }
       
        private void BtnDeleteWarehouse_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(_client.Название_Компании, "Удалить клиента?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Connect.DB.Клиенты.Remove(_client);
                Connect.DB.SaveChanges();

                MessageBox.Show("Клиент был удален", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Connect.MyFrame.Navigate(new MainWarehousePage());
            }
        }

        private void BtnAddWarehouse_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new AddWarehousePage());
        }

        private void BtnWarehouseUpdate_Click(object sender, RoutedEventArgs e)
        {
            _client.Название_Компании = TxbNameKom.Text;
            _client.Имя = TxbName.Text;
            _client.Фамилия = TxbSurName.Text;
            _client.Адрес= TxbAddres.Text;
            _client.Город = TxbCite.Text;
            _client.Регион = TxbRegion.Text;
            _client.Страна = TxbCountry.Text;
            _client.Телефон = TxbNumber.Text;
            Connect.DB.SaveChanges();

            MessageBox.Show("Информация была обновлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Connect.MyFrame.Navigate(new MainWarehousePage());
        }

        private void BtnClientUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
