using CafeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldConsoleApp
{
    class CafeUI
    {
        private MenuRepository _repo = new MenuRepository();

        public void Run()
        {
            SeedMenuList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello welcome to the new & improved Komodo Cafe with Latinx cusine \n" +
                    "Please select from the following options: \n" +
                    "1. Display whole menu \n" +
                    "2. Add new menu item \n" +
                    "3. Delete existing menu item \n" +
                    "4. Exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        {
                            DisplayMenuItems();
                            break;
                        }
                    case "2":
                        {
                            AddMenuItem();
                            break;
                        }
                    case "3":
                        {
                            DeleteMenuItem();
                            break;
                        }
                    case "4":
                        {
                            //Exit
                            continueToRun = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please select a valid option (1-4)");
                            break;
                        }
                }
            }
        }

        private void DisplayMenuItems()
        {
            Console.Clear();
            List<MenuItem> menuItems = _repo.DisplayMenuItems();
            foreach (MenuItem item in menuItems)
            {
                Console.WriteLine($"{item.MealNumber}. {item.MealName}");
                Console.WriteLine($"Description: {item.MealDescription}");
                Console.Write("Ingredients: ");
                foreach (string ingredient in item.ListOfIngredients)
                {
                    Console.Write($"{ingredient}, ");
                }
                Console.WriteLine(" \n");
                Console.WriteLine($"${item.Price}");
                Console.WriteLine(" \n" +
                    "------------");
            }
            Console.WriteLine("Press any key to return to the main screen...");
            Console.ReadKey();
        }

        private void AddMenuItem()
        {
            Console.Clear();
            MenuItem itemAdded = new MenuItem();
            Console.Write("Enter a new meal number: ");
            string mealNumber = Console.ReadLine();
            itemAdded.MealNumber = int.Parse(mealNumber);

            Console.Write("Enter the name of the new meal: ");
            itemAdded.MealName = Console.ReadLine();

            Console.Write("Describe the new meal: ");
            itemAdded.MealDescription = Console.ReadLine();

            Console.Write("Enter the ingredients in the new meal: ");
            itemAdded.ListOfIngredients = new List<string> { Console.ReadLine() };

            Console.Write("Enter the price of the new meal: ");
            string priceOfMeal = Console.ReadLine();
            itemAdded.Price = decimal.Parse(priceOfMeal);

            _repo.AddMenuItem(itemAdded);
            Console.WriteLine("Press any key to return to the main screen...");
            Console.ReadKey();
        }

        private void DeleteMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Please enter the name of the menu item you wish to delete: ");
            MenuItem itemDeleted = _repo.GetMenuItemByName(Console.ReadLine());

            _repo.DeleteMenuItem(itemDeleted);
            Console.WriteLine("Press any key to return to the main screen...");
            Console.ReadKey();
        }


        private void SeedMenuList()
        {
            Console.Clear();
            MenuItem arepas = new MenuItem(1, "Arepas", "Corn meal griddle served with your choice of meat and cheese and includes a side of plantains and your choice of jarritos. This Colombian entree is a fan favorite in the Komodo Cafe", new List<string> { "corn meal griddle", "meat", "cheese", "plantains"}, 8.99m);
            MenuItem arrozConPollo = new MenuItem(2, "Arroz Con Pollo", "Fried yellow rice served with peas, beans and cage-free chicken. served with plantains and your choice of jarritos", new List<string> { "yellow", "chicken", "peas", "beans" }, 6.99m);
            MenuItem tacos = new MenuItem(3, "Tacos", "Another fan favorite in the Komodo Cafe this taco meal comes with four steak tacos, salsa, and your favorite toppings ", new List<string> { "corn tortillas", "steak", "lettuce", "queso", "salsa", "lettuce", "onion"}, 8.99m);
            MenuItem empanadas = new MenuItem(4, "Empandas", "This Colombian entree comes with 3 golden fried empandas filled with beef and cheese", new List<string> { "corn meal", "beef", "cheese" }, 3.99m);

            _repo.AddMenuItem(arepas);
            _repo.AddMenuItem(arrozConPollo);
            _repo.AddMenuItem(tacos);
            _repo.AddMenuItem(empanadas);
        }
    }
}
