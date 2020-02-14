using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class ShopImpl : Shop
    {
        private string name;
        private string owner;
        private Dictionary<double, ShopImpl.ShopEntryImpl> products;
        public ShopImpl(String name, String owner)
        {
            this.name = name;
            this.owner = owner;
        }

        public void AddNewProduct(Product product, int quantity, float price)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(long barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public Product BuyProduct(long barcode)
        {
            throw new NotImplementedException();
        }

        public List<Product> BuyProducts(long barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Product FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public string GetOwner()
        {
            throw new NotImplementedException();
        }

        public float GetPrice(long barcode)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool HasProduct(long barcode)
        {
            throw new NotImplementedException();
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
            private ShopEntryImpl(Product product, int quantity, float price)
            {
                this.product = product;
                this.quantity = quantity;
                this.price = price;
            }
            public Product GetProduct()
            {

            }
            public void SetProduct(Product product)
            {

            }
            public int GetQuantity()
            {

            }
            public void SetQuantity(int quantity)
            {

            }
            public void IncreaseQuantity(int amount)
            {

            }
            public void DecreaseQuantity(int amount)
            {

            }
            public float GetPrice()
            {

            }
            public void SetPrice(int price)
            {

            }
        }
    }
}
