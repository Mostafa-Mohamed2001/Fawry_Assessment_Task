using FawryChallenge.Customers;
using FawryChallenge.Products;
using FawryChallenge.Service;

namespace FawryChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             Customer customer = new Customer() { Name="Mostafa",Balance=1000};

                //shipable and may have an expiration date
                Product cheese = new Product() { Name="Cheese",Price=225,ProductQuantity=2,IsShipabble=true,Weight=420};
                Product biscuit = new Product() { 
                    Name = "Biscuit", Price = 130, ProductQuantity = 7, IsShipabble = true, Weight = 250, //ExpirationDate= DateTime.Now.AddDays(1)
                };
                // not shipable and not expirable
                Product pen = new Product() { Name= "pen", Price=317,ProductQuantity=16,IsShipabble=false,Weight=0};
                Product scratchCard = new Product() { Name= "scratchCard", Price=10,ProductQuantity=16,Weight=0};
                Cart cart = new Cart();
                cart.Add(cheese,2);
                cart.Add(biscuit,1);
                cart.Add(pen, 1);
                cart.Add(scratchCard, 1);

            ShippingService shippingService = new ShippingService();
            shippingService.ShapingProducts(cart);
            shippingService.PrintShipabbleData();

            CheckoutService checkout1 = new CheckoutService();
            checkout1.Checkout(customer,cart);
        }
    }
}
