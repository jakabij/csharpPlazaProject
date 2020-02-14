using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public abstract class Product
    {
        protected long barcode;
        protected string name;
        protected string manufacturer;
        protected Product(long barcode, string name, string manufacturer)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
        }
        public long getBarcode();
        string getName();
        string getManufacturer();
    }
}
