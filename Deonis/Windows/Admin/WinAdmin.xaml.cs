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
using System.Windows.Shapes;

namespace Deonis.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для WinAdmin.xaml
    /// </summary>
    public partial class WinAdmin : Window
    {
        public WinAdmin()
        {
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMenu.Visibility = Visibility.Visible;
            btnOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMenu.Visibility = Visibility.Collapsed;
            btnOpenMenu.Visibility = Visibility.Visible;
        }

        private void btnOpenButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCloseButtonMenu.Visibility = Visibility.Visible;
            btnOpenButtonMenu.Visibility = Visibility.Collapsed;
        }

        private void btnCloseButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCloseButtonMenu.Visibility = Visibility.Collapsed;
            btnOpenButtonMenu.Visibility = Visibility.Visible;
        }
    }
}
