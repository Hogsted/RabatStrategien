using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabatStrategien.Model
{
    internal class StudentDiscount : IDiscountStrategy
    {
        public decimal applyDiscount(decimal subtotal)
        {
            return subtotal * 0.9m;
        }
    }
}
