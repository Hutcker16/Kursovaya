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

namespace Coursework.View.StaffPages
{
    /// <summary>
    /// Логика взаимодействия для AddMeatPagePage.xaml
    /// </summary>
    public partial class AddMeatPagePage : Page
    {
        public AddMeatPagePage()
        {
            InitializeComponent();
        }

        private void BtnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            Connect.DB.Сотрудники.Add(new Model.Сотрудники
            {
                Имя = TxbFullName.Text,
                Фамилия = TxbSurname.Text,
                Должность = TxbPost.Text,
                Телефон= TxbPost.Text,
            });
            Connect.DB.SaveChanges();
            MessageBox.Show("Новый сотрудник был добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Connect.MyFrame.Navigate(new MainStaffPage());
        }


        private void ToggleButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Connect.MyFrame.Navigate(new MainStaffPage());
        }
    }
}
