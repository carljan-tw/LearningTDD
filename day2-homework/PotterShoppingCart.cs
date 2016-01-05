using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart  
{
    public class PotterBook
    {
        public String Name { get; set; }

        public Decimal Price { get; set; }

    }

    public class PotterShoppingCart  
    {
        public Decimal CalculatePrice(IEnumerable<PotterBook> products)   
        {
            Decimal summaryPrice, discount; 
            var bookCount = products.Count();

            if (bookCount == 2)
            {
                discount = 0.95m;
            }
            else if (bookCount == 3)
            {
                discount = 0.9m;
            }
            else if (bookCount == 4)
            {
                discount = 0.8m;
            }
            else if (bookCount == 5)
            {
                discount = 0.75m;
            }
            else
            {
                discount = 1;
            }

            summaryPrice = products.Sum(x => x.Price) * discount;
            return summaryPrice;
         }
     }
}

