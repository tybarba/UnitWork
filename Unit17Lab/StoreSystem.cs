using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17Lab
{
    internal class StoreSystem
    {
        Dictionary<string, decimal> Items = new Dictionary<string, decimal>();

        public void RunStoreSystem()
        {
            string userResponse;
            bool keepGoing = true;
            do
            {
                DisplayMenu();
                userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        RemoveItem();
                        break;
                    case "3":
                        LookUpPrice();
                        break;
                    case "4":
                        IncreasePrice();
                        break;
                    case "5":
                        DisplayAllItems();
                        break;
                    case "6":
                        keepGoing = false;
                        break;
                }

            } while (keepGoing);
        }

        public void AddItem()
        {
            string itemName;
            string itemPriceString;
            decimal itemPrice;

            Console.Write("Enter an item name: ");
            itemName = Console.ReadLine();
            Console.Write($"Enter the price of {itemName}: ");
            itemPriceString = Console.ReadLine();
            itemPrice = decimal.Parse(itemPriceString);
            Items[itemName] = itemPrice;
            Console.WriteLine($"{itemName}: {itemPrice} has been added.");
            SleepAndClear();
        }
        private void SleepAndClear()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void RemoveItem()
        {
            Console.Write("Enter the name of the item to remove: ");
            string itemName = Console.ReadLine();
            Items.Remove(itemName);
            Console.WriteLine($"{itemName} has been removed.");
            SleepAndClear();
        }
        public void DisplayMenu()
        {
            Console.WriteLine("(1) Add an item\r\n(2) Remove an item\r\n(3) Lookup the price of an item\r\n(4) Increase the price of an item\r\n(5) Display all items\r\n(6) Exit");
        }

        public void LookUpPrice()
        {
            Console.Write("Which item do you want to know the price of? ");
            string itemName = Console.ReadLine();
            try
            {
                decimal itemPrice = Items[itemName];
                Console.WriteLine($"{itemName} costs {itemPrice}.");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("No item was found with that name." + ex.Message);
            }
            finally
            {
                SleepAndClear();
            }

        }

        public void IncreasePrice()
        {
            Console.Write("Which item do you want to increase the price of? ");
            string itemName = Console.ReadLine();
            try
            {
                decimal itemPrice = Items[itemName];
                Console.WriteLine($"{itemName} currently costs {itemPrice}.");
                Console.Write("How much do you want to increase it by? ");
                decimal priceIncrease = decimal.Parse(Console.ReadLine());
                Items[itemName] = itemPrice + priceIncrease;
                Console.WriteLine($"{itemName} now costs {itemPrice + priceIncrease}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No item was found with that name." + ex.Message);
            }
            finally
            {
                SleepAndClear();
            }
        }

        public void DisplayAllItems()
        {
            List<string> items = Items.Keys.ToList();
            items.Sort();
            foreach (var item in items)
            {
                Console.WriteLine(item + ": " +Items[item]);
            }
            SleepAndClear();
        }
    }
}
