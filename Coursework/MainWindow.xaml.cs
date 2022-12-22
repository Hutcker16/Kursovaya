using Coursework.Core;
using Coursework.Model;
using Coursework.View;
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

namespace Coursework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connect.DB = new BD_SokolEntities();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

               // throw;
            }  
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnSingUp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Сотрудники staffModel = Connect.DB.Сотрудники.FirstOrDefault(f => f.Имя == TxbLogin.Text && f.Телефон == PsbPassword.Password);

                if (staffModel == null)
                {
                    MessageBox.Show("Данные не верны", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (staffModel.ID)
                    {
                        case 1:
                            AdminWindow adminWindow = new AdminWindow();
                            adminWindow.Show();
                            this.Hide();
                            break;
                        case 2:
                            Application.Current.Shutdown();
                            break;
                        case 3:
                        case 4:
                        case 5:
                        case 7:
                        case 8:
                        case 9:                                                        
                        case 10:                           
                            break;
                    }
                }
            }
            catch (Exception)
            {

               // throw;
            } 
        }
    }
}
