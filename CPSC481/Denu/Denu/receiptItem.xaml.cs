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
    /// Interaction logic for receiptItem.xaml
    /// </summary>
    public partial class receiptItem : UserControl
    {
        public receiptItem()
        {
            InitializeComponent();
        }
        public receiptItem(String name, String price)
        {
            InitializeComponent();

            nameLbl.Content = name;
            priceLbl.Content = price;
        }
    }
}
