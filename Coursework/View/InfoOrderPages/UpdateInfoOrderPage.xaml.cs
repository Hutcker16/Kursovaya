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

namespace Coursework.View.InfoOrderPages
{
    /// <summary>
    /// Логика взаимодействия для UpdateInfoOrderPage.xaml
    /// </summary>
    public partial class UpdateInfoOrderPage : Page
    {
        private Сведения_о_заказе _info;
        public UpdateInfoOrderPage(object o)
        {
            InitializeComponent();
            _info = (o as Button).DataContext as Сведения_о_заказе;

            TxbOrder.Text = Convert.ToString(_info.ID_Заказа);
            TxbTovar.Text = Convert.ToString(_info.ID_Товара);
            TxbColum.Text = _info.Коливество;
            TxbPrice.Text = Convert.ToString(_info.Цена);
        }
        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainTovarPage());
        }
        private void BtnInfoOrderUpdate_Click(object sender, RoutedEventArgs e)
        {
            _info.ID_Заказа = Convert.ToInt32(TxbOrder.Text);
            _info.ID_Товара = Convert.ToInt32(TxbTovar.Text);
            _info.Коливество = TxbOrder.Text;
            _info.Цена = Convert.ToDecimal(TxbPrice.Text);
            Connect.DB.SaveChanges();

            MessageBox.Show("Информация была обновлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Connect.MyFrame.Navigate(new MainTovarPage());
        }

        private void BtnDeleteInfoOrder_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(Convert.ToString(_info.ID_Заказа), "Удалить сведенья?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Connect.DB.Сведения_о_заказе.Remove(_info);
                Connect.DB.SaveChanges();

                MessageBox.Show("Сведенья былы удалены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Connect.MyFrame.Navigate(new MainTovarPage());
            }
        }

        private void BtnAddInfoOrder_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new AddInfoOrderPage());
        }
    }
}
