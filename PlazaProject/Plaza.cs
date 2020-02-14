using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public interface Plaza
    {
        List<Shop> GetShops();
        void AddShop(Shop shop);
        void RemoveShop(Shop shop);
        Shop FindShopByName(string name);
        bool IsOpen();
        void Open();
        void Close();

    }
}
