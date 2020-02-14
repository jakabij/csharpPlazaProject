using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    abstract public class Product
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
        abstract public long GetBarcode();
        abstract public string GetName();
        abstract public string GetManufacturer();
    }
}
