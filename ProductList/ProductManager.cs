using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    internal class ProductManager
    {
        private List<Product> products = new List<Product>();

        // Method to add sample data
        public void AddSampleData()
        {
            products.Add(new Product("Electronics", "Computer", 2750));
            products.Add(new Product("Electronics", "Mobile", 1255));
            products.Add(new Product("Clothing", "T-Shirt", 20));
            products.Add(new Product("Clothing", "Jeans", 50));
            products.Add(new Product("Books", "Novel", 15));
            products.Add(new Product("Books", "Textbook", 100));
        }

        // Method to add a new product
        public void AddProduct()
        {
            try
            {
                string category = GetCategory();
                string name = GetName();
                int price = GetPrice();

                Product product = new Product(category, name, price);
                products.Add(product);

                DisplaySuccessMessage("Successfully added product!");

            }
            catch (Exception e)
            {
                DisplayErrorMessage(e.Message);
            }

        }

        // Method to get category input from the user
        private static string GetCategory()
        {
            Console.Write("Enter a Category: ");
            string category = Console.ReadLine();
            ArgumentException.ThrowIfNullOrEmpty(category);
            return category;
        }

        // Method to get product name input from the user
        private static string GetName()
        {
            Console.Write("Enter a Product Name: ");
            string name = Console.ReadLine();
            ArgumentException.ThrowIfNullOrEmpty(name);
            return name;
        }

        // Method to get product price input from the user
        private static int GetPrice()
        {
            Console.Write("Enter a Price: ");
            int price = int.Parse(Console.ReadLine());
            return price;
        }

        // Method to display success message
        private static void DisplaySuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Method to display error message
        public static void DisplayErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Method to list products
        public void ListProducts()
        {
            DisplayHeader();
            DisplaySortedProducts();
            DisplayTotalAmount();
            DisplayFooter();
        }

        // Method to display header of product list
        private static void DisplayHeader()
        {
            Console.WriteLine("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
            Console.ResetColor();
        }

        // Method to display products sorted by price
        private void DisplaySortedProducts()
        {
            List<Product> sortedList = SortProducts();
            foreach (Product item in sortedList)
            {
                DisplayProduct(item);
            }
        }

        // Method to sort products by price
        private List<Product> SortProducts()
        {
            return [.. products.OrderBy(product => product.Price)];
        }

        // Method to display a single product
        private static void DisplayProduct(Product item)
        {
            Console.WriteLine(item.Category.PadRight(20) + item.Name.PadRight(20) + item.Price.ToString());

        }

        // Method to display total amount
        private void DisplayTotalAmount()
        {
            int totalAmount = products.Sum(product => product.Price);
            Console.WriteLine();
            Console.WriteLine("".PadRight(20) + "Total amount:".PadRight(20) + totalAmount.ToString().PadRight(20));
        }

        // Method to display footer of product list
        private static void DisplayFooter()
        {
            Console.WriteLine("---------------------------------------------");
        }

        // Method to search for a product
        public void SearchProduct()
        {
            string keyword = GetSearchKeyword();

            List<Product> sortedList = SortProducts();
            DisplayHeader();
            foreach (Product item in sortedList)
            {
                if (item.Name == keyword)
                {
                    DisplayHighlightedProduct(item);
                }
                else
                {
                    DisplayProduct(item);
                }
            }
            DisplayFooter();

        }

        // Method to get search keyword input from the user
        private static string GetSearchKeyword()
        {
            Console.Write("Enter a Product Name: ");
            string keyword = Console.ReadLine();
            return keyword;
        }

        // Method to display a highlighted product
        private static void DisplayHighlightedProduct(Product item)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(item.Category.PadRight(20) + item.Name.PadRight(20) + item.Price.ToString());
            Console.ResetColor();
        }
    }
}
