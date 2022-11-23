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

namespace GameWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Visibility == Visibility.Visible)
            {
                LoginPage.Visibility = Visibility.Collapsed;
                RegisterPage.Visibility = Visibility.Visible;
            }
            else
            {
                LoginPage.Visibility = Visibility.Visible;
                RegisterPage.Visibility = Visibility.Collapsed;
            }
        }

        private void Save_Clic(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
