using Coursework.Core;
using Coursework.Model;
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

namespace Coursework.View.TovarPages
{
    /// <summary>
    /// Логика взаимодействия для UpdateTovarPage.xaml
    /// </summary>
    public partial class UpdateTovarPage : Page
    {
        private Товары _tovar;
        public UpdateTovarPage(object o)
        {
            InitializeComponent();
            _tovar = (o as Button).DataContext as Товары;

            TxbMarka.Text = _tovar.Марка;
            TxbPrice.Text = Convert.ToString(_tovar.Цена);            
        }
        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainTovarPage());
        }
        private void BtnTovarUpdate_Click(object sender, RoutedEventArgs e)
        {
            _tovar.Марка = TxbMarka.Text;
            _tovar.Цена = Convert.ToDecimal(TxbPrice.Text);          
            Connect.DB.SaveChanges();

            MessageBox.Show("Информация была обновлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Connect.MyFrame.Navigate(new MainTovarPage());
        }

        private void BtnDeleteTovar_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(_tovar.Марка, "Удалить товар?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Connect.DB.Товары.Remove(_tovar);
                Connect.DB.SaveChanges();

                MessageBox.Show("Товар был удален", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Connect.MyFrame.Navigate(new MainTovarPage());
            }
        }

        private void BtnAddTovar_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new AddTovarPage());
        }
    }
}
