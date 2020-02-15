using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class FoodProduct : Product
    {
        private int calories;
        private DateTime bestBefore;
        public FoodProduct(long barcode, string name, string manufacturer, int calories, DateTime bestBefore)
            :base(barcode,name,manufacturer)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
            this.calories = calories;
            this.bestBefore = bestBefore;
        }
        public bool isStillConsumable()
        {
            if(DateTime.Today<bestBefore)
            {
                return true;
            }
            return false;
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

        public int GetCalories()
        {
            return this.calories;
        }
    }
}
