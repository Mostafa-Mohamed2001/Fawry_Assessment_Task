using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Customers
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public void CalculateBalance(int productPrice)
        {
            // handle customer balance
            if(Balance == 0) { 
                return;
            }else if(Balance < productPrice){
                throw new Exception("Your Balance Is Not Enough");
            }
            else
            {
                Balance -= productPrice;
            }
        }
    }
}
