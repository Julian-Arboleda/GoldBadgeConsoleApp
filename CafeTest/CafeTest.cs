using CafeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeTest
{

    [TestClass]
    public class CafeTest
    {
        private MenuItem _item;
        private MenuRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _item = new MenuItem(1, "Arepas", "Corn meal griddle served with your choice of meat and cheese and includes a side of plantains and your choice of jarritos. This Colombian entree is a fan favorite in the Komodo Cafe", new List<string> { "corn meal griddle", "meat", "cheese", "plantains" }, 8.99m);
            _repo.AddMenuItem(_item);
        }

        [TestMethod]
        public void AddMenuItem_ShouldReturnAreEqual()
        {
            //Act
            int expected = 1;
            int actual = _repo.DisplayMenuItems().Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMenuItemByName_ShouldReturnCorrectItem()
        {
            MenuItem searchedItem = _repo.GetMenuItemByName("Arepas");
            Assert.AreEqual("Arepas", searchedItem.MealName);
        }

        [TestMethod]
        public void DeleteMenuItem_ShouldReturnAreEqual()
        {
            //Arrange
            _repo.DeleteMenuItem(_item);

            //Act
            int expected = -1;
            int actual = _repo.DisplayMenuItems().Count;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void DisplayMenuItems_ShouldReturnFullMenuList()
        {
            //Arrange
            MenuItem testItem = new MenuItem();
            MenuRepository testRepo = new MenuRepository();
            testRepo.AddMenuItem(testItem);

            //Act
            List<MenuItem> testMenu = testRepo.DisplayMenuItems();
            bool menuHasItems = testMenu.Contains(testItem);

            //Assert
            Assert.IsTrue(menuHasItems);
        }
    }
}

