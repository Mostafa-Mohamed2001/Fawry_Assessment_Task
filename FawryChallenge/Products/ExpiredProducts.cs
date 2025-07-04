using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Products
{
    internal class ExpiredProducts:Product
    {
        public DateTime ExpirationDate { get; set; }
    }
}
