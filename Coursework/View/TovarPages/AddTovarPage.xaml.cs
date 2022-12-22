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

namespace Coursework.View.TovarPages
{
    /// <summary>
    /// Логика взаимодействия для AddTovarPage.xaml
    /// </summary>
    public partial class AddTovarPage : Page
    {
        public AddTovarPage()
        {
            InitializeComponent();
        }

        private void BtnAddTovar_Click(object sender, RoutedEventArgs e)
        {

            Connect.DB.Товары.Add(new Model.Товары
            {
                Марка = TxbMarka.Text,
                Цена = Convert.ToDecimal(TxbPrice.Text),                
            });
            Connect.DB.SaveChanges();
            MessageBox.Show("Новый товар добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Connect.MyFrame.Navigate(new MainWarehousePage());
        }

        private void ToggleButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
