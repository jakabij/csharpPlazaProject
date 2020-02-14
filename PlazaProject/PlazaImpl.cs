using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    class PlazaImpl : Plaza
    {
        private List<Shop> shops;
        public PlazaImpl()
        {
            this.shops = new List<Shop>();
        }

        public void AddShop(Shop shop)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Shop FindShopByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Shop> GetShops()
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

        public void RemoveShop(Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
