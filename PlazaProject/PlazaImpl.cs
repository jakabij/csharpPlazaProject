using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class PlazaImpl : Plaza
    {
        private List<Shop> shops;
        public PlazaImpl()
        {
            this.shops = new List<Shop>();
        }

        public void AddShop(Shop shop)
        {
            this.shops.Add(shop);
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Shop FindShopByName(string name)
        {
            foreach(var shop in shops)
            {
                
            }
            throw new NotImplementedException();
        }

        public List<Shop> GetShops()
        {
            return this.shops;
        }

        public bool IsOpen()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void RemoveShop(Shop shop)
        {
            if(shops.Contains(shop))
            {
                shops.Remove(shop);
            }
            else
            {
                throw new Exception("No shop like that!");
            }
        }
    }
}
