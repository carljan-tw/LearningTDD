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
            Decimal summaryPrice; 
            var bookCount = products.Count(); 
            summaryPrice = products.Sum(x => x.Price);
            return summaryPrice;
         }
     }
}

