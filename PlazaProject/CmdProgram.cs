﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class CmdProgram
    {
        private List<Product> cart=new List<Product>();
        private List<float> prices=new List<float>();
        public CmdProgram(String[] args)
        {

        }
        public void Run()
        {
            Console.WriteLine("There are no plaza created yet! Press\n" +
                "1) to create a new plaza.\n" +
                "2) to exit.");

            string userInput = Console.ReadLine();
            if(userInput.Equals("1"))
            {
                PlazaImpl plaza = new PlazaImpl();

                while(true)
                {
                    Console.WriteLine("Welcome to the Programming PLAZA! Press\n\t" +
                        "1) to list all shops.\n\t" +
                        "2) to add a new shop.\n\t" +
                        "3) to remove an existing shop.\n\t" +
                        "4) enter a shop by name.\n\t" +
                        "5) to open the plaza.\n\t" +
                        "6) to close the plaza.\n\t" +
                        "7) to check if the plaza is open or not.\n\t" +
                        "8) leave plaza.");

                    userInput = Console.ReadLine();
                    if(userInput.Equals("1"))
                    {
                        ListAllShops(plaza);
                    }

                    else if(userInput.Equals("2"))
                    {
                        AddNewShop(plaza);
                    }
                
                    else if(userInput.Equals("3"))
                    {
                        ToRemoveShop(plaza);
                    }

                    else if(userInput.Equals("4"))
                    {
                        FindShopByName(plaza);
                    }

                    else if(userInput.Equals("5"))
                    {
                        if(plaza.IsOpen())
                        {
                            Console.WriteLine("Plaza already OPEN.");
                        }
                        else
                        {
                            plaza.Open();
                        }
                    }

                    else if(userInput.Equals("6"))
                    {
                        if (!plaza.IsOpen())
                        {
                            Console.WriteLine("Plaza already CLOSED.");
                        }
                        else
                        {
                            plaza.Close();
                        }
                    }

                    else if(userInput.Equals("7"))
                    {
                        if(plaza.IsOpen())
                        {
                            Console.WriteLine("Plaza is OPEN");
                        }
                        else
                        {
                            Console.WriteLine("Plaza is CLOSED");
                        }
                    }
                    else if(userInput.Equals("8"))
                    {
                        Console.WriteLine("\nIn your cart:");
                        float needToPay = 0;
                        if (this.cart.Count > 0)
                        {
                            foreach (var item in this.cart)
                            {
                                Console.WriteLine("\t-" + item.GetName());
                            }

                            foreach (var item in this.prices)
                            {
                                needToPay += item;
                            }
                        }
                        Console.WriteLine("You need to pay: " + needToPay + "\n");
                        break;
                    }

                    else
                    {
                        throw new Exception("There was no option like that!");
                    }
                    Console.WriteLine("\n");
                }
            }
            else if(userInput.Equals("2"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                throw new Exception("No choice like that!");
            }
        }

        public void ListAllShops(PlazaImpl plaza)
        {
            List<Shop> listOfShops = plaza.GetShops();
            foreach (var shop in listOfShops)
            {
                Console.WriteLine(shop.GetName());
            }
        }

        public void AddNewShop(PlazaImpl plaza)
        {
            Console.WriteLine("What is the name of the shop?");
            string nameOfShop = Console.ReadLine();
            Console.WriteLine("Who is the owner of this shop?");
            string ownerOfShop = Console.ReadLine();

            ShopImpl shop = new ShopImpl(nameOfShop, ownerOfShop);
            plaza.AddShop(shop);
            shop.Open();
        }

        public void ToRemoveShop(PlazaImpl plaza)
        {
            Console.WriteLine("What is the name of the shop?");
            string nameOfShop = Console.ReadLine();

            plaza.RemoveShop(plaza.FindShopByName(nameOfShop));
        }

        public void FindShopByName(PlazaImpl plaza)
        {
            Console.WriteLine("What is the name of the shop?");
            string nameOfShop = Console.ReadLine();
            var shop = plaza.FindShopByName(nameOfShop);

            if(shop.IsOpen())
            {
                Console.WriteLine("\nname: " + shop.GetName() + ", owner: " + shop.GetOwner());

                while (true)
                {
                    Console.WriteLine($"Hi! This is the {nameOfShop} , welcome! Press\n" +
                        "1) to list available products.\n" +
                        "2) to find products and it's barcode by name.\n" +
                        "3) to display the shop's owner.\n" +
                        "4) to open the shop.\n" +
                        "5) to close the shop.\n" +
                        "6) to add new product to the shop.\n" +
                        "7) to buy a product by barcode.\n" +
                        "8) to add existing products to the shop.\n" +
                        "9) check price by barcode.\n" +
                        "10) go back to plaza.");

                    string choice = Console.ReadLine();

                    if (choice.Equals("1"))
                    {
                        if (shop.GetProducts().Count > 0)
                        {
                            foreach (var item in shop.GetProducts())
                            {
                                Console.WriteLine($"\t{item.GetName()} ({item.GetBarcode()})");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stock is EMPTY");
                        }
                    }

                    else if (choice.Equals("2"))
                    {
                        if (shop.GetProducts().Count > 0)
                        {
                            Console.WriteLine("What is the name of the product?");
                            string productName = Console.ReadLine();
                            var product = shop.FindByName(productName);
                            if (product is ClothingProduct)
                            {
                                ClothingProduct cloth = (ClothingProduct)product;
                                Console.WriteLine(cloth.GetManufacturer() + ", " + cloth.GetTypeOfCloth());
                            }
                            else
                            {
                                FoodProduct food = (FoodProduct)product;
                                Console.WriteLine(food.GetManufacturer() + ", " + "still consumable: "
                                    + food.isStillConsumable().ToString());
                            }
                            Console.WriteLine("Barcode: " + product.GetBarcode());
                        }
                        else
                        {
                            Console.WriteLine("Stock is EMPTY");
                        }
                    }

                    else if (choice.Equals("3"))
                    {
                        Console.WriteLine(shop.GetOwner());
                    }

                    else if (choice.Equals("4"))
                    {
                        if (shop.IsOpen())
                        {
                            Console.WriteLine("Shop already OPEN");
                        }
                        else
                        {
                            shop.Open();
                        }
                    }

                    else if (choice.Equals("5"))
                    {
                        if (!shop.IsOpen())
                        {
                            Console.WriteLine("Shop already CLOSED");
                        }
                        else
                        {
                            shop.Close();
                        }
                    }

                    else if (choice.Equals("6"))
                    {
                        Console.WriteLine("What product do you want to add? Press\n" +
                            "1) for Clothing Product\n" +
                            "2) for Food Product");

                        string choiceOfProducts = Console.ReadLine();
                        if (choiceOfProducts.Equals("1"))
                        {
                            ChoseCloth(shop);
                        }

                        else if (choiceOfProducts.Equals("2"))
                        {
                            ChoseFood(shop);
                        }
                    }

                    else if (choice.Equals("7"))
                    {
                        Console.WriteLine("Enter the barcode to buy the item!");
                        long barcode = long.Parse(Console.ReadLine());
                        this.cart.Add(shop.BuyProduct(barcode));
                        this.prices.Add(shop.GetPrice(barcode));
                        shop.GetProducts().Remove(shop.BuyProduct(barcode));
                    }

                    else if (choice.Equals("8"))
                    {
                        Console.WriteLine("Enter the barcode!");
                        long barcode = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the quantity!");
                        int quantity = int.Parse(Console.ReadLine());
                        shop.AddProduct(barcode, quantity);
                    }


                    else if (choice.Equals("9"))
                    {
                        Console.WriteLine("Enter the barcode to buy the item!");
                        long barcode = long.Parse(Console.ReadLine());
                        Console.WriteLine("It's: " + shop.GetPrice(barcode));
                    }

                    else if (choice.Equals("10"))
                    {
                        break;
                    }

                    else
                    {
                        throw new Exception("There was no argument like that!");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                throw new Exception("ShopIsClosedException");
            }
        }

        public void ChoseCloth(Shop shop)
        {
            Console.WriteLine("Add the name, manufacturer, material and type!");
            Random rand = new Random();
            string barCode = "";
            for (int count = 0; count < 6; count++)
                barCode += rand.Next(0, 9);

            long barcode = long.Parse(barCode);   //not unique in any cases
            string name = Console.ReadLine();
            string manufacturer = Console.ReadLine();
            string material = Console.ReadLine();
            string type = Console.ReadLine();

            Console.WriteLine("How much do you want to add?");
            int quantity;
            try
            {
                quantity = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Cannot parse string to int!");
            }


            Console.WriteLine("How much it costs?");
            float price;
            try
            {
                price = float.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Cannot parse string to float!");
            }

            ClothingProduct cloth = new ClothingProduct(barcode, name, manufacturer, material, type);
            shop.AddNewProduct(cloth, quantity, price);
        }

        public void ChoseFood(Shop shop)
        {
            Console.WriteLine("Add the name, manufacturer, calories!");
            Random rand = new Random();
            string barCode = "";    //not unique
            for (int count = 0; count < 6; count++)
                barCode += rand.Next(0, 9);

            long barcode = long.Parse(barCode);
            string name = Console.ReadLine();
            string manufacturer = Console.ReadLine();
            int calories;
            DateTime bestBefore;
            try
            {
                calories = int.Parse(Console.ReadLine());
                Console.WriteLine("Now the date!");
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("\nMonth: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("\nDay: ");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine();

                bestBefore = new DateTime(year, month, day);
            }
            catch
            {
                throw new Exception("Convertion Problem!");
            }

            Console.WriteLine("How much do you want to add?");
            int quantity;
            try
            {
                quantity = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Cannot parse string to int!");
            }


            Console.WriteLine("How much it costs?");
            float price;
            try
            {
                price = float.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Cannot parse string to float!");
            }

            FoodProduct food = new FoodProduct(barcode, name, manufacturer, calories, bestBefore);
            shop.AddNewProduct(food, quantity, price);
        }

    }
}
