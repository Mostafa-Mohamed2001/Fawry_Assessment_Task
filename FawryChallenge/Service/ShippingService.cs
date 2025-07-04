using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Customers;
using FawryChallenge.Interfaces;
using FawryChallenge.Products;

namespace FawryChallenge.Service
{
    internal class ShippingService
    {

        //public List<Product> Products = new List<Product>();
        //public void AddShipabbleItem(Product product)
        //{
        //    if (product == null)
        //        throw new ArgumentNullException(nameof(product));

        //    if (product.IsShipabble && product.Weight > 0)
        //    {
        //        Products.Add(product);
        //    }
        //}

        IDictionary<Product, int> ShippableItems = new Dictionary<Product, int>();
        public void ShapingProducts(Cart cart)
        {

            foreach (var item in cart.CartList)
            {
                if (item.Key == null)
                    throw new ArgumentNullException(nameof(item.Key));

                if (item.Key.GetWeight() > 0 && item.Key.IsShipabble)
                {
                    ShippableItems.Add(item.Key,item.Value);
                }
            }
        }
        public void PrintShipabbleData()
        {
            double TotalWeight = 0;
            Console.WriteLine("** Shipment Notice **");
            foreach (var item in ShippableItems)
            {
                Console.WriteLine($"{item.Value}X {item.Key.GetName()}:  {item.Key.GetWeight()*item.Value}g");
                TotalWeight += (item.Key.GetWeight()*item.Value);
            }
            Console.WriteLine($"Total Package Weight = {TotalWeight / 1000.0:0.0}kg");
            Console.WriteLine();
        }
        //IDictionary<Product, int> ShippableItems = new Dictionary<Product, int>();
        //public void ShapingProducts(Cart cart)
        //{

        //    foreach (var item in cart.CartList)
        //    {
        //        if (item.Key.IsShipabble == true)
        //        {
        //            if (item.Key.Weight != null)
        //            {
        //                ShippableItems.Add(item.Key, item.Value);
        //            }
        //            else
        //            {
        //                throw new Exception($"{item.Key.Name} is shipabble item, please enter its weight");
        //            }
        //        }
        //    }
        //    PrintShipabbleData();
        //}

        //public void PrintShipabbleData()
        //{
        //    double TotalWeight = 0;
        //    Console.WriteLine("** Shipment Notice **");
        //    foreach (var item in ShippableItems)
        //    {
        //        Console.WriteLine($"{item.Value}X {item.Key.Name}:  {item.Key.Weight}g");
        //        TotalWeight += (double)item.Key.Weight;
        //    }
        //    Console.WriteLine($"Total Package Weight = {TotalWeight}");
        //    Console.WriteLine();
        //}

    }
    
        //public string GetName()
        //{
        //    throw new NotImplementedException();
        //}

        //public double GetWeight()
        //{
        //    throw new NotImplementedException();
        //}
    }

