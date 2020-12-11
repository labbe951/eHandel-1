﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class ProductManager
    {
        Product[] ArrayOfProducts = new Product[5];
        //AppManager instance = new AppManager();
        //MenuLayout instance = new MenuLayout();
        private int quantity;

        private List<Product> shoppingCartList;
        public ProductManager() 
        {
            shoppingCartList = new List<Product>();
        }
        public Product[] BasicProducts()
        {
            //Products Header = new Products();
            ArrayOfProducts[0] = new Product(1, "Canada Goose", "En varm vinterjacka.", 9999.00);
            ArrayOfProducts[1] = new Product(2, "Air Max Pro X", "Snabba skor för den som tränar!", 1299.00);
            ArrayOfProducts[2] = new Product(3, "G-Star Warp", "Stilrena byxor för den modemedvetna.", 1899.00);
            ArrayOfProducts[3] = new Product(4, "Hilfiger Star", "Snyggare T-Shirt är svårare att hitta.", 1099.00);
            ArrayOfProducts[4] = new Product(5, "Gant Hoodie", "För värme och komfort.", 1400.00);

            return ArrayOfProducts;
        }

        
        public void PrintProducts()
        {
            Product[] OurProducts = new Product[5];

            OurProducts = BasicProducts();

            for (int i = 0; i < OurProducts.Length; i++)
            {
                Console.WriteLine(OurProducts[i].GetProductID());

                PrintObjects(OurProducts[i]);
            }

        }
        

        public void PrintProductLayout()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("| Product ID     |   Product Name                     |   Unit Price         |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        
        public void PrintObjects(Product p)
        {
            Console.WriteLine($"| {p.GetProductID()}              |   {p.GetProductName()}                    |  {p.GetProductPrice()}                |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        
        
        public void GetAllProducts()
        {
            Console.Clear();
            Product[] allProducts = BasicProducts();
            Console.WriteLine("Product ID \tProduct Name \t\t\tPrice");
            Console.WriteLine("---------------------------------------------------------");

            foreach (var p in allProducts)
            {
                Console.WriteLine(p.GetProductID() + "\t\t" + p.GetProductName() + "\t\t\t" + p.GetProductPrice() + " SEK");
            }
            
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n\n[1]Pick an item to view. \n[2]Add an item to your shopping cart. \n[3]View your shopping cart. \n[0]Return to main menu. \n\nPlease, pick an option.");

            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    //Visa produkt
                    Console.WriteLine("\nWhich item would you like to view?");
                    string UserItem = Console.ReadLine();
                    int UserItemInt = Int32.Parse(UserItem);
                    Console.Clear();
                    GetProductById(UserItemInt);
                    break;
                case "2":
                    //Lägg till produkt i varukorg
                    break;
                case "3":
                    //Visa varukorg
                    break;
                case "0":
                    //Återvänd till huvudmeny
                    //instance.DisplayMainMenu();
                    break;
            }
        }
        

        /*
        public void GetProductById(int id)
        {
            Product[] ProductById = myProdManager.BasicProducts();
            int i = id;

            Console.WriteLine("Product Name \t\tProduct Description \t\t\t\tPrice");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine(ProductById[i - 1].GetProductName() + "\t\t" + ProductById[i - 1].GetProductInfo() + "\t\t" + ProductById[i - 1].GetProductPrice());
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine("\n\n[1]Add item to your shopping cart. \n[2]Return to \"Show all items\". \n[0]Return to main menu. \n\nPlease, pick an option.");

            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    //Lägg till vara i varukorg
                    break;
                case "2":
                    //Återvänd till visa alla produkter
                    Console.Clear();
                    GetAllProducts();
                    break;
                case "0":
                    //Återvänd till huvudmenyn
                    instance.RunProgram();
                    break;
            }

        }
        */

        public Product GetProductById(int id)
        {
            Product[] ProductById = BasicProducts();
            return ProductById[id - 1];
        }

        public void AddToShoppingCart(Product item)
        {
            SetShoppingCart(item);
            //shoppingCartList.Add(new Product(6, "Test", "Enkelt test", 1200.00));
            Console.WriteLine("Desired quantity?");
            SetQuantity(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(quantity + " items added to your shopping cart!");
            /*
            foreach (var p in shoppingCartList)
            {
                Console.WriteLine(p.GetProductName() + "\t\t" + p.GetProductID() + "\t\t\t" + p.GetProductPrice() + " SEK");
            }
            Console.ReadLine();
            */
        }

        public void TestShoppingCartList()
        {
            shoppingCartList.Add(new Product(6, "Test", "Enkelt test", 1200.00));
        }

        public List<Product> GetShoppingCart()
        {
            Console.WriteLine(shoppingCartList.Count());
            return this.shoppingCartList;
        }

        private void SetShoppingCart(Product item)
        {
            Console.WriteLine(item.GetProductName());
            shoppingCartList.Add(item);
            Console.WriteLine(shoppingCartList.Count());
        }

        public int GetQuantity()
        {
            return quantity;
        }

        private int SetQuantity(int a)
        {
            return quantity = a;
        }
    }
}
