using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class PlazaImpl : Plaza
    {
        private List<Shop> shops;
        private bool open;
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
            this.open = false;
        }

        public Shop FindShopByName(string name)
        {
            foreach(var shop in shops)
            {
                if(shop.GetName().Equals(name))
                {
                    return shop;
                }
            }
            throw new Exception("No shop like that!");
        }

        public List<Shop> GetShops()
        {
            return this.shops;
        }

        public bool IsOpen()
        {
            if(this.open)
            {
                return true;
            }
            return false;
        }

        public void Open()
        {
            this.open = true;
        }

        public void RemoveShop(Shop shop)
        {
            this.shops.Remove(shop);
        }
    }
}
