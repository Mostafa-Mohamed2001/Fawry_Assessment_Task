using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Products;

namespace FawryChallenge.Customers
{
    internal class Cart
    {
        public IDictionary<Product, int> CartList = new Dictionary<Product, int>();
        public int QuantityToBuy { get; set; }

        public void Add(Product product, int QuantityToBuy)
        {
            // handle stock quantity
            if (product.ProductQuantity < QuantityToBuy)
            {
                throw new Exception($"The Product: {product.Name} has quantity less than your order");
            }
            // handle expiration date
            if(product.ExpirationDate >= DateTime.Now)
            {
                throw new Exception($"The Product: {product.Name} is Expired");
            }
            else
            {
                if (CartList.ContainsKey(product))
                {
                    CartList[product] += QuantityToBuy;
                }
                else { 
                    CartList.Add(product, QuantityToBuy);
                    product.CalculateQuantity(QuantityToBuy);
                }
            }
        }

       
    }
}
