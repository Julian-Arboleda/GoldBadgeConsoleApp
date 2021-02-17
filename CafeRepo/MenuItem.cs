using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo
{
    public class MenuItem
    {

        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string MealDescription { get; set; }
        public List<string> ListOfIngredients { get; set; }
        public decimal Price { get; set; }

        //Empty Constructor
        public MenuItem() { }

        //Filled Constructor
        public MenuItem(int number, string name, string description, List<string> listOfIngredients, decimal price)
        {
            MealNumber = number;
            MealName = name;
            MealDescription = description;
            ListOfIngredients = listOfIngredients;
            Price = price;
        }
    }
}
