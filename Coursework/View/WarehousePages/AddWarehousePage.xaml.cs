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

namespace Coursework.View.WarehousePages
{
    /// <summary>
    /// Логика взаимодействия для AddWarehousePage.xaml
    /// </summary>
    public partial class AddWarehousePage : Page
    {
        public AddWarehousePage()
        {
            InitializeComponent();
        }

        private void BtnAddWarehouse_Click(object sender, RoutedEventArgs e)
        {
            Connect.DB.Клиенты.Add(new Model.Клиенты
            {
              Название_Компании = TxbNameKom.Text,
              Имя = TxbName.Text,
              Фамилия = TxbSurName.Text,
              Адрес = TxbAddres.Text,
              Город = TxbCite.Text,
              Регион = TxbRegion.Text,
              Страна = TxbCountry.Text,
              Телефон = TxbNumber.Text,
        });
            Connect.DB.SaveChanges();
            MessageBox.Show("Новый клиент добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Connect.MyFrame.Navigate(new MainWarehousePage());
        }

        private void ToggleButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainWarehousePage());
        }
    }
}
