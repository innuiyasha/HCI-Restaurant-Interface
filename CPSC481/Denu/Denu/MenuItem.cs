using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Denu
{
    class MenuItem
    {
        private String name;
        private String description;
        private double price;
        private BitmapImage image;

        public MenuItem(String name, String desc, double price, BitmapImage image)
        {
            this.name = name;
            this.description = desc;
            this.price = price;
            this.image = image;
        }

        public String getName() {
            return name;
        }

        public String getDesc()
        {
            return description;
        }

        public String getPriceString()
        {
            return "Price: " + price.ToString();
        }

        public BitmapImage getImage()
        {
            return image;
        }
    }
}
