using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class ShopImpl : Shop
    {
        private string name;
        private string owner;
        private Dictionary<long, ShopImpl.ShopEntryImpl> products; //long=barcode
        public ShopImpl(String name, String owner)
        {
            this.name = name;
            this.owner = owner;
        }

        public void AddNewProduct(Product product, int quantity, float price)
        {
            var shopEntryImpl=new ShopImpl.ShopEntryImpl(product,quantity,price);
            this.products.Add(product.GetBarcode(), shopEntryImpl);
        }

        public void AddProduct(long barcode, int quantity)
        {
            foreach(var shopBarCode in products.Keys)
            {
                if(shopBarCode.Equals(barcode))
                {
                    products[shopBarCode].IncreaseQuantity(quantity);
                }
                else
                {
                    throw new Exception("There was no shop like that!");
                }
            }
        }
        public Product BuyProduct(long barcode)
        {
            foreach (var shopBarCode in products.Keys)
            {
                if (shopBarCode.Equals(barcode))
                {
                    return products[shopBarCode].GetProduct();
                }
            }
            throw new Exception("There was no product like that!");
        }

        public List<Product> BuyProducts(long barcode, int quantity)
        {
            foreach (var shopBarCode in products.Keys)
            {
                if (shopBarCode.Equals(barcode))
                {
                    List<Product> listOfProducts = new List<Product>();
                    for(int count=0;count<quantity;count++)
                    { 
                        listOfProducts.Add(products[shopBarCode].GetProduct());
                    }
                    return listOfProducts;
                }
            }
            throw new Exception("There was no product like that!");
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Product FindByName(string name)
        {
            foreach (var shopEntry in products.Values)
            {
                if (shopEntry.GetProduct().GetName().Equals(name))
                {
                    return shopEntry.GetProduct();
                }
            }
            throw new Exception("There was no product like that!");
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetOwner()
        {
            return this.owner;
        }

        public float GetPrice(long barcode)
        {
            foreach (var shopBarCode in products.Keys)
            {
                if (shopBarCode.Equals(barcode))
                {
                    return products[shopBarCode].GetPrice();
                }
            }
            throw new Exception("There was no product like that!");
        }

        public List<Product> GetProducts()
        {
            List<Product> listOfProducts = new List<Product>();
            foreach(var shop in products.Values)
            {
                listOfProducts.Add(shop.GetProduct());
            }
            return listOfProducts;
        }

        public bool HasProduct(long barcode)
        {
            foreach(var code in products.Keys)
            {
                if(code.Equals(barcode))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsOpen()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        private class ShopEntryImpl
        {
            private Product product;
            private int quantity;
            private float price;

            public ShopEntryImpl(Product product, int quantity, float price)
            {
                this.product = product;
                this.quantity = quantity;
                this.price = price;
            }
            public Product GetProduct()
            {
                return this.product;
            }
            public void SetProduct(Product product)
            {
                this.product = product;
            }
            public int GetQuantity()
            {
                return this.quantity;
            }
            public void SetQuantity(int quantity)
            {
                this.quantity = quantity;
            }
            public void IncreaseQuantity(int amount)
            {
                this.quantity += amount;
            }
            public void DecreaseQuantity(int amount)
            {
                this.quantity -= amount;
            }
            public float GetPrice()
            {
                return this.price;
            }
            public void SetPrice(int price)
            {
                this.price = price;
            }
        }
    }
}
