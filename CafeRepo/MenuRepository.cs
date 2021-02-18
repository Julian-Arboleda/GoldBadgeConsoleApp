using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo
{
    public class MenuRepository
    {
        readonly private List<MenuItem> _menuDirectory = new List<MenuItem>();

        public void AddMenuItem(MenuItem item)
        {
            _menuDirectory.Add(item);
        }

        public MenuItem GetMenuItemByName(string name)
        {
            foreach (MenuItem item in _menuDirectory)
            {
                if (item.MealName.ToLower() == name.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public bool DeleteMenuItem(MenuItem item)
        {
            bool wasDeleted = _menuDirectory.Remove(item);
            return wasDeleted;
        }

        public List<MenuItem> DisplayMenuItems()
        {
            return _menuDirectory;
        }
    }
}
