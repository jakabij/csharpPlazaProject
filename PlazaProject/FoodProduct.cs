using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class FoodProduct : Product
    {
        private int Calories { get; set; }
        private DateTime bestBefore;
        public FoodProduct(long barcode, string name, string manufacturer, int calories, DateTime bestBefore)
            :base(barcode,name,manufacturer)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
            this.Calories = calories;
            this.bestBefore = bestBefore;
        }
        public bool isStillConsumable()
        {

        }
    }
}
