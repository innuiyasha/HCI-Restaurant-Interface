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
        Dictionary<String, MenuItem> menu;
        MenuItem selectedItem = null;

        public MainWindow()
        {
            InitializeComponent();

            menu = new Dictionary<String, MenuItem>();

            //STILL NEEDED a list of allerges for each item

            //Drink~~~~~~~~~~~~~
            //Draft Beer by pint
            menu.Add("Coors Banquet", new MenuItem("Coors Banquet", "It's uh, it's a pint of Coors Banquet", 4.75, new BitmapImage(new Uri("FoodDrink/RumNCoke.jpg", UriKind.Relative))));
            menu.Add("Coors Light", new MenuItem("Coors Light", "It's uh, it's a pint of Coors Light", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Canadian", new MenuItem("Canadian", "Le Canadien du Molson, eh", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("MGD", new MenuItem("MGD", "Burr", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Pilsner", new MenuItem("Pilsner", "Burr", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Rickard's Red", new MenuItem("Rickard's Red", "Rickard's of the red variety", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Rickard's White", new MenuItem("Rickard's White", "Rickard's of the white variety", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Premium Draft
            menu.Add("Granville Seasonal", new MenuItem("Granville Seasonal", "Granville yo, it's good", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Guiness", new MenuItem("Guiness", "Dark and earthy", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Newcastle Brown", new MenuItem("Newcastle Brown", "Sounds um, brown I guess", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Strongbow", new MenuItem("Strongbow", "Surprisingly light given the name", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Bottled Beer
            menu.Add("Alexander Keith's", new MenuItem("Alexander Keith's", "Personal preference", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Budweiser", new MenuItem("Budweiser", "Yum-ish, sort of, like if you're into that", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Kokanee", new MenuItem("Kokanee", "Not too bad", 4.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            
            //Premium Bottled Beer
            menu.Add("Big Rock Grasshopper", new MenuItem("Big Rock Grasshopper", "Does it contain grasshoppers? Who knows...", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Big Rock Traditional", new MenuItem("Big Rock Traditional", "Does it contain traditions? Who knows...", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Corona", new MenuItem("Corona", "M-m-m-my Corona", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Heineken", new MenuItem("Heineken", "Heiny CAN!", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Mill St. Organic", new MenuItem("Mill St. Organic", "No pesticides, unlike everything else.....", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Mill St. Tankhouse", new MenuItem("Mill St. Tankhouse", "Straight from the tankhouse, wherever that is", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Steamwhistle", new MenuItem("Steamwhistle", "Woot woo", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Tall Boys
            menu.Add("Innis & Gunn", new MenuItem("Innis & Gunn", "Innis a great beer?", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Mill St. Lemon Tea", new MenuItem("Mill St. Lemon Tea", "Lemon? Tea? Sure...", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Moosehead", new MenuItem("Moosehead", "Not as dirty as it sounds", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Rolling Rock", new MenuItem("Rolling Rock", "Rock and roll", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Steigl Radler (Grapefruit)", new MenuItem("Steigl Radler (Grapefruit)", "Das grapefruit beer", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Coolers
            menu.Add("Smirnoff Ice", new MenuItem("Smirnoff Ice", "Smearing off the ice", 5.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Wine
            menu.Add("Jacob's Creek Chardonnay", new MenuItem("Jacob's Creek Chardonnay", "Chardon you?", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Jacob's Creek Shiraz Cabernet", new MenuItem("Jacob's Creek Shiraz Cabernet", "Tastes better than a creek, I'll bet", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Non-Alcoholic
            menu.Add("O'Douls", new MenuItem("O'Douls", "Tipsy? Not on this you ain't", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Specialty Coffees
            menu.Add("Irish Mocha", new MenuItem("Irish Mocha", "Coffee and Carolans Irish Cream", 5.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Irish Coffee", new MenuItem("Irish Mocha", "Coffee and Jameson Irish Whiskey", 5.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Spanish Coffee", new MenuItem("Spanish Coffee", "No one expects the Coffee, Havana Club rum, and Triple Sec!", 5.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Spiced Butter Coffee", new MenuItem("Spiced Butter Coffee", "Coffee, Lamb’s Spiced Rum, and butterscotch schnapps", 5.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("B52", new MenuItem("B52", "Coffee, Carolans Irish Cream, coffee liqueur, and Triple Sec", 5.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Classic Cocktails
            menu.Add("Bombay Gin and Tonic", new MenuItem("Bombay Gin and Tonic", "Bombay Sapphire gin, tonic water, twist of lime", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Caesar", new MenuItem("Caesar", "Absolut vodka, Tabasco, Worcestershire, lime juice, clamato", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Cuba Libre", new MenuItem("Cuba Libre", "Havana Club rum, Pepsi, lime juice", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Jack and Ginger", new MenuItem("Jack and Ginger", "Jack Daniels, ginger ale, and a twist of lime", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("SoCo and 7-UP", new MenuItem("SoCo and 7-UP", "Southern Comfort, 7-UP, and a twist of lemon", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Refreshing Choices
            menu.Add("Blue Hawaiian Apple", new MenuItem("Blue Hawaiian Apple", "Absolut vodka, Apple Sour Puss, Blue Curacao, pineapple juice, club soda", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Hard Lemonade", new MenuItem("Hard Lemonade", "Absolut vodka and lemonade", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Limoncello Lemonade", new MenuItem("Limoncello Lemonade", "Limoncello, Absolut vodka, and lemonade", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Tequila Sunrise", new MenuItem("Tequila Sunrise", "Olmeca tequila, orange juice, lime juice, and grenadine", 5.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Perk-ups
            menu.Add("Coffee", new MenuItem("Coffee", "One free refill with meal purchase", 1.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Tea", new MenuItem("Tea", "One free refill with meal purchase", 1.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Pop
            menu.Add("Iced Tea", new MenuItem("Iced Tea", "One free refill with meal purchase", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Pepsi", new MenuItem("Pepsi", "One free refill with meal purchase", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Ginger Ale", new MenuItem("Ginger Ale", "One free refill with meal purchase", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("7-UP", new MenuItem("7-UP", "One free refill with meal purchase", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            
            //Juice
            menu.Add("Cranberry", new MenuItem("Cranberry", "NO free refills", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Orange", new MenuItem("Orange", "NO free refills", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Lemonade", new MenuItem("Lemonade", "NO free refills", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Clamato", new MenuItem("Clamato", "NO free refills", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Milk", new MenuItem("Milk", "NO free refills", 2.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Food~~~~~~~~~~~~~~~~~~~~
            //Snacks
            menu.Add("Chicken Fingers", new MenuItem("Chicken Fingers", "Served with fries and plum sauce", 9.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("The Den Dip Trio", new MenuItem("The Den Dip Trio", "Spinach and artichoke dip (served cold), tuscan white bean herb hummus with charred lemon and pico de gallo. Served with tortilla chips, pita chips, carrot and celery sticks", 9.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Nachos", new MenuItem("Nachos", "Tri-coloured tortilla chips, tomatoes, black olives, jalapeños, green onions, and mixed cheese. Served with salsa and sour cream", 14.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Deep Fried Breaded Agnolotti Pasta", new MenuItem("Deep Fried Breaded Agnolotti Pasta ", "8pcs filled with mozzarella cheese. Served with a tomato pesto sauce.", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Tempura Extreme Beans", new MenuItem("Tempura Extreme Beans", "10pcs of fried spicy pickled green beans tossed in paprika and rosemary", 7.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Edamame Beans", new MenuItem("Edamame Beans", "Steamed and tossed in sesame ginger lime salt", 6.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Basket of Onion Rings", new MenuItem("Basket of Onion Rings", "Served with roasted garlic aioli", 7.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Basket of Rosemary French Fries", new MenuItem("Basket of Rosemary French Fries", "Delicious fries tossed in a rosemary spice", 5.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Poutines
            menu.Add("Den Poutine", new MenuItem("Den Poutine", "Authentic Québec cheese curds and house-made gravy", 9.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("The Tub Tub Poutine", new MenuItem("The Tub Tub Poutine", "Buffalo chicken fingers, authentic Québec cheese curds, house-made gravy, ranch dressing, and green onions", 10.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Jalapeño Bacon Club Poutine", new MenuItem("Jalapeño Bacon Club Poutine", "Chicken finger slices, peppered bacon, pico de gallo, green onions, diced jalapeños, authentic Québec cheese curds and house-made gravy", 10.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Breakfast Poutine", new MenuItem("Breakfast Poutine", "Crumbled peppered bacon, sautéed onions and mushrooms, topped with a sunny side up egg and authentic Québec cheese curds with house-made gravy", 11.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Burgers
            menu.Add("Classic Cheeseburger", new MenuItem("Classic Cheeseburger", "Served on a pretzel kaiser bun with lettuce, tomato, shaved red onion, cheddar cheese, and topped with a dill pickle spear", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Homemade Vegan BBQ Black Bean Veggie Burger ", new MenuItem("Homemade Vegan BBQ Black Bean Veggie Burger ", "Served on a pretzel kaiser bun with lettuce, tomato, shaved red onion, cheddar cheese, and topped with a dill pickle spear. With guacomole and sautéed mushrooms.", 11.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("The Den Burger", new MenuItem("The Den Burger", "Served on a pretzel kaiser bun with lettuce, tomato, shaved red onion, cheddar and mozzarella cheese, and topped with a dill pickle spear. With sautéed mushroom mix, and crisp bacon.", 12.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("California BBQ Burger", new MenuItem("California BBQ Burger", "Served on a pretzel kaiser bun with lettuce, tomato, shaved red onion, cheddar cheese, and topped with a dill pickle spear. With Jack Daniel's BBQ sauce, crisp bacon, and sliced avocado.", 12.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Ring O’ Fire Burger", new MenuItem("Ring O’ Fire Burger", "Served on a pretzel kaiser bun with lettuce, tomato, shaved red onion, and topped with a dill pickle spear. With Chipotle lime sauce, jalapeños, pico de gallo, and jalapeño Havarti cheese.", 12.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Sandwiches etc.
            menu.Add("Buffalo Chicken Wrap", new MenuItem("Buffalo Chicken Wrap", "Buffalo chicken fingers, lettuce, tomato, and ranch sauce in a tomato tortilla", 10.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Sirloin Steak Sandwich", new MenuItem("Sirloin Steak Sandwich", "On garlic ciabatta bread with caramelized onions and sautéed mushrooms", 12.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Avocado Chicken Club", new MenuItem("Avocado Chicken Club", "Adobo grilled chicken breast, roasted garlic mayo, leaf lettuce, sliced tomato, sliced avocado, and smoky bacon on toasted ciabatta bread", 12.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("BBQ Chicken Club", new MenuItem("BBQ Chicken Club", "Grilled chicken breast, smoky bacon, lettuce, tomato, roasted garlic mayo, and Jack Daniel’s BBQ sauce on a toasted pretzel bun", 10.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Cuban Flank Steak Beef Dip", new MenuItem("Cuban Flank Steak Beef Dip", "Roasted jalapeño mojo marinated beef flank steak, honey sage aioli, caramelized onions and mushrooms, and swiss cheese on a toasted sweet potato roll, served with au jus", 12.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Crispy Quinoa & Red Lentil Wrap", new MenuItem("Crispy Quinoa & Red Lentil Wrap", "Tuscan white bean hummus, Sriracha lentils, mixed mushrooms, panko crumbs, onions, guacamole, roasted red pepper, pico de gallo, and lettuce on a whole wheat wrap", 9.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Fish & Chips", new MenuItem("Fish & Chips", "8oz battered haddock, fried until golden brown. Served with fries, apple cider vinegar marinated coleslaw, roasted jalapeño, and charred lemon tartar sauce", 13.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Butter Chicken", new MenuItem("Butter Chicken", "Chicken breast simmered in a creamy tomato, cashew and fenugreek sauce. Served with naan bread and basmati rice", 13.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Monterrey Fish Taco", new MenuItem("Monterrey Fish Taco", "Roasted poblano salsa verde, seared Mahi Mahi, grilled pineapple cilantro salsa, and apple cider vinegar marinated coleslaw", 11.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Carne Asada Taco", new MenuItem("Carne Asada Taco", "Roasted jalapeño mojo marinated beef flank steak, guacamole, pico de gallo, and apple cider vinegar marinated coleslaw", 11.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Pollo Tinga Taco", new MenuItem("Pollo Tinga Taco", "ho pepper braised pulled chicken breast, guacamole, grilled pineapple cilantro salsa, and apple cider vinegar marinated coleslaw. ", 11.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Grilled Vegetable Pappardelle Pasta", new MenuItem("Grilled Vegetable Pappardelle Pasta", "Grilled eggplant, zucchini, red onion, red peppers, and sautéed mushrooms in a fire roasted marinara sauce", 12.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Carbonara Pappardelle", new MenuItem("Carbonara Pappardelle", "Grilled eggplant, zucchini, red onion, red peppers, and sautéed mushrooms with a house made pancetta in a cream sauce", 13.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Ancho Chicken Pappardelle", new MenuItem("Ancho Chicken Pappardelle", "In house made pulled ancho marinated chicken, grilled eggplant, zucchini, red onion, red peppers, and sautéed mushrooms in a fire roasted marinara sauce", 13.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Extras
            menu.Add("Garlic Toast", new MenuItem("Garlic Toast", "Garlic!", 1.75, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Cheese Toast", new MenuItem("Cheese Toast", "Mmm, cheesy!", 3.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Gravy", new MenuItem("Gravy", "Would you like some meal with that gravy?", 2.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Sour Cream", new MenuItem("Sour Cream", "For your potatoes, or whatever", 1.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Salsa", new MenuItem("Salsa", "Salsa!", 1.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Guacomole", new MenuItem("Guacomole", "Gwhack-a-mole", 2.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Jalapeños", new MenuItem("Jalapeños", "Spicy!", 1.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Desserts
            menu.Add("Lime Tart", new MenuItem("Lime Tart", "Smooth lime curd with toasted coconut whipped cream", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Molten Turtle Cake", new MenuItem("Molten Turtle Cake", "Warm dark chocolate cake with a caramel centre,toasted pecans and toasted coconut whipped cream", 6.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Salads
            menu.Add("House Salad", new MenuItem("House Salad", "Baby organic greens, cucumber, grape tomatoes, carrot, and crispy quinoa with Italian dressing", 4.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Caesar Salad", new MenuItem("Caesar Salad", "Romaine lettuce, creamy garlic dressing, croutons, and Parmesan cheese", 4.25, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Cobb Salad", new MenuItem("Cobb Salad", "Grilled chicken breast strips, peppered bacon, sliced boiled egg, garlic Boursin cheese, avocado, and grape tomatoes with herb ranch dressing", 10.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Romaine Wedge Salad", new MenuItem("Romaine Wedge Salad", "Artisan baby romaine half, house-made pancetta, garlic Boursin cheese, roasted red peppers, grape tomatoes, and polenta crisps with herb ranch dressing", 10.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Chicken Taco Salad", new MenuItem("Chicken Taco Salad", "Red peppers, cucumber, chipotle lime chicken, Pico de Gallo, and shredded cheese. Served in a tomato tortilla bowl with cilantro black bean vinaigrette", 10.50, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Greek Salad", new MenuItem("Greek Salad", "Cucumber, grape tomatoes, sweet peppers, Feta cheese, and lemon oregano vinaigrette on a bed of romaine lettuce", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));

            //Pizza
            menu.Add("Classic Pepperoni 8\"", new MenuItem("Classic Pepperoni 8\"", "Pepperoni, tomato sauce, and mozzarella", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Meat Supreme 8\"", new MenuItem("Meat Supreme 8\"", "Honey ham, bacon, pepperoni, tomato sauce, and mozzarella cheese", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Hawaiian", new MenuItem("Hawaiian", "Honey ham, pineapple, tomato sauce, and mozzarella cheese", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Four Cheese", new MenuItem("Four Cheese", "Parmesan, cheddar, mozzarella, and feta", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Grilled Vegetable", new MenuItem("Grilled Vegetable", "Grilled portobello mushroom, peppers, red onion, zucchini, black olives, and feta cheese", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Taco", new MenuItem("Taco", "Pizza sauce, salsa, peppers, red onion, and taco beef", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
            menu.Add("Chicken Carbonara", new MenuItem("Chicken Carbonara", "Grilled chicken, bacon, diced tomato, alfredo sauce, and mozzarella cheese", 10.00, new BitmapImage(new Uri("FoodDrink/gin-and-tonic.jpg", UriKind.Relative))));
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
            else if (sureTxt.Text.Equals("Is everyone ready to place their order?"))
            {
                confirmGrd.Visibility = Visibility.Hidden;
                dialogGrid.Visibility = Visibility.Hidden;
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
            sureTxt.Text = "Is everyone ready to place their order?";
            confirmGrd.Visibility = Visibility.Visible;
            dialogGrid.Visibility = Visibility.Visible;
        }

        private void orderItem(object sender, MouseButtonEventArgs e)
        {
            Image itemGridImage = (Image)sender;
            Grid itemGrid = (Grid)itemGridImage.Parent;
            pendItem item = (pendItem)itemGrid.Parent;

            item.checkImg.Visibility = Visibility.Hidden;
            item.pendImg.Visibility = Visibility.Visible;
        }

        private void itemPress(object sender, MouseButtonEventArgs e)
        {
            Label itemClicked = (Label)sender;
            selectedItem = menu[(String) itemClicked.Content];


            itemImg.Source = selectedItem.getImage();
            descTxt.Text = selectedItem.getDesc();
            priceLbl.Content = selectedItem.getPriceString();
            itemLbl.Content = selectedItem.getName();

            qtyLbl.Content = "1";

            addBtn.Content = "Add to Order";

            for (int i = 0; i < pendLst.Items.Count; i++)
            {
                pendItem itemAt = (pendItem)pendLst.Items.GetItemAt(i);
                if (selectedItem.getName().Equals(itemAt.NameLbl.Content.ToString()))
                {
                    String loadedLbl = itemAt.QtyLbl.Content.ToString();
                    char[] deliminator = {'x'};
                    String[] words = loadedLbl.Split(deliminator);
                    qtyLbl.Content = words[words.Length - 1];
                     addBtn.Content = "Update Order";

                    break;
                }
            }


            // Will render the "Add to Order" button clickable

            //CHECK if order is in pending or not and change button appropriately
            addBtn.IsEnabled = true;
            if (qtyLbl.Content.Equals("1"))
            {
                decrementBtn.IsEnabled = false;
            } else {
                decrementBtn.IsEnabled = true;
            }
            if (qtyLbl.Content.Equals("99")) {
                incrementBtn.IsEnabled = false;
            }
            else
            {
                incrementBtn.IsEnabled = true;
            }
            qtyLbl.IsEnabled = true;
        }

        private void addItem(object sender, RoutedEventArgs e)
        {
            if (addBtn.Content.Equals("Add to Order"))
            {
                if (!itemLbl.Content.Equals(""))
                {
                    billGrd.Visibility = Visibility.Visible;

                    pendItem tmp = new pendItem(itemLbl.Content.ToString(), priceLbl.Content.ToString(), qtyLbl.Content.ToString());
                    tmp.checkImg.MouseLeftButtonUp += orderItem;
                    tmp.pendImg.MouseLeftButtonUp += serveConfirm;
                    tmp.cancelImg.MouseLeftButtonUp += x1Pend;

                    pendLst.Items.Add(tmp);

                    // Will make other portions of the display visible such as the bill and pending
                    thePendGrd.Visibility = Visibility.Visible;
                    billBrd.Visibility = Visibility.Visible;
                }
            }
            else
            {
                pendItem newItem = new pendItem(itemLbl.Content.ToString(), priceLbl.Content.ToString(), qtyLbl.Content.ToString());

                newItem.checkImg.MouseLeftButtonUp += orderItem;
                newItem.pendImg.MouseLeftButtonUp += serveConfirm;
                newItem.cancelImg.MouseLeftButtonUp += x1Pend;
                for (int i = 0; i < pendLst.Items.Count; i++)
                {
                    pendItem indexItem = (pendItem)pendLst.Items.GetItemAt(i);
                    if (indexItem.equals(newItem))
                    {
                        if (indexItem.pendImg.Visibility == Visibility.Visible)
                        {
                            newItem.pendImg.Visibility = Visibility.Visible;
                            newItem.checkImg.Visibility = Visibility.Hidden;
                        }

                        Console.WriteLine(i);
                        pendLst.Items.RemoveAt(i);
                        pendLst.Items.Insert(i, newItem);
                        break;
                    }
                }
            }
            addBtn.Content = "Update Order";
        }

        private void x1Pend(object sender, MouseButtonEventArgs e)
        {
            Image itemGridImage = (Image)sender;
            Grid itemGrid = (Grid)itemGridImage.Parent;
            pendItem item = (pendItem)itemGrid.Parent;

            pendLst.Items.Remove(item);
        }

        // For now this method is being written as if the server verifies each item independantly. 
        private void serveConfirm(object sender, MouseButtonEventArgs e)
        {
            Image itemGridImage = (Image)sender;
            Grid itemGrid = (Grid)itemGridImage.Parent;
            pendItem item = (pendItem)itemGrid.Parent;


            String totalString = totalLbl.Content.ToString();
            Char[] delimiter = { 'x', ' ' };
            String[] oldWords = totalString.Split(delimiter);
            // 0: "Total:" 1: price

            Double oldPrice = Double.Parse(oldWords[oldWords.Length - 1]);

            String[] newWords = item.PriceLbl.Content.ToString().Split(delimiter);
            // First item(0: "", 1: price), Next items(0: price)

            Double newPrice = Double.Parse(item.PriceLbl.Content.ToString());

            String[] qtyWords = item.QtyLbl.Content.ToString().Split(delimiter);
            int qty = int.Parse(qtyWords[qtyWords.Length - 1]);


            receiptLst.Items.Add(new receiptItem(qty + "x " + item.NameLbl.Content.ToString(), "" + (newPrice * qty)));

            pendLst.Items.Remove(item);

            totalLbl.Content = oldPrice + (newPrice * qty);

            theRcptGrd.Visibility = Visibility.Visible;
            rcptBrd.Visibility = Visibility.Visible;
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            confirmGrd.Visibility = Visibility.Hidden;
            dialogGrid.Visibility = Visibility.Hidden;
            okBtn.Visibility = Visibility.Hidden;
            yesBtn.Visibility = Visibility.Visible;
            noBtn.Visibility = Visibility.Visible;

            foodGrd.Visibility = Visibility.Hidden;
            drinkGrd.Visibility = Visibility.Visible;

            billGrd.Visibility = Visibility.Hidden;
            welcomeGrd.Visibility = Visibility.Visible;

            itemImg.Source = null;
            priceLbl.Content = "";
            itemLbl.Content = "";
            descTxt.Text = "";
        }

        private void increment(object sender, RoutedEventArgs e)
        {
            decrementBtn.IsEnabled = true;
            if(Convert.ToInt32(qtyLbl.Content) >= 98) {
                qtyLbl.Content = "99";
                incrementBtn.IsEnabled = false;
            }
            else
            {
                int tempQty = Convert.ToInt32(qtyLbl.Content);
                qtyLbl.Content = tempQty + 1;
            }
        }

        private void decrement(object sender, RoutedEventArgs e)
        {
            incrementBtn.IsEnabled = true;
            if (Convert.ToInt32(qtyLbl.Content) <= 2)
            {
                qtyLbl.Content = "1";
                decrementBtn.IsEnabled = false;
            }
            else
            {
                int tempQty = Convert.ToInt32(qtyLbl.Content);
                qtyLbl.Content = tempQty - 1;
            }
        }

        private void pendItemClicked(object sender, MouseButtonEventArgs e)
        {
            if (pendLst.SelectedIndex != -1)
            {
                pendItem item = (pendItem)pendLst.SelectedItem;
                Label tmp = new Label();
                tmp.Content = item.NameLbl.Content.ToString();

                itemPress(tmp, e);
            }
        }
    }
}
