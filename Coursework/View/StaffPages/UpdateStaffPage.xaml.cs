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

namespace Coursework.View.StaffPages
{
    /// <summary>
    /// Логика взаимодействия для UpdateStaffPage.xaml
    /// </summary>
    public partial class UpdateStaffPage : Page
    {
        private Сотрудники _work;
        public UpdateStaffPage(object o)
        {
            InitializeComponent();
            _work = (o as Button).DataContext as Сотрудники;

            TxbFullName.Text = _work.Имя;
            TxbSurname.Text = _work.Фамилия;
            TxbPost.Text = _work.Должность;
            Txbnumber.Text = _work.Телефон;
        }


        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainStaffPage());
        }

        private void BtnUpdateStaff_Click(object sender, RoutedEventArgs e)
        {
            _work.Имя = TxbFullName.Text;
            _work.Фамилия = TxbSurname.Text;
            _work.Должность = TxbPost.Text;
            _work.Телефон = Txbnumber.Text;
            Connect.DB.SaveChanges();

            MessageBox.Show("Информация была обновлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Connect.MyFrame.Navigate(new MainStaffPage());
        }

        private void BtnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(_work.Имя, "Удалить сотрудника?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Connect.DB.Сотрудники.Remove(_work);
                Connect.DB.SaveChanges();

                MessageBox.Show("Сотрудник был удален", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Connect.MyFrame.Navigate(new MainStaffPage());
            }
        }

        private void BtnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new AddMeatPagePage());
        }
    }
}
