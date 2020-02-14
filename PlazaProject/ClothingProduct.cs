using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class ClothingProduct : Product
    {
        private string Material { get; set; }
        private string Type { get; set; }
        public ClothingProduct(long barcode, string name, string manufacturer, string material, string type)
            :base(barcode,name,manufacturer)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
            this.Material = material;
            this.Type = type;
        }

        public override long GetBarcode()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override string GetManufacturer()
        {
            throw new NotImplementedException();
        }
    }
}
