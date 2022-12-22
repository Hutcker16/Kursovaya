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
    /// Логика взаимодействия для MainTovarPage.xaml
    /// </summary>
    public partial class MainTovarPage : Page
    {
        public MainTovarPage()
        {
            InitializeComponent();
            DataWarehouseInfo.ItemsSource = Connect.DB.Товары.ToList();
        }

        private void BtnUpdateTovar_Click(object sender, RoutedEventArgs e)
        {
            Connect.MyFrame.Navigate(new UpdateTovarPage(sender));
        }
    }
}
