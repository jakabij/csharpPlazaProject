using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public interface Shop
    {
        string GetName();
        string GetOwner();
        bool IsOpen();
        void Open();
        void Close();
        List<Product> GetProducts();
        Product FindByName(String name);
        float GetPrice(long barcode);
        bool HasProduct(long barcode);
        void AddNewProduct(Product product, int quantity, float price);
        void AddProduct(long barcode, int quantity);
        Product BuyProduct(long barcode);
        List<Product> BuyProducts(long barcode, int quantity);
    }
}
