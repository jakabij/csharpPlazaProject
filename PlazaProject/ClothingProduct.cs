using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class ClothingProduct : Product
    {
        private string material;
        private string type;
        public ClothingProduct(long barcode, string name, string manufacturer, string material, string type)
            :base(barcode,name,manufacturer)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
            this.material = material;
            this.type = type;
        }

        public override long GetBarcode()
        {
            return this.barcode;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override string GetManufacturer()
        {
            return this.manufacturer;
        }

        public string GetMaterial()
        {
            return this.material;
        }

        public string GetTypeOfCloth()
        {
            return this.type;
        }
    }
}
