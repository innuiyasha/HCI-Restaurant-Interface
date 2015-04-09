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
    public partial class pendItem : UserControl
    {
        public pendItem()
        {
            InitializeComponent();
        }
        public pendItem(String name, String price, String qty) {
            
            InitializeComponent();
            NameLbl.Content = name;
            QtyLbl.Content = "x" + qty;

            char[] delimeter = { ' ' };
            String[] words = price.Split(delimeter);

            PriceLbl.Content = words[1];
        } 

        public Boolean equals(pendItem compare) {
            if (compare.NameLbl.Content.Equals(NameLbl.Content))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
