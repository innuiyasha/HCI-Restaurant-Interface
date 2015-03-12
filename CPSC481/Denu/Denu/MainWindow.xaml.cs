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
            dialogGrid.Visibility = Visibility.Hidden;
        }

        private void confirmCall(object sender, RoutedEventArgs e)
        {
            sureTxt.Text = "Are you sure you want to call the server?";
            confirmGrd.Visibility = Visibility.Visible;
            dialogGrid.Visibility = Visibility.Visible;
        }

        private void confirm(object sender, RoutedEventArgs e)
        {
            if (sureTxt.Text.Equals("Are you sure you want to checkout?")){
                sureTxt.Text = "Your waiter will be with you shortly!";
                yesBtn.Visibility = Visibility.Hidden;
                noBtn.Visibility = Visibility.Hidden;
                okBtn.Visibility = Visibility.Visible;
            }
            else
            {
                confirmGrd.Visibility = Visibility.Hidden;
                dialogGrid.Visibility = Visibility.Hidden;
            }
            //trigger activation of stuff
        }

        private void checkout(object sender, RoutedEventArgs e)
        {
            sureTxt.Text = "Are you sure you want to checkout?";
            confirmGrd.Visibility = Visibility.Visible;
            dialogGrid.Visibility = Visibility.Visible;
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
            dialogGrid.Visibility = Visibility.Visible;
        }

        private void orderItem1(object sender, MouseButtonEventArgs e)
        {
            checkImg1.Visibility = Visibility.Hidden;
            pendImg1.Visibility = Visibility.Visible;
        }

        private void hb1Press(object sender, MouseButtonEventArgs e)
        {
            itemImg.Source = new BitmapImage(new Uri("FoodDrink/RumNCoke.jpg", UriKind.Relative));
            priceLbl.Content = "Price: $7.99";
            qtyPriceLbl.Content = "Total: $7.99";
            itemLbl.Content = "Rum & Coke";
        }

        private void hb2Press(object sender, MouseButtonEventArgs e)
        {
            itemImg.Source = new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative));
            priceLbl.Content = "Price: $7.99";
            qtyPriceLbl.Content = "Total: $7.99";
            itemLbl.Content = "Gin & Tonic";
        }

        private void addItem(object sender, RoutedEventArgs e)
        {
            if(!itemLbl.Content.Equals("")){
                pendItem1Grd.Visibility = Visibility.Visible;
            }
        }

        private void xPend1(object sender, MouseButtonEventArgs e)
        {
            pendItem1Grd.Visibility = Visibility.Hidden;
        }

        private void serveConfirm(object sender, MouseButtonEventArgs e)
        {
            pendItem1Grd.Visibility = Visibility.Hidden;
            rcptItemGrd.Visibility = Visibility.Visible;
            totalLbl.Content = "Total: $7.99";
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            confirmGrd.Visibility = Visibility.Hidden;
            dialogGrid.Visibility = Visibility.Hidden;
            welcomeGrd.Visibility = Visibility.Visible;
        }
    }
}
