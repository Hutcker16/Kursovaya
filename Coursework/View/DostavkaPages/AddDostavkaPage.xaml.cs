using Coursework.Core;
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
    /// Логика взаимодействия для AddDostavkaPage.xaml
    /// </summary>
    public partial class AddDostavkaPage : Page
    {
        public AddDostavkaPage()
        {
            InitializeComponent();
        }
       
        private void BtnAddDostavka_Click(object sender, RoutedEventArgs e)
        {
            Connect.DB.Доставка.Add(new Model.Доставка
            {
                Метод_доставки = TxbDostavka.Text,
            });
            Connect.DB.SaveChanges();
            MessageBox.Show("Новый метод доставки был добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Connect.MyFrame.Navigate(new MainStaffPage());
        }

        private void ToggleButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
