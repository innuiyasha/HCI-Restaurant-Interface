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

namespace Denu
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

        private void begin(object sender, RoutedEventArgs e)
        {
            welcomeGrd.Visibility = Visibility.Hidden;
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            confirmGrd.Visibility = Visibility.Hidden;
        }

        private void confirmCall(object sender, RoutedEventArgs e)
        {
            sureTxt.Text = "Are you sure you want to call the server?";
            confirmGrd.Visibility = Visibility.Visible;
        }

        private void confirm(object sender, RoutedEventArgs e)
        {
            confirmGrd.Visibility = Visibility.Hidden;
            //trigger activation of stuff
        }

        private void checkout(object sender, RoutedEventArgs e)
        {
            sureTxt.Text = "Are you sure you want to checkout?";
            confirmGrd.Visibility = Visibility.Visible;
        }

        private void foodMenu(object sender, RoutedEventArgs e)
        {
            drinkGrd.Visibility = Visibility.Hidden;
            foodGrd.Visibility = Visibility.Visible;
        }

        private void drinkMenu(object sender, RoutedEventArgs e)
        {
            foodGrd.Visibility = Visibility.Hidden;
            drinkGrd.Visibility = Visibility.Visible;
        }

        private void confirmAll(object sender, RoutedEventArgs e)
        {
            sureTxt.Text = "Has everyone placed their order?";
            confirmGrd.Visibility = Visibility.Visible;
        }
    }
}
