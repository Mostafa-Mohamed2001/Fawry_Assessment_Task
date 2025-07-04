using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Customers;
using FawryChallenge.Interfaces;

namespace FawryChallenge.Service
{
    internal class CheckoutService
    {
        private readonly IShippingService _shipping;   
        public CheckoutService(IShippingService shippingService)
        {
            _shipping = shippingService;
        }
        public int SubTotal { get; set; }
        public int Shipping = 30;
        public int Amount { get; set; }
        public void Checkout(Customer customer, Cart cart)
        {
            _shipping.ShapingProducts(cart);
            _shipping.PrintShippableData();

            // handle customer name
            if (customer.Name.Length == 0)
                throw new Exception("Please Enter User Identity");
            // handle Empty Cart
            if (cart.CartList.Count == 0)
            {
                throw new Exception("Please Enter Cart Items");
            }
            Console.WriteLine("** Checkout Reciept **");
            foreach (var item in cart.CartList)
            {
                Console.WriteLine($"{item.Value}X {item.Key.Name}:  {item.Key.Price * item.Value}");
                SubTotal += (Decimal.ToInt32(item.Key.Price) * item.Value);
            }
            Amount = SubTotal+Shipping;
            customer.CalculateBalance(Amount);
            Console.WriteLine("----------------------------------------");
            CalculateAmount();
            Console.WriteLine($"Customer Balance: {customer.Balance}");
        }

        public void CalculateAmount()
        {
            Console.WriteLine($"Subtotal: {SubTotal}");
            Console.WriteLine($"Shipping: {Shipping}");
            Console.WriteLine($"Subtotal: {Amount}");
        }
        
    }
}
