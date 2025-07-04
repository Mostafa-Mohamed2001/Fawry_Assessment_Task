using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Customers;

namespace FawryChallenge.Interfaces
{
    internal interface IShippingService
    {
        void ShapingProducts(Cart cart);
        void PrintShippableData();
    }
}
