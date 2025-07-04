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
            
            Product cheese = new Product() { Name="Cheese",Price=225,ProductQuantity=2,IsShipabble=true,Weight=420};
            Product biscuit = new Product() { Name= "Biscuit", Price=130,ProductQuantity=7, IsShipabble = true, Weight = 250 };
            Product tv = new Product() { Name= "TV", Price=317,ProductQuantity=16,IsShipabble=false,Weight=0};
            Cart cart = new Cart();
            cart.Add(cheese,2);
            cart.Add(biscuit,1);
            cart.Add(tv,1);

            ShippingService shippingService = new ShippingService();
            shippingService.ShapingProducts(cart);
            shippingService.PrintShipabbleData();

            CheckoutService checkout1 = new CheckoutService();
            checkout1.Checkout(customer,cart);
        }
    }
}
