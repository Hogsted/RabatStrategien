using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabatStrategien.Model
{
    internal class VIPDiscount : IDiscountStrategy
    {
        public decimal applyDiscount(decimal subtotal)
        {
            return subtotal * 0.8m;
        }
    }
}
