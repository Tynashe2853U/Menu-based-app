using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        enum menu
        {
            Breakfast = 1,
            Brunch,
            Drinks,
            Desert,
            Exit,
        }
        public static void breakfast()
        {
            Console.Clear();
            Console.WriteLine("What would you like:");
            Console.WriteLine("1.Omlet[R55]");
            Console.WriteLine("2.Freach Toast[R70]");
            Console.WriteLine("3.Breakfast Burrito[R20]");
            Console.WriteLine("4.Pancakes and maple syrup[R25]");
            Console.WriteLine("5.English breakfast[R60]");
            Console.WriteLine("<---------------------------------------------->");

            double omlet = 0;
            double french_toast = 0;
            double breakfast_burrito = 0;
            double pancakes_and_maple_syrup = 0;
            double english_breakfast = 0;
            double total_price;
            bool exit = false;
            int option = 0, quantity = 1;
            string item = "no";

            while (exit == false)
            {
                Console.Write("Select Option:");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many quantities:");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Omlet was choose");
                    if (quantity > 1)
                    {
                        omlet = omlet + (55 * quantity);
                    }
                    else
                    {
                        omlet = omlet + 55;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {

                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("What would you like:");
                        Console.WriteLine("1.Omlet[R55]");
                        Console.WriteLine("2.Freach Toast[R70]");
                        Console.WriteLine("3.Breakfast Burrito[R20]");
                        Console.WriteLine("4.Pancakes and maple syrup[R25]");
                        Console.WriteLine("5.English breakfast[R60]");
                    }
                    Console.WriteLine("<------------------------------------------->");
                    Console.WriteLine("Omlet was choosen");
                    Console.WriteLine("Total amount of omlet is  " + omlet);

                }
                else if (option == 2)
                {
                    Console.Clear();
                    if (quantity > 1)
                    {
                        french_toast = french_toast + (70 * quantity);
                    }
                    else
                    {
                        french_toast = french_toast + 70;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {

                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("What would you like:");
                        Console.WriteLine("1.Omlet[R55]");
                        Console.WriteLine("2.Freach Toast[R70]");
                        Console.WriteLine("3.Breakfast Burrito[R20]");
                        Console.WriteLine("4.Pancakes and maple syrup[R25]");
                        Console.WriteLine("5.English breakfast[R60]");
                    }
                    Console.WriteLine("<---------------------------------------------->");
                    Console.WriteLine("French toast was choosen");
                    Console.WriteLine("Total amount of french toast is  " + french_toast);

                }
                else if (option == 3)
                {
                    Console.Clear();
                    if (quantity > 1)
                    {
                        breakfast_burrito = breakfast_burrito + (20 * quantity);
                    }
                    else
                    {
                        breakfast_burrito = breakfast_burrito + 20;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {

                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("What would you like:");
                        Console.WriteLine("1.Omlet[R55]");
                        Console.WriteLine("2.Freach Toast[R70]");
                        Console.WriteLine("3.Breakfast Burrito[R20]");
                        Console.WriteLine("4.Pancakes and maple syrup[R25]");
                        Console.WriteLine("5.English breakfast[R60]");
                    }
                    Console.WriteLine("<-------------------------------------------------------->");
                    Console.WriteLine("Breakfast burrito was choosen");
                    Console.WriteLine("Total amount of breakfast burrito is  " + breakfast_burrito);
            
                }
                else if (option == 4)
                {
                    Console.Clear();
                    if (quantity > 1)
                    {
                        pancakes_and_maple_syrup = pancakes_and_maple_syrup + (25 * quantity);
                    }
                    else
                    {
                        pancakes_and_maple_syrup = pancakes_and_maple_syrup + 25;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {

                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("What would you like:");
                        Console.WriteLine("1.Omlet[R55]");
                        Console.WriteLine("2.Freach Toast[R70]");
                        Console.WriteLine("3.Breakfast Burrito[R20]");
                        Console.WriteLine("4.Pancakes and maple syrup[R25]");
                        Console.WriteLine("5.English breakfast[R60]");
                    }
                    Console.WriteLine("<------------------------------------------------------------------------>");
                    Console.WriteLine("Pancakes and maple syrup was choosen");
                    Console.WriteLine("Total amount of pancakes and maple syrup is  " + pancakes_and_maple_syrup);
  
                }
                else if (option == 5)
                {
                    Console.Clear();
                    if (quantity > 1)
                    {
                        english_breakfast = english_breakfast + (60 * quantity);
                    }
                    else
                    {
                        english_breakfast = english_breakfast + 60;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {

                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("What would you like:");
                        Console.WriteLine("1.Omlet[R55]");
                        Console.WriteLine("2.Freach Toast[R70]");
                        Console.WriteLine("3.Breakfast Burrito[R20]");
                        Console.WriteLine("4.Pancakes and maple syrup[R25]");
                        Console.WriteLine("5.English breakfast[R60]");
                    }
                    Console.WriteLine("<-------------------------------------------------------->");
                    Console.WriteLine("English breakfast was choosen");
                    Console.WriteLine("Total amount of english breakfast is  " + english_breakfast);
                    
                }
                else
                {
                    Console.WriteLine("Nothing was choosen");
                    exit = true;
                }
                total_price = omlet + french_toast + breakfast_burrito + pancakes_and_maple_syrup + english_breakfast;
                Console.WriteLine("Total is:" + total_price);
                Console.WriteLine("<-------------------------------------------------------------------------------->");

                Console.ReadKey();
            }
        }
        public static void brunch()
        {
            Console.Clear ();
            Console.WriteLine("Brunch options are:");
            Console.WriteLine("1.Waffles and Bacon [R40]");
            Console.WriteLine("2.Egg Benedict [25]");
            Console.WriteLine("3.Blueberry Cupcake [20]");
            Console.WriteLine("4.Back");
            Console.WriteLine("<---------------------------------------------->");
            double waffles_and_bacon = 0;
            double egg_benedict = 0;
            double blueberry_cupcake = 0;
            double total_price;
            bool exit = false;
            int option, quantity = 1;
            string item = "no";
            while (exit == false)
            {
                
                Console.Write("Select Option:");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many quantities:");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Waffles and bacon was choose");
                    if (quantity > 1)
                    {
                        waffles_and_bacon = waffles_and_bacon + (40 * quantity);
                    }
                    else
                    {
                        waffles_and_bacon = waffles_and_bacon + 40;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {
                        exit = true;

                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("Brunch options are:");
                        Console.WriteLine("1.Waffles and Bacon [R40]");
                        Console.WriteLine("2.Egg Benedict [25]");
                        Console.WriteLine("3.Blueberry Cupcake [20]");
                        Console.WriteLine("4.Back");
                    }
                    Console.WriteLine("<------------------------------------------->");
                    Console.WriteLine("Waffles and bacon was choosen");
                    Console.WriteLine("Total amount of Waffles and Bacon is  " + waffles_and_bacon);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    if (quantity > 1)
                    {
                        egg_benedict = egg_benedict + (25 * quantity);

                    }
                    else
                    {
                        egg_benedict = egg_benedict + 25;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {
                        exit = true;

                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("Brunch options are:");
                        Console.WriteLine("1.Waffles and Bacon [R40]");
                        Console.WriteLine("2.Egg Benedict [25]");
                        Console.WriteLine("3.Blueberry Cupcake [20]");
                        Console.WriteLine("4.Back");
                    }
                    Console.WriteLine("<---------------------------------------------->");
                    Console.WriteLine("Egg benedict was choosen");
                    Console.WriteLine("Total amount of Egg Benedict is  " + egg_benedict);
                }
                else if (option == 3)
                {
                    Console.Clear();
                    if (quantity > 1)
                    {
                        blueberry_cupcake = blueberry_cupcake + (20 * quantity);
                    }
                    else
                    {
                        blueberry_cupcake = blueberry_cupcake + 20;
                    }
                    Console.Write("Would you like to add more items(yes/no):");
                    item = Console.ReadLine();
                    if (item == ("no") || item.Equals("No"))
                    {

                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("Brunch options are:");
                        Console.WriteLine("1.Waffles and Bacon [R40]");
                        Console.WriteLine("2.Egg Benedict [25]");
                        Console.WriteLine("3.Blueberry Cupcake [20]");
                        Console.WriteLine("4.Back");

                    }
                    Console.WriteLine("<-------------------------------------------------------->");
                    Console.WriteLine("Bluberry cupcake was chosen");
                    Console.WriteLine("Total amount of blueberry cupcake is  " + blueberry_cupcake);
                }
                total_price = waffles_and_bacon + egg_benedict + blueberry_cupcake;
                Console.WriteLine("Total Is:" + total_price);
                Console.WriteLine("<-------------------------------------------------------------------------------->");
                Console.ReadLine();
            }
        }
        public static void drinks()
        {
            Console.WriteLine("Drink Options Are:");
            Console.WriteLine("1.Coffee[R25]");
            Console.WriteLine("2.Cupuccino[R30]");
            Console.WriteLine("3.Milkshake[R25]");
            Console.WriteLine("4.Breakfast Punch[R15]");

            double coffee = 0;
            double cupuccino = 0;
            double milkshake = 0;
            double breakfast_punch = 0;
            double total_price;
            bool exit = false;
            int option = 0, quantity = 1;
            string item = "no";

            while (exit == false)
            {
                Console.WriteLine("Select Option");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many quantities:");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Omlet was choose");
                    if (quantity > 1)
                    {
                        coffee = coffee + (25 * quantity);
                    }
                    else
                    {
                        coffee = coffee + 25;
                    }
                    Console.Write("Would you like to add more items(yes/no):");

                    item = Console.ReadLine();

                    if (item == ("no") || item.Equals("No"))
                    {
                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();

                        Console.WriteLine("Drink Options Are:");
                        Console.WriteLine("1.Coffee[R25]");
                        Console.WriteLine("2.Cupuccino[R30]");
                        Console.WriteLine("3.Milkshake[R25]");
                        Console.WriteLine("4.Breakfast Punch[R15]");
                    }

                    Console.WriteLine("<------------------------------------------->");
                    Console.WriteLine("coffee was choosen");
                    Console.WriteLine("Total amount of coffee is  " + coffee);
                }
                else if (option == 2)
                {

                    Console.Clear();

                    if (quantity > 1)

                    {
                        cupuccino = cupuccino + (30 * quantity);
                    }
                    else
                    {
                        cupuccino = cupuccino + 30;
                    }

                    Console.Write("Would you like to add more items(yes/no):");

                    item = Console.ReadLine();

                    if (item == ("no") || item.Equals("No"))

                    {
                        exit = true;

                    }

                    else if (item == ("yes") || item.Equals("Yes"))

                    {
                        Console.Clear();
                        Console.WriteLine("Drink Options Are:");
                        Console.WriteLine("1.Coffee[R25]");
                        Console.WriteLine("2.Cupuccino[R30]");
                        Console.WriteLine("3.Milkshake[R25]");
                        Console.WriteLine("4.Breakfast Punch[R15]");
                    }
                    Console.WriteLine("<---------------------------------------------->");
                    Console.WriteLine("cupuccino was choosen");
                    Console.WriteLine("Total amount of is cupuccino " + cupuccino);
                }
                else if (option == 3)
                {
                    Console.Clear();

                    if (quantity > 1)

                    {
                        milkshake = milkshake + (25 * quantity);
                    }

                    else

                    {
                        milkshake = milkshake + 25;
                    }

                    Console.Write("Would you like to add more items(yes/no):");

                    item = Console.ReadLine();

                    if (item == ("no") || item.Equals("No"))

                    {
                        exit = true;
                    }

                    else if (item == ("yes") || item.Equals("Yes"))

                    {
                        Console.Clear();
                        Console.WriteLine("Drink Options Are:");
                        Console.WriteLine("1.Coffee[R25]");
                        Console.WriteLine("2.Cupuccino[R30]");
                        Console.WriteLine("3.Milkshake[R25]");
                        Console.WriteLine("4.Breakfast Punch[R15]");
                    }

                    Console.WriteLine("<-------------------------------------------------------->");

                    Console.WriteLine("Milkshake was choosen");

                    Console.WriteLine("Total amount of milkshake is  " + milkshake);
                }
                else if (option == 4)
                {
                    if (quantity > 1)
                    {
                        breakfast_punch = breakfast_punch + (15 * quantity);
                    }

                    else

                    {

                        breakfast_punch = breakfast_punch + 15;

                    }

                    Console.Write("Would you like to add more items(yes/no):");

                    item = Console.ReadLine();

                    if (item == ("no") || item.Equals("No"))
                    {
                        exit = true;
                    }
                    else if (item == ("yes") || item.Equals("Yes"))
                    {
                        Console.Clear();
                        Console.WriteLine("Drink Options Are:");
                        Console.WriteLine("1.Coffee[R25]");
                        Console.WriteLine("2.Cupuccino[R30]");
                        Console.WriteLine("3.Milkshake[R25]");
                        Console.WriteLine("4.Breakfast Punch[R15]");
                    }
                    Console.WriteLine("<-------------------------------------------------------->");
                    Console.WriteLine("Breakfast Punch was choosen");
                    Console.WriteLine("Total amount of breakfast punch is  " + breakfast_punch);

                }
                else
                {
                    Console.WriteLine("Nothing was choosen");
                    exit = true;
                }
                total_price = coffee + cupuccino + milkshake + breakfast_punch;
                Console.WriteLine("Total is:" + total_price);
                Console.WriteLine("<-------------------------------------------------------------------------------->");
                Console.ReadLine();
            }
         
        }
        static void Main(string[] args)
        {
                Console.Title = "Menu";
                Console.WriteLine("1.Breakfast");
                Console.WriteLine("2.Brunch");
                Console.WriteLine("3.Drinks");
                Console.WriteLine("4.Exit");
                Console.WriteLine("<-------------------------------------------------------->");
                Console.WriteLine(" Please Select An Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch ((menu)option)
                {
                    case menu.Breakfast:
                        breakfast();
                    Console.WriteLine("<-------------------------------------------------------->");
                        break;
                    case menu.Brunch:
                        brunch();
                        Console.WriteLine("<-------------------------------------------------------->");
                        break;
                    case menu.Drinks:
                        drinks();
                        Console.WriteLine("<-------------------------------------------------------->");
                        break;
                    case menu.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                    Console.WriteLine("Invalid Option, select");
                        break;
                }
                Console.WriteLine("<-------------------------------------------------------------------------------->");
                Console.ReadKey();
           
        }
    }
}
