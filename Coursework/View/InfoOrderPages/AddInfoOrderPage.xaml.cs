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

namespace Coursework.View.InfoOrderPages
{
    /// <summary>
    /// Логика взаимодействия для AddInfoOrderPage.xaml
    /// </summary>
    public partial class AddInfoOrderPage : Page
    {
        public AddInfoOrderPage()
        {
            InitializeComponent();
        }

        private void BtnAddInfoOrder_Click(object sender, RoutedEventArgs e)
        {
            Connect.DB.Сведения_о_заказе.Add(new Model.Сведения_о_заказе
            {
                ID_Заказа = Convert.ToInt32(TxbOrder.Text),
                ID_Товара = Convert.ToInt32(TxbTovar.Text),
                Коливество = TxbOrder.Text,
                Цена = Convert.ToDecimal(TxbPrice.Text),
        });
            Connect.DB.SaveChanges();
            MessageBox.Show("Новые сведенья добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Connect.MyFrame.Navigate(new MainInfoOrderPage());
        }

        private void ToggleButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
