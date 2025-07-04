using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Interfaces;

namespace FawryChallenge.Products
{
    internal class Product:IShippable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductQuantity { get; set; }

        // optional for non-expired products like TV,Mobile
        public DateTime? ExpirationDate { get; set; }

        // set false for non-shipabble products
        public bool IsShipabble { get; set; }
        public double? Weight { get; set; }
        public void CalculateQuantity(int UserQuantity)
        {
            ProductQuantity -= UserQuantity;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return (double)Weight;
        }
    }
}
