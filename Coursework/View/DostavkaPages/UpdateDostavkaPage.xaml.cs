using Coursework.Core;
using Coursework.Model;
using Coursework.View.StaffPages;
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

namespace Coursework.View.DostavkaPages
{
    /// <summary>
    /// Логика взаимодействия для UpdateDostavkaPage.xaml
    /// </summary>
    public partial class UpdateDostavkaPage : Page
    {
        private Доставка _dostavka;
        public UpdateDostavkaPage(object o)
        {           
            InitializeComponent();
            _dostavka = (o as Button).DataContext as Доставка;

            TxbDostavka.Text = _dostavka.Метод_доставки;           
        }
        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainStaffPage());
        }
        private void BtnUpdateDostavka_Click(object sender, RoutedEventArgs e)
        {
            _dostavka.Метод_доставки = TxbDostavka.Text;           
            Connect.DB.SaveChanges();

            MessageBox.Show("Информация была обновлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Connect.MyFrame.Navigate(new MainStaffPage());
        }

        private void BtnDeleteDostavka_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(_dostavka.Метод_доставки, "Удалить метод?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Connect.DB.Доставка.Remove(_dostavka);
                Connect.DB.SaveChanges();

                MessageBox.Show("Метод был удален", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Connect.MyFrame.Navigate(new MainStaffPage());
            }
        }

        private void BtnAddDostavka_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new AddDostavkaPage());
        }
    }
}
